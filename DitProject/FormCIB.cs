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
    public partial class FormCIB : Form
    {
        void ShowCIB()
        {
            //Предварительно очищаем listView
            listViewCIB.Items.Clear();
            //Проходимся по коллекции сотрудников, которые находятся в базе с помощью foreach
            foreach (InformationSecurityCenter cib in Program.ditDb.InformationSecurityCenter)
            {
                //создаем новый элемент в listView
                //для этого создаем новый массив строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    cib.Id.ToString(),
                    cib.Institutions.NumBuilding + ", адрес: " + cib.Institutions.Address,
                    cib.Dorms.NumDormitory + ", адрес: " + cib.Dorms.Address,
                    cib.LastName,
                    cib.FirstName,
                    cib.MiddleName,
                    cib.DateOfBirth.ToString(),
                    cib.Phone,
                    cib.Email,
                    cib.Position
                });
                //указываем по какому тегу будем брать элементы
                item.Tag = cib;
                //добавляем элементы в listView для отображения
                listViewCIB.Items.Add(item);
            }
            listViewCIB.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowInstit()
        {
            comboBoxInstit.Items.Clear();
            foreach (Institutions instit in Program.ditDb.Institutions)
            {
                string[] item = { instit.Id.ToString() + ". Корпус: ", instit.NumBuilding + ". Адрес: " + instit.Address};
                comboBoxInstit.Items.Add(string.Join(" ", item));
            }
        }
        void ShowDorms()
        {
            comboBoxDorm.Items.Clear();
            foreach (Dorms dorm in Program.ditDb.Dorms)
            {
                string[] item = { dorm.Id.ToString() + ". Номер: ", dorm.NumDormitory + ". Адрес: " + dorm.Address };
                comboBoxDorm.Items.Add(string.Join(" ", item));
            }
        }
        public FormCIB()
        {
            InitializeComponent();
            ShowCIB();
            ShowInstit();
            ShowDorms();
        }

        private void FormCIB_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Создаем новый экземпляр класса сотрудники
                InformationSecurityCenter cib = new InformationSecurityCenter();
                //Делаем ссылку на объект, который хранится в textBox-ax
                cib.IdInstit = Convert.ToInt32(comboBoxInstit.SelectedItem.ToString().Split('.')[0]);
                cib.IdDorm = Convert.ToInt32(comboBoxDorm.SelectedItem.ToString().Split('.')[0]);
                cib.FirstName = textBoxFirstName.Text;
                cib.MiddleName = textBoxMiddleName.Text;
                cib.LastName = textBoxLastName.Text;
                cib.DateOfBirth = dateTimePickerCIB.Value;
                cib.Phone = textBoxPhone.Text;
                cib.Email = textBoxEmail.Text;
                cib.Position = textBoxPosition.Text;
                if (cib.FirstName == "" || cib.MiddleName == "" || cib.LastName == "")
                {
                    throw new Exception("Не заполнены поля ФИО");
                }
                //Добавляем в таблицу InformationSecurityCenter нового сотрудника
                Program.ditDb.InformationSecurityCenter.Add(cib);
                //Сохраняем изменения в модели ditDb (экземпляр которой был создан ранее)
                Program.ditDb.SaveChanges();
                ShowCIB();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCIB.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    InformationSecurityCenter cib = listViewCIB.SelectedItems[0].Tag as InformationSecurityCenter;
                    //Делаем ссылку на объект, который хранится в textBox-ax
                    cib.IdInstit = Convert.ToInt32(comboBoxInstit.SelectedItem.ToString().Split('.')[0]);
                    cib.IdDorm = Convert.ToInt32(comboBoxDorm.SelectedItem.ToString().Split('.')[0]);
                    cib.FirstName = textBoxFirstName.Text;
                    cib.MiddleName = textBoxMiddleName.Text;
                    cib.LastName = textBoxLastName.Text;
                    cib.DateOfBirth = dateTimePickerCIB.Value;
                    cib.Phone = textBoxPhone.Text;
                    cib.Email = textBoxEmail.Text;
                    cib.Position = textBoxPosition.Text;
                    if (cib.FirstName == "" || cib.MiddleName == "" || cib.LastName == "")
                    {
                        throw new Exception("Не заполнены поля ФИО");
                    }
                    //Сохраняем изменения в модели ditDb (экземпляр которой был создан ранее)
                    Program.ditDb.SaveChanges();
                    ShowCIB();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewCIB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCIB.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                InformationSecurityCenter cib = listViewCIB.SelectedItems[0].Tag as InformationSecurityCenter;
                //указываем, что может быть изменено
                comboBoxInstit.SelectedIndex = comboBoxInstit.FindString(cib.IdInstit.ToString());
                comboBoxDorm.SelectedIndex = comboBoxDorm.FindString(cib.IdDorm.ToString());
                textBoxFirstName.Text = cib.FirstName;
                textBoxMiddleName.Text = cib.MiddleName;
                textBoxLastName.Text = cib.LastName;
                textBoxPhone.Text = cib.Phone;
                textBoxEmail.Text = cib.Email;
                dateTimePickerCIB.Value = cib.DateOfBirth;
                textBoxPosition.Text = cib.Position;
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                comboBoxInstit.SelectedItem = null;
                comboBoxDorm.SelectedItem = null;
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxPosition.Text = "";
                dateTimePickerCIB.Value = DateTime.Now;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCIB.SelectedItems.Count == 1)
                {
                    InformationSecurityCenter cib = listViewCIB.SelectedItems[0].Tag as InformationSecurityCenter;
                    Program.ditDb.InformationSecurityCenter.Remove(cib);
                    Program.ditDb.SaveChanges();
                    ShowCIB();
                }
                comboBoxInstit.SelectedItem = null;
                comboBoxDorm.SelectedItem = null;
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxPosition.Text = "";
                dateTimePickerCIB.Value = DateTime.Now;
            }
            catch { MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
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
