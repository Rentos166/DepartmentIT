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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonCIB_Click(object sender, EventArgs e)
        {
            FormCIB formCIB = new FormCIB();
            formCIB.Show();
        }

        private void buttonCTP_Click(object sender, EventArgs e)
        {
            FormCTP formCTP = new FormCTP();
            formCTP.Show();
        }

        private void buttonInstit_Click(object sender, EventArgs e)
        {
            FormInstitutions formInstit = new FormInstitutions();
            formInstit.Show();
        }

        private void buttonDorms_Click(object sender, EventArgs e)
        {
            FormDorms formDorms = new FormDorms();
            formDorms.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormAuthorization authorization = new FormAuthorization();
            authorization.Show();
            this.Hide();
        }
    }
}
