namespace SportsClubRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = TextBox_name.Text;
            string membershipType = comboBox_membershipType.Text;

            MessageBox.Show("A new Member is now registerd. " + "Welcome!! " + name + " as a new " + membershipType);
        }

        private void button_cancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
