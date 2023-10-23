namespace tictactoe
{//comment
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
     
        private void button2_Click(object sender, EventArgs e)
        {

        }

     //Goes to pvp when clicked
        private void pvp_Click(object sender, EventArgs e)
        {
            PvP pvp = new PvP();
            pvp.Show();

        }
        //Goes to pvai when clicked
        private void btn_pvai_Click(object sender, EventArgs e)
        {
            PvAi pvAi = new PvAi(); 
            pvAi.Show();

        }
    }
}