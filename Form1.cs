using System.Globalization;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            timeCatcher.Start();
        }

        private void timeCatcher_Tick(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            txtClock.Text = DateTime.Now.ToString("HH:mm:ss");
            txtDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            txtDay.Text = DateTime.Now.ToString("dddd");
        }
    }
}