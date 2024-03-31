namespace form3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val1 = Convert.ToInt32(textBox1.Text);
            int val2 = Convert.ToInt32(textBox2.Text);
            int sum = val1+val2;
            textBox3.Text = sum.ToString();
        }
    }
}
