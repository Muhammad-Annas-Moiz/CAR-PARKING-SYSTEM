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
    public partial class SLOTS_FORM : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public SLOTS_FORM()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Welcome_page S = new Welcome_page();
            S.Show();
            this.Hide();
        }
        public void reset()
        {
            text_slot_no.Text = "";
            text_location.Text = "";
            label_id.Text = "";
        }
        public void load()
        {
            var lod = db.Table_slots.ToList();
            dataGridView1.DataSource = lod;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(text_slot_no.Text!=null & text_location.Text!= null)
                {
                    string sno = text_slot_no.Text;
                    var chk = db.Table_slots.Where(o => o.SLOT__ == sno).FirstOrDefault();
                    if (chk == null)
                    {

                        Table_slot s = new Table_slot();
                        s.SLOT__ = text_slot_no.Text;
                        s.Location = text_location.Text;
                        db.Table_slots.InsertOnSubmit(s);
                        db.SubmitChanges();
                        MessageBox.Show("data inserted");
                        reset();
                        load();
                    }
                    else
                    {
                        MessageBox.Show("this slot already reserved!, please try another slot, thank you");
                    }
                }
                else
                {
                    MessageBox.Show("location/slot box empty...please try again!");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SLOTS_FORM_Load(object sender, EventArgs e)
        {
            load();
        }

        private void label_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ir = e.RowIndex;
            label_id.Text = dataGridView1.Rows[ir].Cells[0].Value.ToString();
            text_slot_no.Text = dataGridView1.Rows[ir].Cells[1].Value.ToString();
            text_location.Text = dataGridView1.Rows[ir].Cells[2].Value.ToString();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (label_id.Text != null & text_slot_no.Text != null & text_location.Text != null)
                {  
                

                        if (MessageBox.Show("would you like to edit?...", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                        {
                            string sno = text_slot_no.Text;
                            var chk = db.Table_slots.Where(o => o.SLOT__ == sno).FirstOrDefault();
                        if (chk == null)
                        {
                            int st = Convert.ToInt32(label_id.Text);
                            var s = db.Table_slots.Where(o => o.ID == st).FirstOrDefault();

                            s.SLOT__ = text_slot_no.Text;
                            s.Location = text_location.Text;

                            db.SubmitChanges();
                            MessageBox.Show("Data updated!");
                            reset();
                            load();
                        }

                        else
                        {
                            MessageBox.Show("slot already added with this name!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("location/slot box empty...please try again!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
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
                            var s = db.Table_slots.Where(o => o.ID == st).FirstOrDefault();
                        db.Table_slots.DeleteOnSubmit(s);
                            db.SubmitChanges();
                            MessageBox.Show("Data Deleted!");
                            reset();
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
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
               if(textBox1.Text!=null)
                {
                    string sk = textBox1.Text;
                    var chk = db.Table_slots.Where(o => o.SLOT__ == sk || o.Location == sk).ToList();
                    if(chk!=null)
                    {
                    
                        dataGridView1.DataSource = chk;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DGVPrinter p = new DGVPrinter();
            p.printDocument = printDocument1;
            p.Title = "total cars capacity report";
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
    

