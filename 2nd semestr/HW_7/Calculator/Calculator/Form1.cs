using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Procedure of adding symbol in textbox
        /// </summary>
        /// <param name="value">Value to add</param>
        public void AddSymbol(int value)
        {
            if (AlreadyPrinted)
            {
                textBox1.ResetText();
                AlreadyPrinted = false;
            }
            textBox1.Text = textBox1.Text + value;
            label2.Text = "";
        }

        /// <summary>
        /// Symbol of the operation
        /// </summary>
        private char OperationSymbol = 'x';

        /// <summary>
        /// If symbol is printed
        /// </summary>
        private bool AlreadyPrinted = false;

        /// <summary>
        /// Previous value
        /// </summary>
        private int Previous = 0;

        //Buttons with numbers clicked methods
        private void OnButton1Click(object sender, EventArgs e)
        {
            this.AddSymbol(1);
        }

        private void OnButton2Click(object sender, EventArgs e)
        {
            this.AddSymbol(2);
        }

        private void OnButton3Click(object sender, EventArgs e)
        {
            this.AddSymbol(3);
        }

        private void OnButton4Click(object sender, EventArgs e)
        {
            this.AddSymbol(4);
        }

        private void OnButton5Click(object sender, EventArgs e)
        {
            this.AddSymbol(5);
        }

        private void OnButton6Click(object sender, EventArgs e)
        {
            this.AddSymbol(6);
        }

        private void OnButton7Click(object sender, EventArgs e)
        {
            this.AddSymbol(7);
        }

        private void OnButton8Click(object sender, EventArgs e)
        {
            this.AddSymbol(8);
        }

        private void OnButton9Click(object sender, EventArgs e)
        {
            this.AddSymbol(9);
        }

        private void OnButton0Click(object sender, EventArgs e)
        {
            this.AddSymbol(0);
        }
        /// <summary>
        /// Save previous value
        /// </summary>
        public void SavePrev()
        {
            if (textBox1.Text == "")
                return;
            Previous = int.Parse(textBox1.Text);
            AlreadyPrinted = true;
            label2.Text = "";
        }
        
        //Buttons with symbols clicked methods
        private void OnButtonMinusClick(object sender, EventArgs e)
        {
            SavePrev();
            OperationSymbol = '-';
        }

        private void OnButtonPlusClick(object sender, EventArgs e)
        {
            SavePrev();
            OperationSymbol = '+';
        }

        private void OnButtonMultiplyClick(object sender, EventArgs e)
        {
            SavePrev();
            OperationSymbol = '*';
        }

        private void OnButtonDivideClick(object sender, EventArgs e)
        {
            SavePrev();
            OperationSymbol = '/';
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            int result = 0;
            if ((OperationSymbol == 'x') || (textBox1.Text == ""))
                return;
            if (OperationSymbol == '+')
            {
                result = Previous + int.Parse(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = textBox1.Text + result;
            }
            if (OperationSymbol == '-')
            {
                result = Previous - int.Parse(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = textBox1.Text + result;
            }
            if (OperationSymbol == '*')
            {
                result = Previous * int.Parse(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = textBox1.Text + result;
            }
            if (OperationSymbol == '/')
            {
                if (int.Parse(textBox1.Text) == 0)
                {
                    label2.Text = "ERROR";
                    textBox1.ResetText();
                    Previous = 0;
                    OperationSymbol = 'x';
                    AlreadyPrinted = false;
                    return;
                }
                result = Previous / int.Parse(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = textBox1.Text + result;
            }
            Previous = int.Parse(textBox1.Text);
            OperationSymbol = 'x';
            AlreadyPrinted = false;
        }
        /// <summary>
        /// Button C click method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonCClick(object sender, EventArgs e)
        {
            textBox1.ResetText();
            Previous = 0;
        }
    }
}
