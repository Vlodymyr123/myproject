using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace quarantine_files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"D:\Task1");
            DirectoryInfo dir = new DirectoryInfo(@"D:\Task1");
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    dir.CreateSubdirectory("Folder_" + i);
                }
                MessageBox.Show("Folders create!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:\Task1");
            try
            {
                dir.Delete(true);
                MessageBox.Show("Folders delete!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\Task2";
                Directory.CreateDirectory(path);
                for (int i = 0; i < 24; i++)
                {
                    path = path + @"\";
                    Directory.CreateDirectory(path + "Folder_" + i);
                    path += "Folder_" + i;
                }
                MessageBox.Show("Folders create!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\Task2";
                Directory.Delete(path, true);
                MessageBox.Show("Folders delete!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                groupBox1.Controls.Clear();
                string catalog = Directory.GetCurrentDirectory();
                string fileName = textBox1.Text + ".txt";
                int y = 0;
                Button but;
                foreach (string finder in Directory.EnumerateFiles(catalog, fileName, SearchOption.AllDirectories))
                {
                    FileInfo FI;
                    try
                    {
                        FI = new FileInfo(finder);
                        richTextBox2.Text += FI.Name + " " + FI.FullName + " " + FI.Length + "_byte" +
                        " CreationTime: " + FI.CreationTime + "\n\n";

                        but = new Button();
                        but.Width = groupBox1.Width;
                        but.Location = new Point(0, y);
                        but.Text = finder;
                        y += 20;
                        groupBox1.Controls.Add(but);
                        but.Click += new EventHandler(FilesClick);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        continue;
                    }
                }
            }
            
        }

        private void FilesClick(object sender, EventArgs e)
        {
            string file = (sender as Button).Text;

            FileStream stream = File.OpenRead(file);

            byte[] array = new byte[stream.Length];
            stream.Read(array, 0, array.Length);

            string textFromFile = System.Text.Encoding.Default.GetString(array);
            richTextBox1.Text = textFromFile;
            stream.Close();
        }
    }
}
