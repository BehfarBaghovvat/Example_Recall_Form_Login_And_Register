using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_Recall_Form_Login_And_Register
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //===========================================
            //Close();

            //RegisterForm register =
            //    new RegisterForm();

            //register.Show();
            //============================================
            //Hide();

            //RegisterForm register =
            //    new RegisterForm();

            //register.Show();
            //============================================

            Infrastructure.Utility.registerForm.Show();
            Hide();





        }
    }
}
