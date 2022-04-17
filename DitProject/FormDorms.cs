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
    public partial class FormDorms : Form
    {
        void ShowDorms()
        {
            //Предварительно очищаем listView
            listViewDorm.Items.Clear();
            //Проходимся по коллекции общежитий, которые находятся в базе с помощью foreach
            foreach (Dorms dorm in Program.ditDb.Dorms)
            {
                //создаем новый элемент в listView
                //для этого создаем новый массив строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    dorm.Id.ToString(),
                    dorm.NumDormitory.ToString(),
                    dorm.Address
                });
                //указываем по какому тегу будем брать элементы
                item.Tag = dorm;
                //добавляем элементы в listView для отображения
                listViewDorm.Items.Add(item);
            }
            listViewDorm.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormDorms()
        {
            InitializeComponent();
            ShowDorms();
        }

        private void FormDorms_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Создаем новый экземпляр класса общежития
                Dorms dorm = new Dorms();
                //Делаем ссылку на объект, который хранится в textBox-ax
                dorm.NumDormitory = Convert.ToInt32(textBoxNumDorm.Text);
                dorm.Address = textBoxAddress.Text;
                //Добавляем в таблицу Dorms новое общежитие
                Program.ditDb.Dorms.Add(dorm);
                //Сохраняем изменения в модели ditDb (экземпляр которой был создан ранее)
                Program.ditDb.SaveChanges();
                ShowDorms();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDorm.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    Dorms dorm = listViewDorm.SelectedItems[0].Tag as Dorms;
                    //Делаем ссылку на объект, который хранится в textBox-ax
                    dorm.NumDormitory = Convert.ToInt32(textBoxNumDorm.Text);
                    dorm.Address = textBoxAddress.Text;
                    //Сохраняем изменения в модели ditDb (экземпляр которой был создан ранее)
                    Program.ditDb.SaveChanges();
                    ShowDorms();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewDorm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDorm.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                Dorms dorm = listViewDorm.SelectedItems[0].Tag as Dorms;
                //указываем, что может быть изменено
                textBoxNumDorm.Text = dorm.NumDormitory.ToString();
                textBoxAddress.Text = dorm.Address;
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                textBoxNumDorm.Text = "";
                textBoxAddress.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDorm.SelectedItems.Count == 1)
                {
                    Dorms dorm = listViewDorm.SelectedItems[0].Tag as Dorms;
                    Program.ditDb.Dorms.Remove(dorm);
                    Program.ditDb.SaveChanges();
                    ShowDorms();
                }
                textBoxNumDorm.Text = "";
                textBoxAddress.Text = "";
            }
            catch { MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void textBoxNumDorm_KeyPress(object sender, KeyPressEventArgs e)
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
