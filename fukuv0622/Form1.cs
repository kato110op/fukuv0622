using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace fukuv0622
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        public Form1()
        {
            Random rnd = new Random();
            int[] data = new int[10];
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] data = new int[10];
            int sum = 0;
            int i = 0;
            for(i=0;i<10;i++)
            {
                data[i]= rnd.Next(101);
                label1.Text += $"{data[i]},";
                sum += data[i];
            }

            MessageBox.Show($"{sum / 10},");
        }
    }
}