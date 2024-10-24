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
    public partial class Departure : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Departure()
        {
            InitializeComponent();
        }

        private void Departure_Load(object sender, EventArgs e)
        {
             try
            {
                var dblod = db.Table_departures.ToList();
                dataGridView1.DataSource = dblod;
                comboBox_carno.DataSource = db.Table_arrivals.ToList();
                comboBox_carno.ValueMember = "Car_No";
                comboBox_carno.DisplayMember = "Car_No";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Welcome_page W = new Welcome_page();
            W.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_carno.Text != null & label_driv_name.Text != null & label_p_time.Text != null & label_p_type.Text != null )
                {

                    Table_departure s = new Table_departure();
                    s.Car_No = comboBox_carno.Text;
                    s.Driver_name = label_driv_name.Text;
                    s.Make_model = label_p_type.Text;
                    s.duration_time = label_p_time.Text;

                    decimal str = Convert.ToDecimal(label_p_time.Text);
                    decimal amt = Convert.ToDecimal(pay_amount.Text);
                    decimal amttotal = str * amt;
                    s.Amount = amttotal;
                    s.departure_time = DateTime.Now;
                    db.SubmitChanges();
                    db.Table_departures.InsertOnSubmit(s);
                    db.SubmitChanges();
                    MessageBox.Show("Departed successfully!...");

                    load();
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

        private void load()
        {
            var dblod = db.Table_departures.ToList();
            dataGridView1.DataSource = dblod;
            comboBox_carno.DataSource = db.Table_arrivals.ToList();
            comboBox_carno.ValueMember = "Car_No";
            comboBox_carno.DisplayMember = "Car_No";
        }

        private void comboBox_carno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                Cursor.Current = Cursors.WaitCursor;
                Table_arrival obj = comboBox_carno.SelectedItem as Table_arrival;
                if (obj != null)
                {
                    label_driv_name.Text = obj.Driver_name.ToString();
                    label_p_type.Text = obj.category.ToString();
                    label_p_time.Text = obj.duration_time.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indexrow = e.RowIndex;
            label_id_1.Text = dataGridView1.Rows[indexrow].Cells[0].Value.ToString();
            labeldeparturetime.Text = dataGridView1.Rows[indexrow].Cells[6].Value.ToString();
            labelpaidfee.Text = dataGridView1.Rows[indexrow].Cells[5].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_carno.Text != null & label_driv_name.Text != null & label_p_time.Text != null & label_p_type.Text != null)
                {


                    if (MessageBox.Show("would you like to edit?...", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {

                        int st = Convert.ToInt32(label_id_1.Text);
                        var s = db.Table_departures.Where(o => o.ID == st).FirstOrDefault();

                        s.Car_No = comboBox_carno.Text;
                        s.Driver_name = label_driv_name.Text;
                        s.Make_model = label_p_type.Text;
                        s.duration_time = label_p_time.Text;

                        decimal str = Convert.ToDecimal(label_p_time.Text);
                        decimal amt = Convert.ToDecimal(pay_amount.Text);
                        decimal amttotal = str * amt;
                        s.Amount = amttotal;
                        s.departure_time = DateTime.Now;

                        db.SubmitChanges();
                        MessageBox.Show("Data updated!");

                        load();
                    }
                      
                        
                    }
               
                else
                {
                    MessageBox.Show("ERROR, record not selected, data not processed!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Amount not entered!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (label_id_1.Text != null)
                {


                    if (MessageBox.Show("would you like to delete?...", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {

                        int st = Convert.ToInt32(label_id_1.Text);
                        var s = db.Table_departures.Where(o => o.ID == st).FirstOrDefault();
                        db.Table_departures.DeleteOnSubmit(s);
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
            p.Title = "Departure report";
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
                    var chk = db.Table_departures.Where(o => o.Driver_name == sk || o.Car_No == sk | o.Make_model == sk).ToList();
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
    }
    }

