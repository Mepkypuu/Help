using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_10
{
    public partial class Form1 : Form
    {
        int temp;
        int index; // yellow - 1, blue - 2, green - 3, red - 4.
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            this.Text = "Сапер";
            progressBar1.Size = new Size(200, 50);
            progressBar1.Maximum = 200;
            progressBar1.Step = 10;
            timer1.Interval = 500;
            timer1.Enabled = false;
            timer1.Tick += timer1_Tick;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item is Button)
                {
                    if (((Button)item).Text == ".")
                        ((Button)item).Click += CommonBtn_Click;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            temp = Convert.ToInt32(label2.Text);
            temp--;
            if (temp == 0)
            {
                timer1.Stop();
                MessageBox.Show("Время вышло!");
                this.Close();
            }
            if(temp >= 10)
                label2.Text = (temp.ToString());
            else
            label2.Text = ("0" + temp.ToString());          
           /* if(progressBar1.Value == progressBar1.Maximum)
            {
                MessageBox.Show("Бомба взорвалась");
                timer1.Stop();
                progressBar1.Value = progressBar1.Minimum;
                return;
            }*/
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {

            label2.Text = "20";
            groupBox1.Visible = true;
            progressBar1.Value = progressBar1.Minimum;
            if(numericUpDown1.Value == 1)
            {
                button3.Visible = true;
                button2.Visible = false;
                button1.Visible = false;
                button4.Visible = false;
                index = rand.Next(1, 1);
            }
            if(numericUpDown1.Value == 2)
            {
                button1.Visible = false;
                button4.Visible = false;
                button3.Visible = true;
                button2.Visible = true;
                index = rand.Next(1, 2);
            }
            if(numericUpDown1.Value == 3 )
            {
                button4.Visible = false;
                button3.Visible = true;
                button2.Visible = true;
                button1.Visible = true;
                index = rand.Next(1, 3);
            }
            if(numericUpDown1.Value == 4)
            {
                button3.Visible = true;
                button2.Visible = true;
                button1.Visible = true;
                button4.Visible = true;
                index = rand.Next(1, 4);
            }
            
            timer1.Enabled = true;           
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
  
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
    
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
     
           
        }

        private void Button4_Click(object sender, EventArgs e)
        {
        
           
        }

        private void CommonBtn_Click(object sender, EventArgs e)
        {
            
            if(((Button)sender).BackColor == Color.Yellow )
            {
                timer1.Stop();
                MessageBox.Show("Бомба разминирована! Победа");
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Бомба взорвалась! Поражение");
                groupBox1.Visible = false;
            }

        }

       
    }
}
