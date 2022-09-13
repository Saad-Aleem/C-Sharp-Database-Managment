 Form2 newsec = new Form2();
            newsec.Show();
            this.Hide();

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand(@"INSERT INTO  cie ([Customer ID], [Customer Names], [Salary], [Business Profit], [Share of AOP] ,[Capital Gains],[Other Sources],[Foriegn allowances], [Zakat],[Workers Welfare Fund],[Workers Profit Participation], [Charitable Donation admissible], [Total income after deductions],[Total Tax payable]) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "');", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Successfully Saved");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox13.Text = ((Convert.ToInt32(textBox3.Text)) + (Convert.ToInt32(textBox4.Text)) + (Convert.ToInt32(textBox5.Text)) + (Convert.ToInt32(textBox6.Text)) + (Convert.ToInt32(textBox7.Text)) + (Convert.ToInt32(textBox8.Text)) - (Convert.ToInt32(textBox9.Text)) - (Convert.ToInt32(textBox10.Text)) - (Convert.ToInt32(textBox11.Text)) - (Convert.ToInt32(textBox12.Text))).ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
             if (((int.Parse(textBox13.Text)) <= 400000))
              {
                MessageBox.Show("No Taxation");
              }
             if (((int.Parse(textBox13.Text)) > 400000) && ((int.Parse(textBox13.Text)) <= 500000))
              {
                textBox14.Text = ((Convert.ToInt32(textBox13.Text)) * 0.05).ToString();
              }
             if (((int.Parse(textBox13.Text)) > 500000) && ((int.Parse(textBox13.Text)) <= 800000))
              {
                textBox14.Text = ((((Convert.ToInt32(textBox13.Text)) - 500000) * 0.75) + 5000).ToString();
              }
             if (((int.Parse(textBox13.Text)) > 800000) && ((int.Parse(textBox13.Text)) <= 1300000))
             {
                textBox14.Text = ((((Convert.ToInt32(textBox13.Text)) - 800000) * 0.1) + 27500).ToString();
              }
             if (((int.Parse(textBox13.Text)) > 1300000) && ((int.Parse(textBox13.Text)) <= 1800000))
             {
                 textBox14.Text = ((((Convert.ToInt32(textBox13.Text)) - 1300000) * 0.125) + 77500).ToString();
             }
             if (((int.Parse(textBox13.Text)) > 1800000) && ((int.Parse(textBox13.Text)) <= 2200000))
             {
                 textBox14.Text = ((((Convert.ToInt32(textBox13.Text)) * 0.15) - 1800000) + 140000).ToString();
             }
             if (((int.Parse(textBox13.Text)) > 2200000) && ((int.Parse(textBox13.Text)) <= 2600000))
             {
                 textBox14.Text = ((((Convert.ToInt32(textBox13.Text)) - 2200000) * 0.175) + 200000).ToString();
             }
             if (((int.Parse(textBox13.Text)) > 2600000) && ((int.Parse(textBox13.Text)) <= 3000000))
             {
                 textBox14.Text = ((((Convert.ToInt32(textBox13.Text)) * 0.2) - 2600000) + 270000).ToString();
             }
             if (((int.Parse(textBox13.Text)) > 3000000) && ((int.Parse(textBox13.Text)) <= 3500000))
             {
                 textBox14.Text = ((((Convert.ToInt32(textBox13.Text)) - 3000000) * 0.225) + 350000).ToString();
             }
             if (((int.Parse(textBox13.Text)) > 3500000) && ((int.Parse(textBox13.Text)) <= 4000000))
             {
                 textBox14.Text = ((((Convert.ToInt32(textBox13.Text)) - 3500000) * 0.25) + 462500).ToString();
             }
             if (((int.Parse(textBox13.Text)) > 4000000) && ((int.Parse(textBox13.Text)) <= 7000000))
             {
                 textBox14.Text = ((((Convert.ToInt32(textBox13.Text)) - 4000000) * 0.275) + 587500).ToString();
             }
             if (((int.Parse(textBox13.Text)) > 7000000))
             {
                 textBox14.Text = ((((Convert.ToInt32(textBox13.Text)) - 7000000) * 0.3) + 1412500).ToString();
             }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            
        }