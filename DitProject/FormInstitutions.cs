using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DitProject
{
    public partial class FormInstitutions : Form
    {
        void ShowInstitutions()
        {
            //Предварительно очищаем listView
            listViewInstit.Items.Clear();
            //Проходимся по коллекции институтов, которые находятся в базе с помощью foreach
            foreach (Institutions instit in Program.ditDb.Institutions)
            {
                //создаем новый элемент в listView
                //для этого создаем новый массив строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    instit.Id.ToString(),
                    instit.NumBuilding.ToString(),
                    instit.Address
                });
                //указываем по какому тегу будем брать элементы
                item.Tag = instit;
                //добавляем элементы в listView для отображения
                listViewInstit.Items.Add(item);
            }
            listViewInstit.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormInstitutions()
        {
            InitializeComponent();
            ShowInstitutions();
        }

        private void FormInstitutions_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Создаем новый экземпляр класса института
                Institutions instit = new Institutions();
                //Делаем ссылку на объект, который хранится в textBox-ax
                instit.NumBuilding = Convert.ToInt32(textBoxNumBuilding.Text);
                instit.Address = textBoxAddress.Text;
                //Добавляем в таблицу Institutions новый институт
                Program.ditDb.Institutions.Add(instit);
                //Сохраняем изменения в модели ditDb (экземпляр которой был создан ранее)
                Program.ditDb.SaveChanges();
                ShowInstitutions();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewInstit.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    Institutions instit = listViewInstit.SelectedItems[0].Tag as Institutions;
                    //Делаем ссылку на объект, который хранится в textBox-ax
                    instit.NumBuilding = Convert.ToInt32(textBoxNumBuilding.Text);
                    instit.Address = textBoxAddress.Text;
                    //Сохраняем изменения в модели ditDb (экземпляр которой был создан ранее)
                    Program.ditDb.SaveChanges();
                    ShowInstitutions();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewInstit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewInstit.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                Institutions instit = listViewInstit.SelectedItems[0].Tag as Institutions;
                //указываем, что может быть изменено
                textBoxNumBuilding.Text = instit.NumBuilding.ToString();
                textBoxAddress.Text = instit.Address;
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                textBoxNumBuilding.Text = "";
                textBoxAddress.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewInstit.SelectedItems.Count == 1)
                {
                    Institutions instit = listViewInstit.SelectedItems[0].Tag as Institutions;
                    Program.ditDb.Institutions.Remove(instit);
                    Program.ditDb.SaveChanges();
                    ShowInstitutions();
                }
                textBoxNumBuilding.Text = "";
                textBoxAddress.Text = "";
            }
            catch { MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void textBoxNumBuilding_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ограничиваем ввод данных
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace 
            {
                e.Handled = true;
            }
        }
    }
}
