using QRCoder;
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
    public partial class CUSTOMER_INTERFACE : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public CUSTOMER_INTERFACE()
        {
            InitializeComponent();
        }

        private void CUSTOMER_INTERFACE_Load(object sender, EventArgs e)
        {
            Table_slot s = new Table_slot();
            var lod = db.Table_slots.ToList();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void P1_Paint(object sender, PaintEventArgs e)
        {
          
        }




        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void txtQRcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void P2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedColor = comboBox.SelectedItem.ToString();
            Panel panel = this.P2;
            switch (selectedColor)
            {
                case "occupied":
                    P2.BackColor = Color.Red;
                    break;
                case "vacant":
                    P2.BackColor = Color.LimeGreen;
                    break;


            }
        }

        private void P3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void P4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedColor = comboBox.SelectedItem.ToString();
            Panel panel = this.P1;
            switch (selectedColor)
            {
                case "occupied":
                    P1.BackColor = Color.Red;
                    break;
                case "vacant":
                    P1.BackColor = Color.LimeGreen;
                    break;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedColor = comboBox.SelectedItem.ToString();
            Panel panel = this.P3;
            switch (selectedColor)
            {
                case "occupied":
                    P3.BackColor = Color.Red;
                    break;
                case "vacant":
                    P3.BackColor = Color.LimeGreen;
                    break;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedColor = comboBox.SelectedItem.ToString();
            Panel panel = this.P4;
            switch (selectedColor)
            {
                case "occupied":
                    P4.BackColor = Color.Red;
                    break;
                case "vacant":
                    P4.BackColor = Color.LimeGreen;
                    break;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedColor = comboBox.SelectedItem.ToString();
            Panel panel = this.P5;
            switch (selectedColor)
            {
                case "occupied":
                    P5.BackColor = Color.Red;
                    break;
                case "vacant":
                    P5.BackColor = Color.LimeGreen;
                    break;
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedColor = comboBox.SelectedItem.ToString();
            Panel panel = this.P6;
            switch (selectedColor)
            {
                case "occupied":
                    P6.BackColor = Color.Red;
                    break;
                case "vacant":
                    P6.BackColor = Color.LimeGreen;
                    break;
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedColor = comboBox.SelectedItem.ToString();
            Panel panel = this.P7;
            switch (selectedColor)
            {
                case "occupied":
                    P7.BackColor = Color.Red;
                    break;
                case "vacant":
                    P7.BackColor = Color.LimeGreen;
                    break;
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedColor = comboBox.SelectedItem.ToString();
            Panel panel = this.P8;
            switch (selectedColor)
            {
                case "occupied":
                    P8.BackColor = Color.Red;
                    break;
                case "vacant":
                    P8.BackColor = Color.LimeGreen;
                    break;
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedColor = comboBox.SelectedItem.ToString();
            Panel panel = this.P9;
            switch (selectedColor)
            {
                case "occupied":
                    P9.BackColor = Color.Red;
                    break;
                case "vacant":
                    P9.BackColor = Color.LimeGreen;
                    break;
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedColor = comboBox.SelectedItem.ToString();
            Panel panel = this.P10;
            switch (selectedColor)
            {
                case "occupied":
                    P10.BackColor = Color.Red;
                    break;
                case "vacant":
                    P10.BackColor = Color.LimeGreen;
                    break;
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedColor = comboBox.SelectedItem.ToString();
            Panel panel = this.P11;
            switch (selectedColor)
            {
                case "occupied":
                    P11.BackColor = Color.Red;
                    break;
                case "vacant":
                    P11.BackColor = Color.LimeGreen;
                    break;
            }
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedColor = comboBox.SelectedItem.ToString();
            Panel panel = this.P12;
            switch (selectedColor)
            {
                case "occupied":
                    P12.BackColor = Color.Red;
                    break;
                case "vacant":
                    P12.BackColor = Color.LimeGreen;
                    break;
            }
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedColor = comboBox.SelectedItem.ToString();
            Panel panel = this.P13;
            switch (selectedColor)
            {
                case "occupied":
                    P13.BackColor = Color.Red;
                    break;
                case "vacant":
                    P13.BackColor = Color.LimeGreen;
                    break;
            }
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedColor = comboBox.SelectedItem.ToString();
            Panel panel = this.P14;
            switch (selectedColor)
            {
                case "occupied":
                    P14.BackColor = Color.Red;
                    break;
                case "vacant":
                    P14.BackColor = Color.LimeGreen;
                    break;
            }
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedColor = comboBox.SelectedItem.ToString();
            Panel panel = this.P15;
            switch (selectedColor)
            {
                case "occupied":
                    P15.BackColor = Color.Red;
                    break;
                case "vacant":
                    P15.BackColor = Color.LimeGreen;
                    break;
            }
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedColor = comboBox.SelectedItem.ToString();
            Panel panel = this.P16;
            switch (selectedColor)
            {
                case "occupied":
                    P16.BackColor = Color.Red;
                    break;
                case "vacant":
                    P16.BackColor = Color.LimeGreen;
                    break;
            }
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedColor = comboBox.SelectedItem.ToString();
            Panel panel = this.P17;
            switch (selectedColor)
            {
                case "occupied":
                    P17.BackColor = Color.Red;
                    break;
                case "vacant":
                    P17.BackColor = Color.LimeGreen;
                    break;
            }
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedColor = comboBox.SelectedItem.ToString();
            Panel panel = this.P18;
            switch (selectedColor)
            {
                case "occupied":
                    P18.BackColor = Color.Red;
                    break;
                case "vacant":
                    P18.BackColor = Color.LimeGreen;
                    break;
            }
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedColor = comboBox.SelectedItem.ToString();
            Panel panel = this.P19;
            switch (selectedColor)
            {
                case "occupied":
                    P19.BackColor = Color.Red;
                    break;
                case "vacant":
                    P19.BackColor = Color.LimeGreen;
                    break;
            }
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedColor = comboBox.SelectedItem.ToString();
            Panel panel = this.P20;
            switch (selectedColor)
            {
                case "occupied":
                    P20.BackColor = Color.Red;
                    break;
                case "vacant":
                    P20.BackColor = Color.LimeGreen;
                    break;
            }
        }
    }
}

