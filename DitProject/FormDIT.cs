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
    public partial class FormDIT : Form
    {
        void ShowDIT()
        {
            //Предварительно очищаем listView
            listViewDIT.Items.Clear();
            //Проходимся по коллекции сотрудников, которые находятся в базе с помощью foreach
            foreach (DepartmentIT departmentIT in Program.ditDb.DepartmentIT)
            {
                //создаем новый элемент в listView
                //для этого создаем новый массив строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    departmentIT.Id.ToString(),
                    departmentIT.LastName,
                    departmentIT.FirstName,
                    departmentIT.MiddleName,
                    departmentIT.DateOfBirth.ToString(),
                    departmentIT.Phone,
                    departmentIT.Email,
                    departmentIT.Position
                });
                //указываем по какому тегу будем брать элементы
                item.Tag = departmentIT;
                //добавляем элементы в listView для отображения
                listViewDIT.Items.Add(item);
            }
            listViewDIT.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormDIT()
        {
            InitializeComponent();
            ShowDIT();
        }

        private void FormDIT_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Создаем новый экземпляр класса сотрудники
                DepartmentIT departmentIT = new DepartmentIT();
                //Делаем ссылку на объект, который хранится в textBox-ax
                departmentIT.FirstName = textBoxFirstName.Text;
                departmentIT.MiddleName = textBoxMiddleName.Text;
                departmentIT.LastName = textBoxLastName.Text;
                departmentIT.DateOfBirth = dateTimePickerDOB.Value;
                departmentIT.Phone = textBoxPhone.Text;
                departmentIT.Email = textBoxEmail.Text;
                departmentIT.Position = textBoxPosition.Text;
                if (departmentIT.FirstName == "" || departmentIT.MiddleName == "" || departmentIT.LastName == "")
                {
                    throw new Exception("Не заполнены поля ФИО");
                }
                //Добавляем в таблицу DepartmentIT нового сотрудника
                Program.ditDb.DepartmentIT.Add(departmentIT);
                //Сохраняем изменения в модели ditDb (экземпляр которой был создан ранее)
                Program.ditDb.SaveChanges();
                ShowDIT();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDIT.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    DepartmentIT departmentIT = listViewDIT.SelectedItems[0].Tag as DepartmentIT;
                    //Делаем ссылку на объект, который хранится в textBox-ax
                    departmentIT.FirstName = textBoxFirstName.Text;
                    departmentIT.MiddleName = textBoxMiddleName.Text;
                    departmentIT.LastName = textBoxLastName.Text;
                    departmentIT.DateOfBirth = dateTimePickerDOB.Value;
                    departmentIT.Phone = textBoxPhone.Text;
                    departmentIT.Email = textBoxEmail.Text;
                    departmentIT.Position = textBoxPosition.Text;
                    if (departmentIT.FirstName == "" || departmentIT.MiddleName == "" || departmentIT.LastName == "")
                    {
                        throw new Exception("Не заполнены поля ФИО");
                    }
                    //Сохраняем изменения в модели ditDb (экземпляр которой был создан ранее)
                    Program.ditDb.SaveChanges();
                    ShowDIT();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewDIT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDIT.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                DepartmentIT departmentIT = listViewDIT.SelectedItems[0].Tag as DepartmentIT;
                //указываем, что может быть изменено
                textBoxFirstName.Text = departmentIT.FirstName;
                textBoxMiddleName.Text = departmentIT.MiddleName;
                textBoxLastName.Text = departmentIT.LastName;
                textBoxPhone.Text = departmentIT.Phone;
                textBoxEmail.Text = departmentIT.Email;
                dateTimePickerDOB.Value = departmentIT.DateOfBirth;
                textBoxPosition.Text = departmentIT.Position;
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxPosition.Text = "";
                dateTimePickerDOB.Value = DateTime.Now;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDIT.SelectedItems.Count == 1)
                {
                    DepartmentIT departmentIT = listViewDIT.SelectedItems[0].Tag as DepartmentIT;
                    Program.ditDb.DepartmentIT.Remove(departmentIT);
                    Program.ditDb.SaveChanges();
                    ShowDIT();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxPosition.Text = "";
                dateTimePickerDOB.Value = DateTime.Now;
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

