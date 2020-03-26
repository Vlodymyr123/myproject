using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2_Lab2
{
    public partial class Form1 : Form
    {
        private Button runningButton = new Button();
        private Button simpleButton = new Button();
        private int count = 0;
        int buttonWidth = 95, buttonHeight = 35;

        public Form1()
        {
            InitializeComponent();
            SomeEvents();
            this.Text = "Click Ok!";
            timer1.Interval = 500;
            timer1.Start();
            timer2.Interval = 800;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            runningButton.Text = "Ok";
            runningButton.Size = new Size(buttonWidth, buttonHeight);
            runningButton.Location = new Point(335, 160);
            runningButton.Font = new Font("Georgia", 10f, FontStyle.Bold);
            runningButton.ForeColor = Color.Red;
            this.Controls.Add(runningButton);

            simpleButton.Text = "Cancel";
            simpleButton.Size = new Size(buttonWidth, buttonHeight);
            simpleButton.Location = new Point(335, 220);
            simpleButton.Font = new Font("Georgia", 10f, FontStyle.Bold);
            this.Controls.Add(simpleButton);


        }

        private void SomeEvents()
        {
            this.MouseMove += new MouseEventHandler(this.Form1_MouseMove);
            simpleButton.Click += new EventHandler(simpleButtonClick);
            runningButton.GotFocus += new EventHandler(DeleteFocus);
        }

        private void DeleteFocus(object sender, EventArgs e)
        {
            simpleButton.Focus();
        }

        private void simpleButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int speed = 10;

            if (runningButton.Width == 0)
            {
                this.Controls.Remove(runningButton);
                runningButton.Dispose();
                timer1.Stop();
                this.Text = "Ok can`t be clicked!";
                timer2.Start();
            }

            if (e.X > runningButton.Location.X - 15 && e.X < runningButton.Location.X - 5 && e.Y > runningButton.Location.Y - 20 && e.Y < runningButton.Location.Y)
            {
                runningButton.Location = new Point(runningButton.Location.X + speed, runningButton.Location.Y + speed);
                runningButton.Size -= new Size(1, 0);
            }

            if (e.X > runningButton.Location.X + 100 && e.X < runningButton.Location.X + 120 && e.Y < runningButton.Location.Y && e.Y >= runningButton.Location.Y - 10)
            {
                runningButton.Location = new Point(runningButton.Location.X - speed, runningButton.Location.Y + speed);
                runningButton.Size -= new Size(1, 0);
            }

            if (e.X > runningButton.Location.X - 15 && e.X < runningButton.Location.X - 5 && e.Y < runningButton.Location.Y + 50 && e.Y > runningButton.Location.Y + 30)
            {
                runningButton.Location = new Point(runningButton.Location.X + speed, runningButton.Location.Y - speed);
                runningButton.Size -= new Size(1, 0);
            }

            if (e.X > runningButton.Location.X + 100 && e.X < runningButton.Location.X + 110 && e.Y < runningButton.Location.Y + 50 && e.Y >= runningButton.Location.Y + 30)
            {
                runningButton.Location = new Point(runningButton.Location.X - speed, runningButton.Location.Y - speed);
                runningButton.Size -= new Size(1, 0);
            }

            if (e.X > runningButton.Location.X && e.X < runningButton.Location.X + 100 && e.Y < runningButton.Location.Y - 30 && e.Y > runningButton.Location.Y - 50)
            {
                runningButton.Location = new Point(runningButton.Location.X, runningButton.Location.Y + speed);
                runningButton.Size -= new Size(1, 0);
            }

            if (e.X > runningButton.Location.X - 5 && e.X < runningButton.Location.X + 100 && e.Y < runningButton.Location.Y + 50 && e.Y > runningButton.Location.Y + 40)
            {
                runningButton.Location = new Point(runningButton.Location.X, runningButton.Location.Y - speed);
                runningButton.Size -= new Size(1, 0);
            }

            if (e.X > runningButton.Location.X - 30 && e.X < runningButton.Location.X - 10 && e.Y < runningButton.Location.Y + 40 && e.Y >= runningButton.Location.Y)
            {
                runningButton.Location = new Point(runningButton.Location.X + speed, runningButton.Location.Y);
                runningButton.Size -= new Size(1, 0);
            }

            if (e.X > runningButton.Location.X + 100 && e.X < runningButton.Location.X + 110 && e.Y < runningButton.Location.Y + 40 && e.Y >= runningButton.Location.Y)
            {
                runningButton.Location = new Point(runningButton.Location.X - speed, runningButton.Location.Y);
                runningButton.Size -= new Size(1, 0);
            }

            //FormBorders

            //left
            if (runningButton.Location.X < 1)
            {
                if (e.Y > runningButton.Location.Y + buttonHeight / 2)
                    runningButton.Location = new Point(runningButton.Location.X + 50, runningButton.Location.Y - 50);
                else
                    runningButton.Location = new Point(runningButton.Location.X + 50, runningButton.Location.Y + 50);
            }

            //right
            if (runningButton.Location.X + buttonWidth - 30 > this.Width)
            {
                if (e.Y > runningButton.Location.Y + buttonHeight / 2)
                    runningButton.Location = new Point(runningButton.Location.X - 50, runningButton.Location.Y - 50);
                else
                    runningButton.Location = new Point(runningButton.Location.X - 50, runningButton.Location.Y + 50);

            }

            //bottom
            if (runningButton.Location.Y > this.Height - buttonHeight - 30)
            {
                if (e.X > runningButton.Location.X + buttonWidth / 2)
                    runningButton.Location = new Point(runningButton.Location.X - 50, runningButton.Location.Y - 100);
                else
                    runningButton.Location = new Point(runningButton.Location.X + 50, runningButton.Location.Y - 100);
            }

            //top
            if (runningButton.Location.Y < 0)
            {
                if (e.X > runningButton.Location.X + buttonWidth / 2)
                    runningButton.Location = new Point(runningButton.Location.X - 50, runningButton.Location.Y + 50);
                else
                    runningButton.Location = new Point(runningButton.Location.X + 50, runningButton.Location.Y + 50);

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Text == "Ok can`t be clicked!")
                this.Text = "";
            else
                this.Text = "Ok can`t be clicked!";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (this.count++ < 16)
            {
                if (this.Text == "Click Ok!")
                    this.Text = "";
                else
                    this.Text = "Click Ok!";
            }
        }
    }
}
