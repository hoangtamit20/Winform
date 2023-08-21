namespace GameQuaCau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] cayCau = new int[10];

        private void button17_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < cayCau.Length; i++)
            {
                Random random = new Random();
                cayCau[i] = random.Next(0,2);
            }

            btn0.Enabled = true;
            btnDuoi0.Enabled = true;
            lbSoQuan.Text = "5";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTren(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            int soTT = int.Parse(button.Name.Substring(button.Name.Length - 1));
            if (button.Name.StartsWith("btn") && cayCau[soTT] != 0
                || button.Name.StartsWith("btnDuoi") && cayCau[soTT] != 1)
            {
                int soQuan = int.Parse(lbSoQuan.Text) - 1;
                lbSoQuan.Text = soQuan.ToString();
                if (soQuan == 0)
                {
                    MessageBox.Show("You lose!");
                }
                clearCacheError();
                return;
            }

            if (soTT == 7)
            {
                MessageBox.Show("You Win!");
                return;
            }

            Button btnTren = (Button)this.Controls["btn" + (soTT + 1)];
            btnTren.Enabled = true;
            Button btnDuoi = (Button)this.Controls["btnDuoi" + (soTT + 1)];
            btnDuoi.Enabled = true;

            button.BackColor = Color.Blue;
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void clearCacheError()
        {
            for (int i = 0; i < 8; i++)
            {
                Button btnTren = (Button)this.Controls["btn" + i];
                btnTren.BackColor = default(Color);
                if (i != 0)
                    btnTren.Enabled = false;
                Button btnDuoi = (Button)this.Controls["btnDuoi" + i];
                btnDuoi.BackColor = default(Color);
                if (i != 0)
                    btnDuoi.Enabled = false;

            }
        }
    }
} 