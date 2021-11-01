using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gmail_sender_app
{
    public partial class SignPassword : Form
    {
        string email="";
        public SignPassword(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_password_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            txt_password.isPassword = true;
        }

        void login()
        {
            if (!string.IsNullOrWhiteSpace(txt_password.Text))
            {
                new EmailSender(email, txt_password.Text).Show();
                this.Close();
            }

            else

            {
                errorProvider1.SetError(txt_password, "Enter password");
            }
        }
        private void btn_next_Click(object sender, EventArgs e)
        {

            login();
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                login();
        }
    }
}
