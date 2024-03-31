namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadImg = new OpenFileDialog();
            if (loadImg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(loadImg.FileName);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadImg = new OpenFileDialog();
            if (loadImg.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(loadImg.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
