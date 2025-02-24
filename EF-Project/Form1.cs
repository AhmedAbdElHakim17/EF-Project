namespace EF_Project
{
    public partial class Form1 : Form
    {
        Login Login;
        public Form1()
        {
            InitializeComponent();
            Login = new Login();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
