namespace pingpong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Form2 f2=new Form2();
            f2.Show();
            Visible = true;
        }

       
    }
}