namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text)).ToString();
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sub_Click(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox3.Text)).ToString();
        }

        private void mul_Click(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text)).ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToInt32(textBox2.Text) / Convert.ToInt32(textBox3.Text)).ToString();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
