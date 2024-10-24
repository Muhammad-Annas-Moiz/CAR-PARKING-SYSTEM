using DGVPrinterHelper;
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
    public partial class Reservation : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Reservation()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            var id = db.Table_departures.ToList();
            dataGridView1.DataSource = id;
            display();
        }
        public void display()
        {

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);

            }
            label_amount.Text = sum.ToString();


            var slot = db.Table_slots.Count();
            labelc.Text = slot.ToString();
            var pca = db.Table_arrivals.Count();
            labelarrive.Text = pca.ToString();

            var pca1 = db.Table_departures.Count();
            label_total_departed.Text = pca1.ToString();
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelpaidfee_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                

            }
            else
            {
                searchdata();
            }
        }
        public void searchdata()
        {

            try
            {
                if (textBox1.Text != null)
                {
                    string sk = textBox1.Text;
                    var chk = db.Table_departures.Where(o => o.Driver_name == sk || o.Car_No == sk | o.Make_model == sk).ToList();
                    if (chk != null)
                    {

                        dataGridView1.DataSource = chk;
                        display();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void labelc_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVPrinter p = new DGVPrinter();
            p.printDocument = printDocument1;
            p.Title = "complete report";
            p.SubTitle = string.Format("date:{0}", DateTime.Now);

            p.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            p.printDocument = printDocument1;
            p.PageNumbers = true;

            p.PageNumberInHeader = true;

            p.PorportionalColumns = true;
            p.HeaderCellAlignment = StringAlignment.Near;
            p.Footer = "car parking system";

            p.FooterSpacing = 15;
            p.PrintDataGridView(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            INVOICE i = new INVOICE();
            i.Show();
            this.Hide();
        }
    }
}
  
