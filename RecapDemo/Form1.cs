using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            int[,] array = new int[8, 8];




             //donguIle();
            donguIler();
            Button button = new Button();
            button.Height = 25;
            button.Width = 25;
            button.Location = new System.Drawing.Point(50 - 25, 50);

            button.BackColor = Color.Black;
            this.Controls.Add(button);
        }

        private void donguIle()
        {
            bool value = true;
            int number = 1;
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    Button button1 = new Button();
                    button1.Height = 25;
                    button1.Width = 25;
                    button1.Location = new System.Drawing.Point(i * 25, j * 25);

                    this.Controls.Add(button1);
                    if ( (i+j)%2==0)
                    {
                        button1.BackColor = Color.Black;
                       
                    }
                    else
                    {
                        button1.BackColor = Color.White;
                       
                    }
                }
            }
        }

        private void donguIler()
        {
            bool value = true;
            int number = 1;
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    Button button1 = new Button();
                    button1.Height = 25;
                    button1.Width = 25;
                    button1.Location = new System.Drawing.Point(j * 25, i * 25);

                    this.Controls.Add(button1);
                    if (value)
                    {
                        button1.BackColor = Color.Black;
                        value = false;
                    }
                    else
                    {
                        button1.BackColor = Color.White;
                        value = true;
                    }
                }
                if (value)
                {
                    value = false;

                }
                else
                {
                    value = true;
                }
            }
        }

    }
}
