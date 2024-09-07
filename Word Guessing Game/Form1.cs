namespace Word_Guessing_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtIntro_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {//label 
            txtIntro.Text = "Word Guessing Game!";
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {//calling method login
            Login();
        }
        private void Login()
        {
            //A method to use to any other method
             this.Hide();
            Form2 Other = new Form2();
          Other.Show();
        }
        private void btnPlay_KeyPress(object sender, KeyPressEventArgs e)
        { //This will go to other form using ENTER button in pc
            if (e.KeyChar ==(char)Keys.Enter)
            {
                Login();
            }
        }
    }
}
