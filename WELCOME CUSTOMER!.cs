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
    public partial class WELCOME_CUSTOMER_ : Form
    {
        public WELCOME_CUSTOMER_()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CUSTOMER_INTERFACE c = new CUSTOMER_INTERFACE();
            c.Show();
            this.Hide();


        }

        private void WELCOME_CUSTOMER__Load(object sender, EventArgs e)
        {

        }
    }
}
