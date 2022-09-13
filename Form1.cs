string lop = "g";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == lop )
            {
                Form2 secform = new Form2();
                secform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password not valid");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }