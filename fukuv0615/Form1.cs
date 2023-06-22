namespace fukuv0615
{

    public partial class Form1 : Form
    {
        int ans = rand.Next(0, 101);
        int count = 0;
        static Random rand = new Random();
        int guess;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            MessageBox.Show($"{count}‰ñ–Ú‚Ì’§í");
            
            int guess = int.Parse(textBox1.Text);
            if (ans == guess)
            {
                MessageBox.Show("Bingo!!");
                count = 0;

                ans = rand.Next(0, 101);
            }
            else if (ans <guess)
            {
                MessageBox.Show("Less");
            }
            else 
            {
                MessageBox.Show("Greater");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}