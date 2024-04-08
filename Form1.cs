namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer colorTimer = new System.Windows.Forms.Timer();
        public Form1()
        {

            InitializeComponent();
            
            colorTimer.Interval = 15;
            colorTimer.Tick += backGroundChange;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                errorProvider1.SetError(textBox1, "Error");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox5.Text.Length == 0)
            {
                errorProvider1.SetError(button1, "Error");
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    label3.Text = $"Nom: {textBox1.Text} ||  Mitjana de notes: {(Convert.ToDecimal(textBox2.Text) + Convert.ToDecimal(textBox3.Text) + Convert.ToDecimal(textBox4.Text) + Convert.ToDecimal(textBox5.Text)) / 4}";
                    HigherNote();
                    LowerNote();

                }
                catch (Exception)
                {
                    MessageBox.Show("Els caracters de les notes han de ser numerics");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                errorProvider1.SetError(textBox2, "Error");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 0)
            {
                errorProvider1.SetError(textBox3, "Error");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 0)
            {
                errorProvider1.SetError(textBox4, "Error");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length == 0)
            {
                errorProvider1.SetError(textBox5, "Error");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        public void HigherNote()
        {
            decimal[] notes = { Convert.ToDecimal(textBox2.Text), Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text) };
            decimal max = notes.Max();
            label4.Text = $"La nota més alta és: {max}";


        }
        public void LowerNote()
        {
            decimal[] notes = { Convert.ToDecimal(textBox2.Text), Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text) };
            decimal min = notes.Min();
            label5.Text = $"La nota més baixa és: {min}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            
            if (checkBox1.Checked)
            {
                // Start the color changing timer
                colorTimer.Start();

            }
            else
            {
                // Stop the color changing timer
                colorTimer.Stop();

            }          
        }
        private void backGroundChange(object sender, EventArgs e)
        {
            Random random = new Random(); 
            int red = random.Next(0, 255);
            red = Math.Abs(red);
            int green = random.Next(0, 255);
            green = Math.Abs(green);
            int blue = random.Next(0, 255);
            blue = Math.Abs(blue);
            Form1.ActiveForm.BackColor = Color.FromArgb( red, green, blue);
        }
    }
}
