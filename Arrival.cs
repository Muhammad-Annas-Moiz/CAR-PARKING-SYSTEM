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
    public partial class Arrival : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Arrival()
        {
            InitializeComponent();
        }
        public void load()
        {
            var id = db.Table_arrivals.ToList();
            dataGridView1.DataSource = id;
            label1.Text = "";
            textdriver.Text = "";
            text_carno.Text = "";
            textPtime.Text = "";
            checkedListBox1.Text = "";

            var total = db.Table_arrivals.Count();
            labelTotal.Text = total.ToString();


        }

        private void Arrival_Load(object sender, EventArgs e)
        {
            load();
            comboBox1.DataSource = db.Table_slots.ToList();
            comboBox1.ValueMember = "SLOT__";
            comboBox1.DisplayMember = "slot_no";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Welcome_page w = new Welcome_page();
            w.Show();
            this.Hide();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                load();
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
                    var chk = db.Table_arrivals.Where(o => o.Driver_name == sk || o.Car_NO == sk | o.category==sk).ToList();
                    if (chk != null)
                    {

                        dataGridView1.DataSource = chk;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textdriver.Text != null & text_carno.Text != null & textPtime.Text != null & checkedListBox1.Text!=null & comboBox1.Text != null)
                {
                    string sno = text_carno.Text;
                    var chk = db.Table_arrivals.Where(o => o.Car_NO == sno).FirstOrDefault();
                    if (chk == null)
                    {

                        Table_arrival s = new Table_arrival();
                        s.Driver_name = textdriver.Text;
                        s.Car_NO = text_carno.Text;
                        s.category = checkedListBox1.Text;
                        s.duration_time = textPtime.Text;
                        s.selected_slots = comboBox1.Text;
                        s.arrival_time = DateTime.Now;
                        db.SubmitChanges();
                        db.Table_arrivals.InsertOnSubmit(s);
                        db.SubmitChanges();
                        MessageBox.Show("Parked successfully!...");
                       
                        load();
                    }
                    else
                    {
                        MessageBox.Show("this specific car already parked!..");
                    }
                }
                else
                {
                    MessageBox.Show("box empty...please fill the details!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (label_id.Text!=null & textdriver.Text != null & text_carno.Text != null & textPtime.Text != null & checkedListBox1.Text != null & comboBox1.Text != null)
                {


                    if (MessageBox.Show("would you like to edit?...", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {
                        string sno = text_carno.Text;
                        var chk = db.Table_arrivals.Where(o => o.Car_NO == sno).FirstOrDefault();
                        if (chk == null)
                        {
                            int st = Convert.ToInt32(label_id.Text);
                            var s = db.Table_arrivals.Where(o => o.ID == st).FirstOrDefault();

                            s.Driver_name = textdriver.Text;
                            s.Car_NO = text_carno.Text;
                            s.category = checkedListBox1.Text;
                            s.duration_time = textPtime.Text;
                            s.selected_slots = comboBox1.Text;
                            s.arrival_time = DateTime.Now;

                            db.SubmitChanges();
                            MessageBox.Show("Data updated!");
                           
                            load();
                        }

                        else
                        {
                            MessageBox.Show("slot already occupied!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ERROR, record not selected, data not processed!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ir = e.RowIndex;
            label1.Text = dataGridView1.Rows[ir].Cells[0].Value.ToString();
            textdriver.Text = dataGridView1.Rows[ir].Cells[1].Value.ToString();
            text_carno.Text = dataGridView1.Rows[ir].Cells[2].Value.ToString();
            
            textPtime.Text = dataGridView1.Rows[ir].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[ir].Cells[4].Value.ToString();
            checkedListBox1.Text = dataGridView1.Rows[ir].Cells[5].Value.ToString();
            labelARRIVAL.Text = dataGridView1.Rows[ir].Cells[6].Value.ToString();
            labelCARno.Text = dataGridView1.Rows[ir].Cells[2].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (label_id.Text != null)
                {


                    if (MessageBox.Show("would you like to delete?...", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {

                        int st = Convert.ToInt32(label_id.Text);
                        var s = db.Table_arrivals.Where(o => o.ID == st).FirstOrDefault();
                        db.Table_arrivals.DeleteOnSubmit(s);
                        db.SubmitChanges();
                        MessageBox.Show("Data Deleted!");
                        
                        load();

                    }
                }
                else
                {
                    MessageBox.Show("record not selected, please select it then delete.!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DGVPrinter p = new DGVPrinter();
            p.printDocument = printDocument1;
            p.Title = "Arrival report";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
