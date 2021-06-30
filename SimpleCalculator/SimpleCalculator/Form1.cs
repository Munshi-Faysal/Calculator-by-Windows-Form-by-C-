using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num, ans;
        int count;

        //for ON button
        private void button1_Click(object sender, EventArgs e)
        {
            enable();
        }

        //for OFF button
        private void button2_Click_1(object sender, EventArgs e)
        {           
            disable();
            textBox1.Clear();
        }

        //backspace
        private void button3_Click(object sender, EventArgs e)
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        //CLEAR 
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }


        private void button19_Click(object sender, EventArgs e)
        {
            //Display . in Textbox
            textBox1.Text = textBox1.Text + ".";
            textBox1.ForeColor = Color.Red;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            //Display 0 in Textbox
            textBox1.Text = textBox1.Text + 0;
            textBox1.ForeColor = Color.Red;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            //Display 1 in Textbox
            textBox1.Text = textBox1.Text + 1;
            textBox1.ForeColor = Color.Red;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Display 2 in Textbox
            textBox1.Text = textBox1.Text + 2;
            textBox1.ForeColor = Color.Red;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            //Display 3 in Textbox
            textBox1.Text = textBox1.Text + 3;
            textBox1.ForeColor = Color.Red;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Display 4 in Textbox
            textBox1.Text = textBox1.Text + 4;
            textBox1.ForeColor = Color.Red;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Display 5 in Textbox
            textBox1.Text = textBox1.Text + 5;
            textBox1.ForeColor = Color.Red;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Display 6 in Textbox
            textBox1.Text = textBox1.Text + 6;
            textBox1.ForeColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Display 7 in Textbox
            textBox1.Text = textBox1.Text + 7;
            textBox1.ForeColor = Color.Red;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            //Display 8 in Textbox
            textBox1.Text = textBox1.Text + 8;
            textBox1.ForeColor = Color.Red;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            //Display 9 in Textbox
            textBox1.Text = textBox1.Text + 9;
            textBox1.ForeColor = Color.Red;
        }



        private void button17_Click(object sender, EventArgs e)
        {
            //for + sign
            num = float.Parse(textBox1.Text);
            textBox1.Clear();   //clear the Textbox
            textBox1.Focus();    // focus on Textbox after clearing Textbox
            count = 1;   // count store case
            label1.Text = num.ToString() + "+"; //dixplay Text on label
        }
        private void button13_Click(object sender, EventArgs e)
        {
            //for - sign
            num = float.Parse(textBox1.Text);
            textBox1.Clear();   //clear the Textbox
            textBox1.Focus();    // focus on Textbox after clearing Textbox
            count = 2;   // count store case
            label1.Text = num.ToString() + "-"; //dixplay Text on label

        }
        private void button9_Click(object sender, EventArgs e)
        {
            //for * sign
            num = float.Parse(textBox1.Text);
            textBox1.Clear();   //clear the Textbox
            textBox1.Focus();    // focus on Textbox after clearing Textbox
            count = 3;   // count store case
            label1.Text = num.ToString() + "*"; //dixplay Text on label

        }
        private void button5_Click(object sender, EventArgs e)
        {
            //for / sign
            num = float.Parse(textBox1.Text);
            textBox1.Clear();   //clear the Textbox
            textBox1.Focus();    // focus on Textbox after clearing Textbox
            count = 4;   // count store case
            label1.Text = num.ToString() + "/"; //dixplay Text on label

        }

        //For = sign
        private void button20_Click(object sender, EventArgs e)
        {
            compute();
            label1.Text = "";
        }







        //user defined Function
        public void disable()
        {
            button1.Show();
            button2.Hide();
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;


        }
        public void enable()
        {
            button2.Show();
            button1.Hide();
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;


        }

        


        public void compute()
        {
            switch (count) //creating switch statement
            {
                // for addition & converted float into string
                case 1:
                    ans = num + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                // for subtraction & converted float into string
                case 2: 
                    ans = num - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                // for multiplication & converted float into string
                case 3: 
                    ans = num * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                // for divition & converted float into string
                case 4: 
                    ans = num / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                default:
                    break;
            }
        }

       
    }
}
