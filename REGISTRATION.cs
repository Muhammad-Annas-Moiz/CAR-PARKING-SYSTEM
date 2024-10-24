using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_parking_system1
{
    public partial class REGISTRATION : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public REGISTRATION()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textusername.Text != null & textpassword.Text != null & textBoxEMAIL.Text != null)
                {
                    TBL_Account s = new TBL_Account();

                    s.UserName = textusername.Text;
                    s.Password = textpassword.Text;
                    s.Email = textBoxEMAIL.Text;

                    db.SubmitChanges();
                    db.TBL_Accounts.InsertOnSubmit(s);
                    db.SubmitChanges();
                    MessageBox.Show("Registered successfully!...");

                    LOGIN l = new LOGIN();
                    l.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("username, password or Email not.....valid!");
                }
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

       
        
           

            }
        }


