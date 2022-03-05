using System;
using System.Windows.Forms;

namespace StudentsLogInForm
{
    public partial class StudentLogIn : Form
    {
        public StudentLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            RegForm form = new RegForm();
            form.ShowDialog();
        }
    }
}
