using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 
namespace Car_parking_system1
{
    public partial class LOGIN : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public LOGIN()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textusername.Text!= null & textpassword.Text!=null)
                    {
                    var item = db.TBL_Accounts.Where(s => s.UserName == textusername.Text & s.Password == textpassword.Text).FirstOrDefault();
                    if (item != null)
                    {
                        Welcome_page wc = new Welcome_page();
                        wc.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("username or password not.....valid!");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
