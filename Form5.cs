OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Saad Aleem\Documents\CIE project.accdb");
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 k = new Form2();
            k.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           string sql = " DELETE FROM cie WHERE [Customer ID] =" +  textBox1.Text;
           con.Open();
           OleDbCommand cmd = new OleDbCommand(sql, con);
           cmd.ExecuteNonQuery();
           MessageBox.Show("Record Successfully deleted");
           con.Close();
        
