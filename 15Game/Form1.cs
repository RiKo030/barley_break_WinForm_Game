using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15Game
{
    public partial class Form1 : Form
    {
        Dictionary<int, string> Images;
        List<PictureBox> Boxes;
        List<int> GameNumbers;
        List<int> TrueNumbers;
        double sec=0;
        public Form1()
        {
            InitializeComponent();
        }

        void Swap(int fromposition, int inposition)
        {
            if (GameNumbers[inposition] == 15)
            {
                int temp = GameNumbers[fromposition];
                GameNumbers[fromposition] = GameNumbers[inposition];
                GameNumbers[inposition] = temp;
                Bitmap src = new Bitmap(Images.ElementAt(GameNumbers[inposition]).Value);
                Boxes[inposition].Image = src;
                Boxes[fromposition].Image = null;
            }
            if (TrueNumbers.SequenceEqual(GameNumbers))
            {
                timer1.Stop();
                var ts = TimeSpan.FromSeconds(sec);

               string str=($"{ts.Hours} ч. {ts.Minutes} м. {ts.Seconds} с");

                Console.ReadKey();

                MessageBox.Show("GoodGame!! You God it at "+str+", Press New Game if you wanna play again.");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Images = new Dictionary<int, string>(15);
            Images.Add(0, @"img/1.jpg");
            Images.Add(1, @"img/2.jpg");
            Images.Add(2, @"img/3.jpg");
            Images.Add(3, @"img/4.jpg");
            Images.Add(4, @"img/5.jpg");
            Images.Add(5, @"img/6.jpg");
            Images.Add(6, @"img/7.jpg");
            Images.Add(7, @"img/8.jpg");
            Images.Add(8, @"img/9.jpg");
            Images.Add(9, @"img/10.jpg");
            Images.Add(10, @"img/11.jpg");
            Images.Add(11, @"img/12.jpg");
            Images.Add(12, @"img/13.jpg");
            Images.Add(13, @"img/14.jpg");
            Images.Add(14, @"img/15.jpg");
            Boxes = new List<PictureBox>(16);
            Boxes.Add(pictureBox1);
            Boxes.Add(pictureBox2);
            Boxes.Add(pictureBox3);
            Boxes.Add(pictureBox4);
            Boxes.Add(pictureBox5);
            Boxes.Add(pictureBox6);
            Boxes.Add(pictureBox7);
            Boxes.Add(pictureBox8);
            Boxes.Add(pictureBox9);
            Boxes.Add(pictureBox10);
            Boxes.Add(pictureBox11);
            Boxes.Add(pictureBox12);
            Boxes.Add(pictureBox13);
            Boxes.Add(pictureBox14);
            Boxes.Add(pictureBox15);
            Boxes.Add(pictureBox16);
            int i = 0;
            foreach(KeyValuePair<int,string> key in Images)
            {
                Bitmap src = new Bitmap(key.Value);
                Boxes[i].Image = src;
                i++;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TrueNumbers = new List<int>();
            for(int i = 0; i < 16; i++)
            {
                TrueNumbers.Add(i);
            }
            Random rand = new Random();
            GameNumbers = new List<int>();
            while (GameNumbers.Count < 15)
            {
                int r = rand.Next(0, 15);
                if (GameNumbers.Contains(r))
                {

                }
                else
                {
                    GameNumbers.Add(r);
                }
            }
            GameNumbers.Add(15);
            for(int i=0;i<15;i++)
            {
                Bitmap src = new Bitmap(Images.ElementAt(GameNumbers[i]).Value);
                Boxes[i].Image = src;
            }
            Boxes[15].Image = null;
            sec = 0;
            timer1.Start();
        }


        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Swap(0, 1);
            Swap(0, 4);
        }

        private void PictureBox15_Click(object sender, EventArgs e)
        {
            Swap(14, 15);
            Swap(14, 10);
            Swap(14, 13);

        }

        private void PictureBox16_Click(object sender, EventArgs e)
        {
            Swap(15, 14);
            Swap(15, 11);
        }

        private void PictureBox14_Click(object sender, EventArgs e)
        {
            Swap(13, 14);
            Swap(13, 12);
            Swap(13, 9);
        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
            Swap(12, 13);
            Swap(12, 8);
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            Swap(8, 9);
            Swap(8, 12);
            Swap(8, 4);
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            Swap(9, 8);
            Swap(9, 10);
            Swap(9, 13);
            Swap(9, 5);
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            Swap(10, 9);
            Swap(10, 11);
            Swap(10, 6);
            Swap(10, 14);
        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            Swap(11, 10);
            Swap(11, 15);
            Swap(11, 7);
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Swap(4, 5);
            Swap(4, 8);
            Swap(4, 0);
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            Swap(5, 4);
            Swap(5, 6);
            Swap(5, 9);
            Swap(5, 1);
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            Swap(6, 5);
            Swap(6, 7);
            Swap(6, 2);
            Swap(6, 10);
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            Swap(7, 6);
            Swap(7, 11);
            Swap(7, 3);
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Swap(3, 2);
            Swap(3, 7);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Swap(2, 3);
            Swap(2, 6);
            Swap(2, 1);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Swap(1, 2);
            Swap(1, 0);
            Swap(1, 5);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            var ts = TimeSpan.FromSeconds(sec);
            string str = ($"{ts.Hours} ч. {ts.Minutes} м. {ts.Seconds} с");
            label1.Text = str;
            sec +=1;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
