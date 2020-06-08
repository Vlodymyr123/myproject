using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Win32;

namespace quarantine_register
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string txtPath = @".\note.txt";
        private string xmlPath = @".\xmlDoc.xml";
        private string datPath = @".\note.dat";


        private void Form1_Load(object sender, EventArgs e)
        {
            // Запис та читання файлів змінюєтсья за допомогою методів через код
            ReadFromRegister();
            //ReadFromDat();
            //ReadFromTxt();
            //ReadFromXml();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            WriteToRegister();
            //WriteToDat();
            //WriteToTxt();
            //WriteToXml();
        }

        // Записати в txt файл
        private void WriteToTxt()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(txtPath, false, Encoding.Default))
                {
                    writer.WriteLine(this.Location.X);
                    writer.WriteLine(this.Location.Y);
                    writer.WriteLine(this.Height);
                    writer.WriteLine(this.Width);
                    writer.WriteLine(this.textBox1.Text);
                    writer.WriteLine(this.checkBox1.Checked);
                    writer.WriteLine(this.checkBox2.Checked);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Читати з txt файлу
        private void ReadFromTxt()
        {
            FileInfo file = new FileInfo(txtPath);
            if(file.Exists && file.Length != 0)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(txtPath, Encoding.Default))
                    {
                        this.Location = new Point(Convert.ToInt32(sr.ReadLine()), Convert.ToInt32(sr.ReadLine()));
                        this.Height = Convert.ToInt32(sr.ReadLine());
                        this.Width = Convert.ToInt32(sr.ReadLine());
                        this.textBox1.Text = sr.ReadLine();
                        this.checkBox1.Checked = Convert.ToBoolean(sr.ReadLine());
                        this.checkBox2.Checked = Convert.ToBoolean(sr.ReadLine());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Записати в xml файл
        private void WriteToXml()
        {
            try
            {
                var xmlDoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("information"));

                xmlDoc.Root.Add(new XElement("LocationX", this.Location.X),
                    new XElement("LocationY", this.Location.Y),
                    new XElement("Height", this.Height),
                    new XElement("Width", this.Width),
                    new XElement("textBox", this.textBox1.Text),
                    new XElement("CheckBox1", this.checkBox1.Checked),
                    new XElement("CheckBox2", this.checkBox2.Checked));

                xmlDoc.Save(Path.Combine(Environment.CurrentDirectory, "xmlDoc.xml"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Читати з xml файлу
        private void ReadFromXml()
        {
            string text = "";

            FileInfo file = new FileInfo(xmlPath);
            if(file.Exists && file.Length != 0)
            {
                XmlTextReader reader = new XmlTextReader(xmlPath);

                reader.ReadToFollowing("information");
                reader.MoveToFirstAttribute();
                reader.ReadToFollowing("LocationX");
                text = reader.ReadElementContentAsString();
                reader.ReadToFollowing("LocationY");
                this.Location = new Point(Convert.ToInt32(text), reader.ReadElementContentAsInt());
                reader.ReadToFollowing("Height");
                this.Height = reader.ReadElementContentAsInt();
                reader.ReadToFollowing("Width");
                this.Width = reader.ReadElementContentAsInt();
                reader.ReadToFollowing("textBox");
                this.textBox1.Text = reader.ReadElementContentAsString();
                reader.ReadToFollowing("CheckBox1");
                this.checkBox1.Checked = reader.ReadElementContentAsBoolean();
                reader.ReadToFollowing("CheckBox2");
                this.checkBox2.Checked = reader.ReadElementContentAsBoolean();
                reader.Close();
            }
            file.Delete();

        }

        // Записати в dat файл
        private void WriteToDat()
        {
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(datPath, FileMode.OpenOrCreate)))
                {
                    writer.Write(this.Location.X);
                    writer.Write(this.Location.Y);
                    writer.Write(this.Height);
                    writer.Write(this.Width);
                    writer.Write(this.textBox1.Text);
                    writer.Write(this.checkBox1.Checked);
                    writer.Write(this.checkBox2.Checked);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Читати з dat файлу
        private void ReadFromDat()
        {
            FileInfo file = new FileInfo(datPath);
            if(file.Exists && file.Length != 0)
            {
                try
                {
                    using (BinaryReader reader = new BinaryReader(File.Open(datPath, FileMode.Open)))
                    {
                        while (reader.PeekChar() > -1)
                        {
                            this.Location = new Point(reader.ReadInt32(), reader.ReadInt32());
                            this.Height = reader.ReadInt32();
                            this.Width = reader.ReadInt32();
                            this.textBox1.Text = reader.ReadString();
                            this.checkBox1.Checked = reader.ReadBoolean();
                            this.checkBox2.Checked = reader.ReadBoolean();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Записати в register
        private void WriteToRegister()
        {
            try
            {
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey newKey = currentUserKey.CreateSubKey("newKey");
                newKey.SetValue("PositionX", this.Location.X);
                newKey.SetValue("PositionY", this.Location.Y);
                newKey.SetValue("Height", this.Height);
                newKey.SetValue("Width", this.Width);
                newKey.SetValue("textBox", this.textBox1.Text);
                newKey.SetValue("checkBox1", this.checkBox1.Checked);
                newKey.SetValue("checkBox2", this.checkBox2.Checked);
                newKey.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Читати з register
        private void ReadFromRegister()
        {
            try
            {
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey newKey = currentUserKey.CreateSubKey("newKey");
                if(newKey.ValueCount != 0)
                {
                    this.Location = new Point(Convert.ToInt32(newKey.GetValue("PositionX")), Convert.ToInt32(newKey.GetValue("PositionY")));
                    this.Height = Convert.ToInt32(newKey.GetValue("Height"));
                    this.Width = Convert.ToInt32(newKey.GetValue("Width"));
                    this.textBox1.Text = (newKey.GetValue("textBox").ToString());
                    this.checkBox1.Checked = Convert.ToBoolean(newKey.GetValue("checkBox1"));
                    this.checkBox2.Checked = Convert.ToBoolean(newKey.GetValue("checkBox2"));
                    newKey.Close();
                    currentUserKey.DeleteSubKey("newKey");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
