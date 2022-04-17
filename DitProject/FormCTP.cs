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
    public partial class FormCTP : Form
    {
        void ShowCTP()
        {
            //Предварительно очищаем listView
            listViewCTP.Items.Clear();
            //Проходимся по коллекции сотрудников, которые находятся в базе с помощью foreach
            foreach (TechnicalSupportCenter ctp in Program.ditDb.TechnicalSupportCenter)
            {
                //создаем новый элемент в listView
                //для этого создаем новый массив строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    ctp.Id.ToString(),
                    ctp.Institutions.NumBuilding + ", адрес: " + ctp.Institutions.Address,
                    ctp.Dorms.NumDormitory + ", адрес: " + ctp.Dorms.Address,
                    ctp.LastName,
                    ctp.FirstName,
                    ctp.MiddleName,
                    ctp.DateOfBirth.ToString(),
                    ctp.Phone,
                    ctp.Email,
                    ctp.Position
                });
                //указываем по какому тегу будем брать элементы
                item.Tag = ctp;
                //добавляем элементы в listView для отображения
                listViewCTP.Items.Add(item);
            }
            listViewCTP.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowInstit()
        {
            comboBoxInstit.Items.Clear();
            foreach (Institutions instit in Program.ditDb.Institutions)
            {
                string[] item = { instit.Id.ToString() + ". Корпус: ", instit.NumBuilding + ". Адрес: " + instit.Address };
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
        public FormCTP()
        {
            InitializeComponent();
            ShowCTP();
            ShowInstit();
            ShowDorms();
        }

        private void FormCTP_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Создаем новый экземпляр класса сотрудники
                TechnicalSupportCenter ctp = new TechnicalSupportCenter();
                //Делаем ссылку на объект, который хранится в textBox-ax
                ctp.IdInstit = Convert.ToInt32(comboBoxInstit.SelectedItem.ToString().Split('.')[0]);
                ctp.IdDorm = Convert.ToInt32(comboBoxDorm.SelectedItem.ToString().Split('.')[0]);
                ctp.FirstName = textBoxFirstName.Text;
                ctp.MiddleName = textBoxMiddleName.Text;
                ctp.LastName = textBoxLastName.Text;
                ctp.DateOfBirth = dateTimePickerCTP.Value;
                ctp.Phone = textBoxPhone.Text;
                ctp.Email = textBoxEmail.Text;
                ctp.Position = textBoxPosition.Text;
                if (ctp.FirstName == "" || ctp.MiddleName == "" || ctp.LastName == "")
                {
                    throw new Exception("Не заполнены поля ФИО");
                }
                //Добавляем в таблицу TechicalSupportCenter нового сотрудника
                Program.ditDb.TechnicalSupportCenter.Add(ctp);
                //Сохраняем изменения в модели ditDb (экземпляр которой был создан ранее)
                Program.ditDb.SaveChanges();
                ShowCTP();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCTP.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    TechnicalSupportCenter ctp = listViewCTP.SelectedItems[0].Tag as TechnicalSupportCenter;
                    //Делаем ссылку на объект, который хранится в textBox-ax
                    ctp.IdInstit = Convert.ToInt32(comboBoxInstit.SelectedItem.ToString().Split('.')[0]);
                    ctp.IdDorm = Convert.ToInt32(comboBoxDorm.SelectedItem.ToString().Split('.')[0]);
                    ctp.FirstName = textBoxFirstName.Text;
                    ctp.MiddleName = textBoxMiddleName.Text;
                    ctp.LastName = textBoxLastName.Text;
                    ctp.DateOfBirth = dateTimePickerCTP.Value;
                    ctp.Phone = textBoxPhone.Text;
                    ctp.Email = textBoxEmail.Text;
                    ctp.Position = textBoxPosition.Text;
                    if (ctp.FirstName == "" || ctp.MiddleName == "" || ctp.LastName == "")
                    {
                        throw new Exception("Не заполнены поля ФИО");
                    }
                    //Сохраняем изменения в модели ditDb (экземпляр которой был создан ранее)
                    Program.ditDb.SaveChanges();
                    ShowCTP();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewCTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCTP.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                TechnicalSupportCenter ctp = listViewCTP.SelectedItems[0].Tag as TechnicalSupportCenter;
                //указываем, что может быть изменено
                comboBoxInstit.SelectedIndex = comboBoxInstit.FindString(ctp.IdInstit.ToString());
                comboBoxDorm.SelectedIndex = comboBoxDorm.FindString(ctp.IdDorm.ToString());
                textBoxFirstName.Text = ctp.FirstName;
                textBoxMiddleName.Text = ctp.MiddleName;
                textBoxLastName.Text = ctp.LastName;
                textBoxPhone.Text = ctp.Phone;
                textBoxEmail.Text = ctp.Email;
                dateTimePickerCTP.Value = ctp.DateOfBirth;
                textBoxPosition.Text = ctp.Position;
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
                dateTimePickerCTP.Value = DateTime.Now;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCTP.SelectedItems.Count == 1)
                {
                    TechnicalSupportCenter ctp = listViewCTP.SelectedItems[0].Tag as TechnicalSupportCenter;
                    Program.ditDb.TechnicalSupportCenter.Remove(ctp);
                    Program.ditDb.SaveChanges();
                    ShowCTP();
                }
                comboBoxInstit.SelectedItem = null;
                comboBoxDorm.SelectedItem = null;
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxPosition.Text = "";
                dateTimePickerCTP.Value = DateTime.Now;
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
