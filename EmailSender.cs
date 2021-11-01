using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace gmail_sender_app
{
    public partial class EmailSender : Form
    {
        string password, email;
        MailMessage mail = new MailMessage();
        SmtpClient smtserver = new SmtpClient("smtp.gmail.com",587);
        public EmailSender(string email, string password)
        {
            InitializeComponent();
            this.password = password;
            this.email = email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mail.From = new MailAddress(email);
                mail.To.Add(txt_to.Text);
                mail.Subject = txt_subject.Text;
                mail.Body = txt_msg.Text;
                smtserver.Credentials = new System.Net.NetworkCredential(email, password);
                smtserver.EnableSsl = true;
                smtserver.Send(mail);
                MessageBox.Show("Mail has been sent", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            new SignEmail().Show();
            this.Close();
        }

        private void txt_to_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_subject.Focus();
        }

        private void txt_subject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_msg.Focus();
        }

        private void txt_msg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
