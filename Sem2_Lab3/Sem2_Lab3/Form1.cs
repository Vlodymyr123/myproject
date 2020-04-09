using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2_Lab3
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private List<Button> all_buttons = new List<Button>();
        private Button button;
        private TextBox boxik = new TextBox();
        private List<int> numbers = new List<int>();
        private int order = 1;

        public Form1()
        {
            InitializeComponent();
            tabPage1.Text = "Task1";
            tabPage2.Text = "Task2";
            AddButtons();
            boxik.Location = new Point(60, 190);
            boxik.Size = new Size(180, 50);
            boxik.Visible = true;
            boxik.TextAlign = HorizontalAlignment.Center;
            boxik.BackColor = Color.LightGreen;
            this.tabControl1.TabPages[1].Controls.Add(boxik);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                comboBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.Items.Count != 0)
                comboBox1.Items.RemoveAt(comboBox1.Items.Count - 1);
        }

        private void AddButtons()
        {
            int x = 50, y = 20;
            int margin = 60;
            int count = 0;

            for(int i = 0; i < 16; i++)
            {
                button = new Button();
                button.Size = new Size(30, 25);
                button.Location = new Point(x, y);

                count++;
                x += margin;

                if(count == 4)
                {
                    y += 40;
                    x = 50;
                    count = 0;
                }

                button.Click += new EventHandler(ButtonClick);

                this.tabControl1.TabPages[1].Controls.Add(button);
                all_buttons.Add(button);
            }

            for (int i = 1; i <= 16; i++)
                numbers.Add(i);

            Suffler.Shuffle(numbers, random);

            for (int i = 0; i < 16; i++)
                all_buttons[i].Text = numbers[i].ToString();
        }

        private void AllClicks()
        {
            for (int i = 0; i < all_buttons.Count; i++)
            {
                all_buttons[i].Click += new EventHandler(ButtonClick);
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if((sender as Button).Text == order.ToString())
            {
                (sender as Button).Visible = false;
                numbers.Remove(int.Parse((sender as Button).Text));
                Suffler.Shuffle(numbers, random);

                for (int i = 0, j = 0; i < all_buttons.Count; i++)
                {
                    if(all_buttons[i].Visible == true)
                    {
                        all_buttons[i].Text = numbers[j].ToString();
                        j++;
                    }
                }

                order++;
            }
            else
            {
                numbers = new List<int>();
                for (int i = 1; i <= 16; i++)
                    numbers.Add(i);

                Suffler.Shuffle(numbers, random);
                for(int i = 0; i < all_buttons.Count; i++)
                {
                    all_buttons[i].Visible = true;
                    all_buttons[i].Text = numbers[i].ToString();
                }
                order = 1;
            }

            if (order == 17)
                boxik.Text = "Nice work!!!";
        }
    }

    public static class Suffler
    {
        public static void Shuffle<T>(this IList<T> list, Random r)
        {
            for (int i = 0; i < list.Count - 1; ++i)
                list.Swap(i, r.Next(i, list.Count()));
        }

        public static void Swap<T>(this IList<T> list, int i, int j)
        {
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
