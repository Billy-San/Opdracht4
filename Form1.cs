using System.Windows.Forms;

namespace Opdracht4
{
    public partial class Form1 : Form
    {
        private List<System.Timers.Timer> listTimers = new List<System.Timers.Timer>();
        private rij<TeDoen> rij = new rij<TeDoen>();
        private List<TeDoen> listObjects = new List<TeDoen>();
        private List<DateTime> listDates = new List<DateTime>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rij.Next();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rij.ZetAchteraan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rij.Delete();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                dateTimePicker1.Visible = true;
            }
            else
            {
                dateTimePicker1.Visible = false;
            }
        }
    }
}