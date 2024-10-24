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
    public partial class INVOICE : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public Bitmap Bitmap { get; private set; }
        public Bitmap Bitmap1 { get => bitmap; set => bitmap = value; }
        public Bitmap Bitmap2 { get => bitmap; set => bitmap = value; }
        public Bitmap Bitmap3 { get => bitmap; set => bitmap = value; }

        public INVOICE()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void INVOICE_Load(object sender, EventArgs e)
        {
            comboBox_carno.DataSource = db.Table_departures.ToList();
            comboBox_carno.ValueMember = "Car_No";
            comboBox_carno.DisplayMember = "Car_No";
        }

        private void comboBox_carno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Table_departure obj = comboBox_carno.SelectedItem as Table_departure;
                if (obj != null)
                {
                    labelname.Text = obj.Driver_name.ToString();
                    label_type.Text = obj.Make_model.ToString();
                    label_carno.Text = obj.Car_No.ToString();
                    labelduration_time.Text = obj.duration_time.ToString();
                    labelamount.Text = obj.Amount.ToString();
                    label_depart_time.Text = obj.departure_time.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void labelentrytime_Click(object sender, EventArgs e)
        {

        }
        Bitmap bitmap;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                Graphics myg = this.CreateGraphics();
                //size s= this.size;
                Bitmap = new Bitmap(this.Size.Width, this.Size.Height, myg);
                Graphics mg = Graphics.FromImage(Bitmap);
                mg.CopyFromScreen(this.Location.X, Location.Y, 0, 0, this.Size);
                printPreviewDialog1.Show();
    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
