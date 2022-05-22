using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Media;

namespace ndal
{
    public partial class ndal : Form
    {
        public ndal()
        {
            InitializeComponent();
        }

        private void ndal1_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            ndalFunction1();
        }
        private async void ndalFunction1()
        {
            while (true)
            {
                await Task.Delay(10000);
                Random random = new Random();

                int ndalimg = random.Next(0,21) ;
                {
                    if (ndalimg == 0)
                    {
                        this.BackgroundImage = Properties.Resources._1;
                        ndalFunction2();
                    }

                    if (ndalimg == 1)
                    {
                        this.BackgroundImage = Properties.Resources._2;
                        ndalFunction2();
                    }

                    if (ndalimg == 2)
                    {
                        this.BackgroundImage = Properties.Resources._3;
                        ndalFunction2();
                    }

                    if (ndalimg == 3)
                    {
                        this.BackgroundImage = Properties.Resources._4;
                        ndalFunction2();
                    }

                    if (ndalimg == 4)
                    {
                        this.BackgroundImage = Properties.Resources._5;
                        ndalFunction2();
                    }

                    if (ndalimg == 5)
                    {
                        this.BackgroundImage = Properties.Resources._6;
                        ndalFunction2();
                    }

                    if (ndalimg == 6)
                    {
                        this.BackgroundImage = Properties.Resources._7;
                        ndalFunction2();
                    }

                    if (ndalimg == 7)
                    {
                        this.BackgroundImage = Properties.Resources._8;
                        ndalFunction2();
                    }

                    if (ndalimg == 8)
                    {
                        this.BackgroundImage = Properties.Resources._9;
                        ndalFunction2();
                    }

                    if (ndalimg == 9)
                    {
                        this.BackgroundImage = Properties.Resources._10;
                        ndalFunction2();
                    }

                    if (ndalimg == 10)
                    {
                        this.BackgroundImage = Properties.Resources._11;
                        ndalFunction2();
                    }

                    if (ndalimg == 11)
                    {
                        this.BackgroundImage = Properties.Resources._12;
                        ndalFunction2();
                    }

                    if (ndalimg == 12)
                    {
                        this.BackgroundImage = Properties.Resources._13;
                        ndalFunction2();
                    }

                    if (ndalimg == 13)
                    {
                        this.BackgroundImage = Properties.Resources._14;
                        ndalFunction2();
                    }

                    if (ndalimg == 14)
                    {
                        this.BackgroundImage = Properties.Resources._15;
                        ndalFunction2();
                    }

                    if (ndalimg == 15)
                    {
                        this.BackgroundImage = Properties.Resources._16;
                        ndalFunction2();
                    }

                    if (ndalimg == 16)
                    {
                        this.BackgroundImage = Properties.Resources._17;
                        ndalFunction2();
                    }

                    if (ndalimg == 17)
                    {
                        this.BackgroundImage = Properties.Resources._18;
                        ndalFunction2();
                    }

                    if (ndalimg == 18)
                    {
                        this.BackgroundImage = Properties.Resources._19;
                        ndalFunction2();
                    }

                    if (ndalimg == 19)
                    {
                        this.BackgroundImage = Properties.Resources._20;
                        ndalFunction2();
                    }
                    if (ndalimg == 20)
                    {
                        this.BackgroundImage = Properties.Resources._21;
                        ndalFunction2();
                    }
                    if (ndalimg == 21)
                    {
                        this.BackgroundImage = Properties.Resources._22;
                        ndalFunction2();
                    }
                }
            }
        }

        private async void ndalFunction2()
        {
            Cursor.Hide();

            this.Visible = true;

            await Task.Delay(2000);

            this.Visible = false;

            return;
        }
    }
}
