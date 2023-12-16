using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Address_Book_SDF
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user_tb.Text == "Sabir" && pswd_tb.Text == "admin123")
            {
                this.Hide();
                AdminPage ap = new AdminPage();
                ap.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void pswd_tb_TextChanged(object sender, EventArgs e)
        {
            pswd_tb.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pswd_tb.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
