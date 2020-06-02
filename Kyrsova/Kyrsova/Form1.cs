using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Kyrsova
{
    public partial class Form1 : Form
    {
        // List of ComboBoxes for MatrixA
        private List<ComboBox> combo1 = new List<ComboBox>();
        // List of ComboBoxes for MatrixB
        private List<ComboBox> combo2 = new List<ComboBox>();
        // List of textBoxes for MatrixA
        private List<TextBox> textBoxes1 = new List<TextBox>();
        // List of textBoxes for MatrixB
        private List<TextBox> textBoxes2 = new List<TextBox>();
        Result res;
        Random rand = new Random();
        double[,] matrixA;
        double[,] matrixB;

        public Label WriteLabel(string text, Form f)
        {
            Label lab = new Label();
            lab.Text = text;
            lab.Location = new Point(10, 10);
            lab.Size = new Size(100, 30);
            lab.Font = new Font("Tobota", 20, FontStyle.Bold);

            f.Controls.Add(lab);
            return lab;
        }

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // first combo boxes list
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                    combo1.Add(CreateComboBoxes(105, 45, comboBox1_SelectedIndexChanged));

                else if (i == 1)
                    combo1.Add(CreateComboBoxes(165, 45, comboBox1_SelectedIndexChanged));
            }

            // second combo boxes list
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                    combo2.Add(CreateComboBoxes(630, 45, comboBox2_SelectedIndexChanged));

                else if (i == 1)
                    combo2.Add(CreateComboBoxes(690, 45, comboBox2_SelectedIndexChanged));
            }
        }

        private TextBox CreateTextBoxes(int x, int y, Form f, string text)
        {
            TextBox tex = new TextBox();

            tex.Top = y;
            tex.Left = x;
            tex.Width = 35;
            tex.TextAlign = HorizontalAlignment.Center;
            tex.Text = text;

            f.Controls.Add(tex);
            return tex;
        }

        private ComboBox CreateComboBoxes(int x, int y, EventHandler k)
        {
            ComboBox combo = new ComboBox();

            combo.Size = new Size(35, 20);
            combo.Location = new Point(x, y);
            combo.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            combo.KeyPress += (sender, e) => e.Handled = true;

            combo.SelectedIndexChanged += new EventHandler(k);

            this.Controls.Add(combo);
            return combo;
        }

        // Event for List combo1
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo1[0].Text != "" && combo1[1].Text != "")
            {
                if (textBoxes1.Count != 0)
                {
                    foreach (TextBox tex in textBoxes1)
                    {
                        tex.Dispose();
                    }
                    textBoxes1.Clear();
                }

                int x1 = 15, y1 = 85;
                int count = 0;
                for (int i = 0; i < int.Parse(combo1[0].Text) * int.Parse(combo1[1].Text); i++)
                {

                    if (count == int.Parse(combo1[1].Text))
                    {
                        count = 0;
                        x1 = 15;
                        y1 += 25;
                    }

                    textBoxes1.Add(CreateTextBoxes(x1, y1, this, "0"));

                    x1 += 40;
                    count++;

                }
            }
        }

        // Event for List combo2
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo2[0].Text != "" && combo2[1].Text != "")
            {
                if (textBoxes2.Count != 0)
                {
                    foreach (TextBox tex in textBoxes2)
                    {
                        tex.Dispose();
                    }
                    textBoxes2.Clear();
                }

                int x2 = 540, y2 = 85;
                int count = 0;
                for (int i = 0; i < int.Parse(combo2[0].Text) * int.Parse(combo2[1].Text); i++)
                {

                    if (count == int.Parse(combo2[1].Text))
                    {
                        count = 0;
                        x2 = 540;
                        y2 += 25;
                    }

                    textBoxes2.Add(CreateTextBoxes(x2, y2, this, "0"));

                    x2 += 40;
                    count++;

                }
            }
        }

        // A * B
        private void product_Click(object sender, EventArgs e)
        {
            res = new Result();

            if (combo1[1].Text == combo2[0].Text && combo1[0].Text != "" && combo1[1].Text != "" && combo2[0].Text != "" && combo2[1].Text != "")
            {
                matrixA = matrix.FillMatrix(textBoxes1, int.Parse(combo1[0].Text), int.Parse(combo1[1].Text));
                matrixB = matrix.FillMatrix(textBoxes2, int.Parse(combo2[0].Text), int.Parse(combo2[1].Text));

                double[,] q = new double[int.Parse(combo1[0].Text), int.Parse(combo2[1].Text)];

                q = matrix.Multiply(matrixA, matrixB, int.Parse(combo1[0].Text), int.Parse(combo1[1].Text), int.Parse(combo2[1].Text));

                double[] temp = q.Cast<double>().ToArray();

                WriteLabel("A x B: ", res);

                int x = 20, y = 55;
                int count1 = 0;
                for (int i = 0; i < int.Parse(combo1[0].Text) * int.Parse(combo2[1].Text); i++)
                {

                    if (count1 == int.Parse(combo2[1].Text))
                    {
                        count1 = 0;
                        x = 20;
                        y += 25;
                    }

                    textBoxes1.Add(CreateTextBoxes(x, y, res, temp[i].ToString()));

                    x += 40;
                    count1++;

                }
                res.Show();
            }
            else if (combo1[0].Text == "" && combo1[1].Text == "" && combo2[0].Text == "" && combo2[1].Text == "" || combo1[0].Text == "" || combo1[1].Text == "" || combo2[0].Text == "" 
                || combo2[1].Text == "")
                MessageBox.Show("The number of rows and columns in matrixA and matrixB are not specified!");
            else
                MessageBox.Show("The number of columns in matrixA must be equal to the number of rows int matrixB!");
        }

        // A - B
        private void substraction_Click(object sender, EventArgs e)
        {
            res = new Result();

            if (combo1[0].Text == combo2[0].Text && combo1[1].Text == combo2[1].Text && combo1[0].Text != "" && combo1[1].Text != "" && combo2[0].Text != "" && combo2[1].Text != "")
            {
                matrixA = matrix.FillMatrix(textBoxes1, int.Parse(combo1[0].Text), int.Parse(combo1[1].Text));
                matrixB = matrix.FillMatrix(textBoxes2, int.Parse(combo2[0].Text), int.Parse(combo2[1].Text));

                double[,] q = new double[int.Parse(combo1[0].Text), int.Parse(combo1[1].Text)];

                q = matrix.Substraction(matrixA, matrixB, int.Parse(combo1[0].Text), int.Parse(combo1[1].Text));

                double[] temp = q.Cast<double>().ToArray();

                WriteLabel("A - B: ", res);

                int x = 20, y = 55;
                int count1 = 0;
                for (int i = 0; i < int.Parse(combo1[0].Text) * int.Parse(combo1[1].Text); i++)
                {

                    if (count1 == int.Parse(combo1[1].Text))
                    {
                        count1 = 0;
                        x = 20;
                        y += 25;
                    }

                    textBoxes1.Add(CreateTextBoxes(x, y, res, temp[i].ToString()));

                    x += 40;
                    count1++;

                }
                res.Show();
            }
            else if (combo1[0].Text == "" && combo1[1].Text == "" && combo2[0].Text == "" && combo2[1].Text == "" || combo1[0].Text == "" || combo1[1].Text == "" || combo2[0].Text == "" 
                || combo2[1].Text == "")
                MessageBox.Show("The number of rows and columns in matrixA and matrixB are not specified!");
            else
                MessageBox.Show("The number of rows must be equal between matrixA and matrixB and columns too!");
        }

        // Random numbers for matrixA
        private void randomA_Click(object sender, EventArgs e)
        {
            if (combo1[0].Text != "" && combo1[1].Text != "")
            {
                for (int i = 0; i < textBoxes1.Count; i++)
                {
                    textBoxes1[i].Text = (rand.Next(-10, 10)).ToString();
                }
            }
            else if (combo1[0].Text == "" && combo1[1].Text == "" || combo1[0].Text == "" || combo1[1].Text == "")
                MessageBox.Show("The number of rows and columns in matrixA is not specified!");
        }

        // Random numbers for matrixB
        private void randomB_Click(object sender, EventArgs e)
        {
            if (combo2[0].Text != "" && combo2[1].Text != "")
            {
                for (int i = 0; i < textBoxes2.Count; i++)
                {
                    textBoxes2[i].Text = (rand.Next(-10, 10)).ToString();
                }
            }
            else if (combo2[0].Text == "" && combo2[1].Text == "" || combo2[0].Text == "" || combo2[1].Text == "")
                MessageBox.Show("The number of rows and columns in matrixB is not specified!");
        }

        // A + B
        private void button_sum_Click(object sender, EventArgs e)
        {
            res = new Result();


            if (combo1[0].Text == combo2[0].Text && combo1[1].Text == combo2[1].Text && combo1[0].Text != "" && combo1[1].Text != "" && combo2[0].Text != "" && combo2[1].Text != "")
            {
                matrixA = matrix.FillMatrix(textBoxes1, int.Parse(combo1[0].Text), int.Parse(combo1[1].Text));
                matrixB = matrix.FillMatrix(textBoxes2, int.Parse(combo2[0].Text), int.Parse(combo2[1].Text));

                double[,] q = new double[int.Parse(combo1[0].Text), int.Parse(combo1[1].Text)];

                q = matrix.Sum(matrixA, matrixB, int.Parse(combo1[0].Text), int.Parse(combo1[1].Text));

                double[] temp = q.Cast<double>().ToArray();

                WriteLabel("A + B: ", res);

                int x = 20, y = 55;
                int count1 = 0;
                for (int i = 0; i < int.Parse(combo1[0].Text) * int.Parse(combo1[1].Text); i++)
                {

                    if (count1 == int.Parse(combo1[1].Text))
                    {
                        count1 = 0;
                        x = 20;
                        y += 25;
                    }

                    textBoxes1.Add(CreateTextBoxes(x, y, res, temp[i].ToString()));

                    x += 40;
                    count1++;

                }
                res.Show();
            }
            else if (combo1[0].Text == "" && combo1[1].Text == "" && combo2[0].Text == "" && combo2[1].Text == "" || combo1[0].Text == "" || combo1[1].Text == "" || combo2[0].Text == "" 
                || combo2[1].Text == "")
                MessageBox.Show("The number of rows and columns in matrixA is not specified!");
            else
                MessageBox.Show("The number of rows must be equal between matrixA and matrixB and columns too!");
        }

        // Clear matrixA
        private void ClearA_Click(object sender, EventArgs e)
        {
            if (combo1[0].Text != "" && combo1[1].Text != "")
            {
                for (int i = 0; i < textBoxes1.Count; i++)
                {
                    textBoxes1[i].Text = "0";
                }
            }
            else if (combo1[0].Text == "" && combo1[1].Text == "" || combo1[0].Text == "" || combo1[1].Text == "")
                MessageBox.Show("The number of rows and columns in matrixA is not specified!");
        }

        // Clear matrixB
        private void ClearB_Click(object sender, EventArgs e)
        {
            if (combo2[0].Text != "" && combo2[1].Text != "")
            {
                for (int i = 0; i < textBoxes2.Count; i++)
                {
                    textBoxes2[i].Text = "0";
                }
            }
            else if (combo2[0].Text == "" && combo2[1].Text == "" || combo2[0].Text == "" || combo2[1].Text == "")
                MessageBox.Show("The number of rows and columns in matrixB is not specified!");
        }

        // Transpose matrixA
        private void TransposeA_Click(object sender, EventArgs e)
        {
            res = new Result();

            if (combo1[0].Text != "" && combo1[1].Text != "")
            {
                matrixA = matrix.FillMatrix(textBoxes1, int.Parse(combo1[0].Text), int.Parse(combo1[1].Text));
                matrixA = matrix.TransposeMatrix(matrixA, int.Parse(combo1[0].Text), int.Parse(combo1[1].Text));

                double[] temp = matrixA.Cast<double>().ToArray();

                WriteLabel("MatrixA is transposed: ", res);

                int x = 20, y = 55;
                int count1 = 0;
                for (int i = 0; i < int.Parse(combo1[0].Text) * int.Parse(combo1[1].Text); i++)
                {
                    if (count1 == int.Parse(combo1[0].Text))
                    {
                        count1 = 0;
                        x = 20;
                        y += 25;
                    }

                    textBoxes1.Add(CreateTextBoxes(x, y, res, temp[i].ToString()));

                    x += 40;
                    count1++;

                }
                res.Show();
            }
            else if (combo1[0].Text == "" && combo1[1].Text == "" || combo1[0].Text == "" || combo1[1].Text == "")
                MessageBox.Show("The number of rows and columns in matrixA is not specified!");
        }

        // Transpose matrixB
        private void TransposeB_Click(object sender, EventArgs e)
        {
            res = new Result();

            if (combo2[0].Text != "" && combo2[1].Text != "")
            {
                matrixB = matrix.FillMatrix(textBoxes2, int.Parse(combo2[0].Text), int.Parse(combo2[1].Text));
                matrixB = matrix.TransposeMatrix(matrixB, int.Parse(combo2[0].Text), int.Parse(combo2[1].Text));

                double[] temp = matrixB.Cast<double>().ToArray();

                WriteLabel("MatrixB is transposed: ", res);

                int x = 20, y = 55;
                int count1 = 0;
                for (int i = 0; i < int.Parse(combo2[0].Text) * int.Parse(combo2[1].Text); i++)
                {
                    if (count1 == int.Parse(combo2[0].Text))
                    {
                        count1 = 0;
                        x = 20;
                        y += 25;
                    }

                    textBoxes2.Add(CreateTextBoxes(x, y, res, temp[i].ToString()));

                    x += 40;
                    count1++;

                }
                res.Show();
            }
            else if (combo2[0].Text == "" && combo2[1].Text == "" || combo2[0].Text == "" || combo2[1].Text == "")
                MessageBox.Show("The number of rows and columns in matrixB is not specified!");
        }

        // Determinant of matrixA
        private void determinantA_Click(object sender, EventArgs e)
        {
            res = new Result();

            if (combo1[0].Text == combo1[1].Text && combo1[0].Text != "" && combo1[1].Text != "")
            {
                matrixA = matrix.FillMatrix(textBoxes1, int.Parse(combo1[0].Text), int.Parse(combo1[1].Text));
                double determinant = matrix.Determinant(matrixA, int.Parse(combo1[0].Text), int.Parse(combo1[1].Text));

                double[] temp = matrixA.Cast<double>().ToArray();

                WriteLabel("Deter:", res);

                int x = 20, y = 55;
                int count1 = 0;
                for (int i = 0; i < int.Parse(combo1[0].Text) * int.Parse(combo1[1].Text); i++)
                {
                    if (count1 == int.Parse(combo1[1].Text))
                    {
                        count1 = 0;
                        x = 20;
                        y += 25;
                    }

                    textBoxes1.Add(CreateTextBoxes(x, y, res, temp[i].ToString()));

                    x += 40;
                    count1++;

                }

                Label lab = new Label();
                lab.Text = "Determinant of matrixA: ";
                lab.Location = new Point(20, 270);
                lab.Size = new Size(200, 50); 
                lab.Font = new Font("Tobota", 10, FontStyle.Bold);
                res.Controls.Add(lab);

                TextBox tex = new TextBox();

                tex.Top = 270;
                tex.Left = 230;
                tex.Width = 60;
                tex.TextAlign = HorizontalAlignment.Center;
                tex.Text = determinant.ToString();

                res.Controls.Add(tex);

                res.Show();
            }
            else if (combo1[0].Text == "" && combo1[1].Text == "" || combo1[0].Text == "" || combo1[1].Text == "")
            {
                MessageBox.Show("The number of rows and columns in matrixA is not specified!");
            }
            else if (combo1[0].Text != combo1[1].Text)
            {
                MessageBox.Show("The matrix must be square!");
            }

        }

        // Determinant of matrixB
        private void determinantB_Click(object sender, EventArgs e)
        {
            res = new Result();

            if(combo2[0].Text != "" && combo2[1].Text != "" && combo2[0].Text == combo2[1].Text)
            {
                matrixB = matrix.FillMatrix(textBoxes2, int.Parse(combo2[0].Text), int.Parse(combo2[1].Text));
                double determinant = matrix.Determinant(matrixB, int.Parse(combo2[0].Text), int.Parse(combo2[1].Text));

                double[] temp = matrixB.Cast<double>().ToArray();

                Label lab = new Label();
                lab.Text = "Determinant: ";
                lab.Location = new Point(10, 20);
                lab.Size = new Size(200, 20);
                lab.Font = new Font("Tobota", 15, FontStyle.Bold);
                res.Controls.Add(lab);

                int x = 20, y = 55;
                int count1 = 0;
                for (int i = 0; i < int.Parse(combo2[0].Text) * int.Parse(combo2[1].Text); i++)
                {
                    if (count1 == int.Parse(combo2[1].Text))
                    {
                        count1 = 0;
                        x = 20;
                        y += 25;
                    }

                    textBoxes2.Add(CreateTextBoxes(x, y, res, temp[i].ToString()));

                    x += 40;
                    count1++;

                }

                lab = new Label();
                lab.Text = "Determinant of matrixB: ";
                lab.Location = new Point(20, 270);
                lab.Size = new Size(200, 50);
                lab.Font = new Font("Tobota", 10, FontStyle.Bold);
                res.Controls.Add(lab);

                TextBox tex = new TextBox();
                tex.Top = 270;
                tex.Left = 230;
                tex.Width = 60;
                tex.TextAlign = HorizontalAlignment.Center;
                tex.Text = determinant.ToString();

                res.Controls.Add(tex);

                res.Show();
            }
            else if (combo2[0].Text == "" && combo2[1].Text == "" || combo2[0].Text == "" || combo2[1].Text == "")
                MessageBox.Show("The number of rows and columns in matrixB is not specified!");
            else if(combo2[0].Text != combo2[1].Text)
                MessageBox.Show("The matrix must be square!");
        }

        // Multiply matrixA by number
        private void multiply_numberA_Click(object sender, EventArgs e)
        {
            res = new Result();

            if (combo1[0].Text != "" && combo1[1].Text != "" && Information.IsNumeric(box_for_multiplyA.Text))
            {
                matrixA = matrix.FillMatrix(textBoxes1, int.Parse(combo1[0].Text), int.Parse(combo1[1].Text));
                matrixA = matrix.MultiplyByNumber(matrixA, int.Parse(combo1[0].Text), int.Parse(combo1[1].Text), double.Parse(box_for_multiplyA.Text));

                double[] temp = matrixA.Cast<double>().ToArray();

                WriteLabel("Matrix:", res);

                int x = 20, y = 55;
                int count1 = 0;
                for (int i = 0; i < int.Parse(combo1[0].Text) * int.Parse(combo1[1].Text); i++)
                {
                    if (count1 == int.Parse(combo1[1].Text))
                    {
                        count1 = 0;
                        x = 20;
                        y += 25;
                    }

                    textBoxes1.Add(CreateTextBoxes(x, y, res, temp[i].ToString()));

                    x += 40;
                    count1++;

                }

                res.Show();
            }
            else if (combo1[0].Text == "" && combo1[1].Text == "" || combo1[0].Text == "" || combo1[1].Text == "")
                MessageBox.Show("The number of rows and columns in matrixA is not specified!");
            else if(!Information.IsNumeric(box_for_multiplyA.Text))
                MessageBox.Show("We need number!");

        }

        // Multiply matrixB by number
        private void multiply_numberB_Click(object sender, EventArgs e)
        {
            res = new Result();

            if (combo2[0].Text != "" && combo2[1].Text != "" && Information.IsNumeric(box_for_multiplyB.Text))
            {
                matrixB = matrix.FillMatrix(textBoxes2, int.Parse(combo2[0].Text), int.Parse(combo2[1].Text));
                matrixB = matrix.MultiplyByNumber(matrixB, int.Parse(combo2[0].Text), int.Parse(combo2[1].Text), double.Parse(box_for_multiplyB.Text));

                double[] temp = matrixB.Cast<double>().ToArray();

                WriteLabel("Matrix:", res);

                int x = 20, y = 55;
                int count1 = 0;
                for (int i = 0; i < int.Parse(combo2[0].Text) * int.Parse(combo2[1].Text); i++)
                {
                    if (count1 == int.Parse(combo2[1].Text))
                    {
                        count1 = 0;
                        x = 20;
                        y += 25;
                    }

                    textBoxes2.Add(CreateTextBoxes(x, y, res, temp[i].ToString()));

                    x += 40;
                    count1++;

                }

                res.Show();
            }
            else if (combo2[0].Text == "" && combo2[1].Text == "" || combo2[0].Text == "" || combo2[1].Text == "")
                MessageBox.Show("The number of rows and columns in matrixB is not specified!");
            else if (!Information.IsNumeric(box_for_multiplyB.Text))
                MessageBox.Show("We need number!");
        }

        // Raise to the pow matrixA
        private void powA_Click(object sender, EventArgs e)
        {
            res = new Result();

            if (combo1[0].Text != "" && combo1[1].Text != "" && box_for_powA.Text.All(Char.IsDigit) && combo1[0].Text == combo1[1].Text)
            {
                matrixA = matrix.FillMatrix(textBoxes1, int.Parse(combo1[0].Text), int.Parse(combo1[1].Text));
                matrixA = matrix.RaiseToThePow(matrixA, int.Parse(combo1[0].Text), int.Parse(combo1[1].Text), int.Parse(box_for_powA.Text));

                double[] temp = matrixA.Cast<double>().ToArray();

                WriteLabel("Matrix:", res);

                int x = 20, y = 55;
                int count1 = 0;
                for (int i = 0; i < int.Parse(combo1[0].Text) * int.Parse(combo1[1].Text); i++)
                {
                    if (count1 == int.Parse(combo1[1].Text))
                    {
                        count1 = 0;
                        x = 20;
                        y += 25;
                    }

                    textBoxes1.Add(CreateTextBoxes(x, y, res, temp[i].ToString()));

                    x += 40;
                    count1++;

                }

                res.Show();
            }
            else if (combo1[0].Text == "" && combo1[1].Text == "" || combo1[0].Text == "" || combo1[1].Text == "")
                MessageBox.Show("The number of rows and columns in matrixA is not specified!");
            else if (!box_for_powA.Text.All(Char.IsDigit))
                MessageBox.Show("We need number!");
            else if (combo1[0].Text != combo1[1].Text)
                MessageBox.Show("The matrix must be square!");
        }

        // Raise to the pow matrixB
        private void powB_Click(object sender, EventArgs e)
        {
            res = new Result();

            if (combo2[0].Text != "" && combo2[1].Text != "" && box_for_powB.Text.All(Char.IsDigit) && combo2[0].Text == combo2[1].Text)
            {
                matrixB = matrix.FillMatrix(textBoxes2, int.Parse(combo2[0].Text), int.Parse(combo2[1].Text));
                matrixB = matrix.RaiseToThePow(matrixB, int.Parse(combo2[0].Text), int.Parse(combo2[1].Text), int.Parse(box_for_powB.Text));

                double[] temp = matrixB.Cast<double>().ToArray();

                WriteLabel("Matrix:", res);

                int x = 20, y = 55;
                int count1 = 0;
                for (int i = 0; i < int.Parse(combo2[0].Text) * int.Parse(combo2[1].Text); i++)
                {
                    if (count1 == int.Parse(combo2[1].Text))
                    {
                        count1 = 0;
                        x = 20;
                        y += 25;
                    }

                    textBoxes1.Add(CreateTextBoxes(x, y, res, temp[i].ToString()));

                    x += 40;
                    count1++;

                }

                res.Show();
            }
            else if (combo2[0].Text == "" && combo2[1].Text == "" || combo2[0].Text == "" || combo2[1].Text == "")
                MessageBox.Show("The number of rows and columns in matrixA is not specified!");
            else if (!box_for_powB.Text.All(Char.IsDigit))
                MessageBox.Show("We need number!");
            else if (combo2[0].Text != combo2[1].Text)
                MessageBox.Show("The matrix must be square!");
        }
    }
}