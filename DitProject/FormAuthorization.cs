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
    public partial class FormAuthorization : Form
    {
        public struct User
        {
            public string name;
            public string login;
            public string password;
            public string type;
        }
        public static User users = new User();
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {

        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                //ищем в базе данных пользователя с такими логином и паролем и запоминаем их
                foreach (Users user in Program.ditDb.Users)
                {
                    if (textBoxLogin.Text == user.Login && textBoxPassword.Text == user.Password)
                    {
                        key = true;
                        users.login = user.Login;
                        users.password = user.Password;
                        users.type = user.Type;
                    }
                }
                if (!key)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Вы вошли в систему как: " + FormAuthorization.users.type + ", " + FormAuthorization.users.login, "Авторизация успешна", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                    textBoxPassword.Text = "";
                }
            }
        }
    }
}
