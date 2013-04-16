using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crosseszeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void change(Button button)
        {
            if (button.Text != " ")
                return;
            if (odd)
                button.Text = "X";
            else
                button.Text = "O";
            odd = !odd;     
        }

        private bool odd = true;

        private void OnButton00Click(object sender, EventArgs e)
        {
            change(Button00);
            if ((Button10.Text == Button00.Text) && (Button00.Text == Button20.Text))
            {
                Button00.Text = Button00.Text + " WIN";
                Button00.BackColor = Color.Aqua;
            }
            if ((Button01.Text == Button00.Text) && (Button00.Text == Button02.Text))
            {
                Button00.Text = Button00.Text + " WIN";
                Button00.BackColor = Color.Aqua;
            }
            if ((Button11.Text == Button00.Text) && (Button00.Text == Button22.Text))
            {
                Button00.Text = Button00.Text + " WIN";
                Button00.BackColor = Color.Aqua;
            }
        }

        private void OnButton01Click(object sender, EventArgs e)
        {
            change(Button01);
            if ((Button11.Text == Button01.Text) && (Button01.Text == Button21.Text))
            {
                Button01.Text = Button01.Text + " WIN";
                Button01.BackColor = Color.Aqua;
            }
            if ((Button01.Text == Button00.Text) && (Button00.Text == Button02.Text))
            {
                Button01.Text = Button01.Text + " WIN";
                Button01.BackColor = Color.Aqua;
            }
        }

        private void OnButton02Click(object sender, EventArgs e)
        {
            change(Button02);
            if ((Button12.Text == Button02.Text) && (Button02.Text == Button22.Text))
            {
                Button02.Text = Button02.Text + " WIN";
                Button02.BackColor = Color.Aqua;
            }
            if ((Button01.Text == Button02.Text) && (Button00.Text == Button02.Text))
            {
                Button02.Text = Button02.Text + " WIN";
                Button02.BackColor = Color.Aqua;
            }
            if ((Button11.Text == Button02.Text) && (Button02.Text == Button20.Text))
            {
                Button02.Text = Button02.Text + " WIN";
                Button02.BackColor = Color.Aqua;
            }
        }

        private void OnButton10Click(object sender, EventArgs e)
        {
            change(Button10);
            if ((Button10.Text == Button20.Text) && (Button00.Text == Button10.Text))
            {
                Button10.Text = Button10.Text + "  WIN";
                Button10.BackColor = Color.Aqua;
            }
            if ((Button10.Text == Button11.Text) && (Button10.Text == Button12.Text))
            {
                Button10.Text = Button10.Text + "WIN";
                Button10.BackColor = Color.Aqua;
            }
        }

        private void OnButton11Click(object sender, EventArgs e)
        {
            change(Button11);
            if ((Button11.Text == Button01.Text) && (Button11.Text == Button02.Text))
            {
                Button11.Text = Button11.Text + " WIN";
                Button11.BackColor = Color.Aqua;
            }
            if ((Button11.Text == Button10.Text) && (Button11.Text == Button20.Text))
            {
                Button11.Text = Button11.Text + " WIN";
                Button11.BackColor = Color.Aqua;
            }
            if ((Button11.Text == Button00.Text) && (Button11.Text == Button22.Text))
            {
                Button11.Text = Button11.Text + " WIN";
                Button11.BackColor = Color.Aqua;
            }
            if ((Button11.Text == Button02.Text) && (Button11.Text == Button20.Text))
            {
                Button11.Text = Button11.Text + " WIN";
                Button11.BackColor = Color.Aqua;
            }
        }

        private void OnButton12Click(object sender, EventArgs e)
        {
            change(Button12);
            if ((Button12.Text == Button10.Text) && (Button12.Text == Button11.Text))
            {
                Button12.Text = Button12.Text + " WIN";
                Button12.BackColor = Color.Aqua;
            }
            if ((Button12.Text == Button02.Text) && (Button12.Text == Button22.Text))
            {
                Button12.Text = Button12.Text + " WIN";
                Button12.BackColor = Color.Aqua;
            }
        }

        private void OnButton20Click(object sender, EventArgs e)
        {
            change(Button20);
            if ((Button20.Text == Button10.Text) && (Button20.Text == Button00.Text))
            {
                Button20.Text = Button20.Text + " WIN";
                Button20.BackColor = Color.Aqua;
            }
            if ((Button20.Text == Button11.Text) && (Button20.Text == Button02.Text))
            {
                Button20.Text = Button20.Text + " WIN";
                Button20.BackColor = Color.Aqua;
            }
            if ((Button20.Text == Button21.Text) && (Button20.Text == Button22.Text))
            {
                Button20.Text = Button20.Text + " WIN";
                Button20.BackColor = Color.Aqua;
            }
        }

        private void OnButton21Click(object sender, EventArgs e)
        {
            change(Button21);
            if ((Button21.Text == Button20.Text) && (Button21.Text == Button22.Text))
            {
                Button21.Text = Button21.Text + " WIN";
                Button21.BackColor = Color.Aqua;
            }
            if ((Button21.Text == Button11.Text) && (Button21.Text == Button01.Text))
            {
                Button21.Text = Button21.Text + " WIN";
                Button21.BackColor = Color.Aqua;
            }
        }

        private void OnButton22Click(object sender, EventArgs e)
        {
            change(Button22);
            if ((Button22.Text == Button11.Text) && (Button22.Text == Button00.Text))
            {
                Button22.Text = Button22.Text + " WIN";
                Button22.BackColor = Color.Aqua;
            }
            if ((Button22.Text == Button12.Text) && (Button22.Text == Button02.Text))
            {
                Button22.Text = Button22.Text + " WIN";
                Button22.BackColor = Color.Aqua;
            }
            if ((Button22.Text == Button20.Text) && (Button22.Text == Button21.Text))
            {
                Button22.Text = Button22.Text + " WIN";
                Button22.BackColor = Color.Aqua;
            }
        }

    }
}
