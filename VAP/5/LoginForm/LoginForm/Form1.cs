namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string userName=username.Text;
            string passWord= password.Text;

            if (userName == "admin" && passWord == "1234") {
                MessageBox.Show("Login was succsessful!");
            }
            else {
                MessageBox.Show("Username orPassword is Wrong!");
            }
        }
    }
}
