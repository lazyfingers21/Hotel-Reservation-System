using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Security;

namespace FINAL_SIR_GELLO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Login2 user = new Login2("user", "111");

        private void btnLoginClick(object sender, EventArgs e)
        {

            if((txtBxUsername.Text == user.USERNAME && txtBxPassword.Text == user.PASSWORD))
            {
                MessageBox.Show("Successfully Logged In! Welcome User!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }

            else if (txtBxUsername.Text != user.USERNAME && txtBxPassword.Text == user.PASSWORD)
            {
                MessageBox.Show("Wrong Username!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBxUsername.Clear();
                txtBxUsername.Focus();
            }
            else if (txtBxUsername.Text == user.USERNAME && txtBxPassword.Text != user.PASSWORD)
            {
                MessageBox.Show("Wrong Password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBxPassword.Clear();
                txtBxPassword.Focus();
            }
            else
            {
                MessageBox.Show("Wrong Username and Password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBxUsername.Clear();
                txtBxPassword.Clear();
                txtBxUsername.Focus();
            }

        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



 


 

    


        



    }
}
