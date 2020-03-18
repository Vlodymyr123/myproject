using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Calculator
{
    class Calculator : Button
    {
        List<Button> buttonList = new List<Button>();
        private TextBox tex = new TextBox();
        private bool operations_way = false;
        private int operation = 0;
        private float first_number, second_number;
        private float result;
        private bool sign;

        public void CreateTextBox(Form f)
        {
            tex.Top = 20;
            tex.Left = 20;
            tex.Size = new Size(215, 2);
            tex.MaxLength = 100;
            f.Controls.Add(tex);
            tex.TextAlign = HorizontalAlignment.Right;
        }

        public Button CreateButton(int X, int Y, string text)
        {
            Button btn = new Button();

            btn.Text = text;
            btn.Location = new Point(X, Y);
            btn.Size = new Size(50, 50);
            btn.ForeColor = Color.Red;
            btn.BackColor = Color.White;
            btn.Font = new Font("Tahome", 10F, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            return btn;
        }

        public void CreateButtonsField(Form f)
        {
            Button button;
            int x = 20, y = 105;
            int nextPos = 55;
            int text = 7;
            int counter = 0;
            for (int i = 0; i < 9; i++)
            {
                if (counter < 2)
                {
                    button = CreateButton(x, y, text.ToString());
                    x += nextPos;
                    counter++;
                    text++;
                    buttonList.Add(button);
                    button.ForeColor = Color.Black;
                }
                else
                {
                    button = CreateButton(x, y, text.ToString());
                    x = 20;
                    y += nextPos;
                    counter = 0;
                    text -= 5;
                    buttonList.Add(button);
                    button.ForeColor = Color.Black;
                }
                f.Controls.Add(button);
            }


            button = CreateButton(x, y, "+/-");
            x += nextPos;
            f.Controls.Add(button);
            buttonList.Add(button);

            button = CreateButton(x, y, 0.ToString());
            f.Controls.Add(button);
            buttonList.Add(button);

            x += nextPos;
            button = CreateButton(x, y, ",");
            f.Controls.Add(button);
            buttonList.Add(button);

            y = 50;
            x = 20 + nextPos;
            button = CreateButton(x, y, "<-");
            f.Controls.Add(button);
            buttonList.Add(button);

            y = 50;
            x = 20;
            button = CreateButton(x, y, "C");
            f.Controls.Add(button);
            buttonList.Add(button);

            y = 105 + nextPos * 2;
            x = 20 + nextPos * 3;
            button = CreateButton(x, y, "=");
            button.Size = new Size(50, 105);
            f.Controls.Add(button);
            buttonList.Add(button);

            y -= nextPos;
            button = CreateButton(x, y, "+");
            f.Controls.Add(button);
            buttonList.Add(button);

            y -= nextPos;
            button = CreateButton(x, y, "-");
            f.Controls.Add(button);
            buttonList.Add(button);

            y -= nextPos;
            button = CreateButton(x, y, "/");
            f.Controls.Add(button);
            buttonList.Add(button);

            x -= nextPos;
            button = CreateButton(x, y, "*");
            f.Controls.Add(button);
            buttonList.Add(button);
        }

        public void AllClicks()
        {
            for (int i = 0; i < buttonList.Count; i++)
            {
                buttonList[i].Click += new EventHandler(ButtonClick);
            }
        }

        public void ButtonClick(object sender, EventArgs e)
        {
            switch ((sender as Button).Text)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "0":
                    {
                        tex.Text += (sender as Button).Text;
                        break;
                    }
                case "+":
                case "-":
                case "*":
                case "/":
                    if(tex.Text != "")
                    {
                        operations_way = false;
                        first_number = float.Parse(tex.Text);
                        tex.Clear();

                        switch((sender as Button).Text)
                        {
                            case "+": operation = 1; break;
                            case "-": operation = 2; break;
                            case "*": operation = 3; break;
                            case "/": operation = 4; break;
                        }
                        
                    }
                       break;
                case "=":
                    {
                        if (tex.Text != "")
                        {
                            if(!operations_way)
                                second_number = float.Parse(tex.Text);

                            switch (operation)
                            {
                                case 1:
                                    {
                                        if (operations_way)
                                            result += second_number;
                                        else
                                            result = first_number + second_number;

                                        operations_way = true;
                                        tex.Text = result.ToString();
                                        break;
                                    }
                                case 2:
                                    {
                                        if (operations_way)
                                            result -= second_number;
                                        else
                                            result = first_number - second_number;

                                        operations_way = true;
                                        tex.Text = result.ToString();
                                        break;
                                    }
                                case 3:
                                    {
                                        if (operations_way)
                                            result *= second_number;
                                        else
                                            result = first_number * second_number;

                                        operations_way = true;
                                        tex.Text = result.ToString();
                                        break;
                                    }
                                case 4:
                                    {
                                        if (operations_way)
                                            result /= second_number;
                                        else
                                            result = first_number / second_number;

                                        operations_way = true;
                                        tex.Text = result.ToString();
                                        break;
                                    }
                            }
                        }
                    }
                        break;
                case ",":
                    {
                        if (!tex.Text.Contains(","))
                        {
                            if (tex.Text == "")
                                tex.Text += tex.Text + "0,";
                            else
                                tex.Text = tex.Text + ",";
                        }
                        else if (tex.Text.Contains(","))
                            return;
                        break;
                    }
                case "+/-":
                    {
                        if (sign == true)
                        {
                            tex.Text = "-" + tex.Text;
                            sign = false;
                        }
                        else if (sign == false)
                        {
                            tex.Text = tex.Text.Replace("-", "");
                            sign = true;
                        }
                        break;
                    }
                case "C":
                    {
                        tex.Clear();
                        break;
                    }
                case "<-":
                    {
                        int lenght = tex.Text.Length - 1;
                        string text = tex.Text;
                        tex.Clear();
                        for (int i = 0; i < lenght; i++)
                        {
                            tex.Text = tex.Text + text[i];
                        }
                        break;
                    }
            }
        }
    }
}
