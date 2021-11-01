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
    public partial class SignEmail : Form
    {
        public SignEmail()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SignEmail_Load(object sender, EventArgs e)
        {
            lbl_email.Visible = false;
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            lbl_email.Visible = true;
        }

        void login()
        {
            if (!string.IsNullOrWhiteSpace(txt_email.Text))
            {
                string email = txt_email.Text;
                new SignPassword(email).Show();
                this.Close();
            }
            else
            {
                errorProvider1.SetError(txt_email, "Enter email or phone");
            }
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            login();
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_email.Text))
                lbl_email.Visible = false;
        }

        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                login();
        }
    }
}
