using Quan_ly_khach_san.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_khach_san
{
    public partial class Form2 : Form
    {
        bool[] phong = new bool[5];
        public Form2()
        {
            for(int i = 0; i < 5; i++)
            {
                phong[i] = false;
            }
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int num;
            if (!int.TryParse(huyphong.Text, out num))
            {
                MessageBox.Show("Khong hop le");
            }
            else
            {
                if (num < 0 || num > 4)
                {
                    MessageBox.Show("Phong khong ton tai");
                }
                else if (phong[num] == false) MessageBox.Show("Phong da duoc huy");
                else
                {
                    if (num == 1 && phong[num] == true)
                    {
                        button1.BackColor = DefaultBackColor;
                        phong[num] = false;
                        MessageBox.Show("Phong 1 da duoc huy");
                    }
                    else if (num == 2 && phong[num] == true)
                    {
                        button2.BackColor = DefaultBackColor;
                        phong[num] = false;
                        MessageBox.Show("Phong 2 da duoc huy");
                    }
                    else if (num == 3 && phong[num] == true)
                    {
                        button3.BackColor = DefaultBackColor;
                        phong[num] = false;
                        MessageBox.Show("Phong 3 da duoc huy");
                    }
                    else if (num == 4 && phong[num] == true)
                    {
                        button4.BackColor = DefaultBackColor;
                        phong[num] = false;
                        MessageBox.Show("Phong 4 da duoc huy");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox a = new PictureBox();
             Form formtemp = new Form();
             formtemp.BackgroundImage = Properties.Resources.anh1;
             formtemp.Size = new Size (736,552);
            formtemp.StartPosition = FormStartPosition.CenterScreen;
            formtemp.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num;
            if (!int.TryParse(datphong.Text, out num))
            {
                MessageBox.Show("Khong hop le");
            }
            if (num < 0 || num > 4)
            {
                MessageBox.Show("Phong khong ton tai");
            }
            else if (phong[num] == true) MessageBox.Show("Phong da duoc dat");
            else
            {
                if (num == 1 && phong[num] == false)
                {
                    button1.BackColor = Color.Orange;
                    phong[num] = true;
                    MessageBox.Show("Phong 1 da duoc dat");
                }
                else if (num == 2 && phong[num] == false)
                {
                    button2.BackColor = Color.Orange;
                    phong[num] = true;
                    MessageBox.Show("Phong 2 da duoc dat");
                }
                else if (num == 3 && phong[num] == false)
                {
                    button3.BackColor = Color.Orange;
                    phong[num] = true;
                    MessageBox.Show("Phong 3 da duoc dat");
                }
                else if (num == 4 && phong[num] == false)
                {
                    button4.BackColor = Color.Orange;
                    phong[num] = true;
                    MessageBox.Show("Phong 4 da duoc dat");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formtemp = new Form();
            formtemp.BackgroundImage = Properties.Resources.anh2;
            formtemp.Size = new Size(736, 551);
            formtemp.StartPosition = FormStartPosition.CenterScreen;
            formtemp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formtemp = new Form();
            formtemp.BackgroundImage = Properties.Resources.anh3;
            formtemp.Size = new Size(736, 900);
            formtemp.StartPosition = FormStartPosition.CenterScreen;
            formtemp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formtemp = new Form();
            formtemp.BackgroundImage = Properties.Resources.anh4;
            formtemp.Size = new Size(736, 883);
            formtemp.StartPosition = FormStartPosition.CenterScreen;
            formtemp.ShowDialog();
        }
    }
}
