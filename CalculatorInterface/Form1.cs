using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.CheckedListBox;

namespace CalculatorInterface
{
    public partial class Form1 : Form
    {
        private MathLib.MathLib mathLib;
        SerializeDeserializeLib.SerializeDeserializeLib serializerLib;

        public Form1()
        {
            InitializeComponent();
            mathLib = new MathLib.MathLib();
            serializerLib = new SerializeDeserializeLib.SerializeDeserializeLib();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(mathLib.Sub(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
            string _text = textBox1.Text + "-" + textBox2.Text + "=" + textBox3.Text;
            listBox1.Items.Add(_text);
            _text = null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(mathLib.Add(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
            string _text = textBox1.Text + "+" + textBox2.Text + "=" + textBox3.Text;
            listBox1.Items.Add(_text);
            _text = null;
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(mathLib.Mul(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
            string _text = textBox1.Text + "*" + textBox2.Text + "=" + textBox3.Text;
            listBox1.Items.Add(_text);
            _text = null;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(mathLib.Div(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
            string _text = textBox1.Text + "/" + textBox2.Text + "=" + textBox3.Text;
            listBox1.Items.Add(_text);
            _text = null;
        }

        private void buttonClr_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            listBox1.Items.Clear();
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //SaveFileDialog ofd = new SaveFileDialog();
            //ofd.Filter = "XML Files|*.xml|All files (*.*)|*.*";
            //DialogResult dr = ofd.ShowDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //string filename = ofd.FileName;
                XmlWriter xmlWriter = XmlWriter.Create(saveFileDialog.FileName);


                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("Items");

                foreach (var item in listBox1.Items)
                {
                    xmlWriter.WriteStartElement("Name");
                    xmlWriter.WriteString(item.ToString());
                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
            }

            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    XElement element = new XElement("Items");
            //    foreach (var item in listBox1.Items)
            //    {
            //        element.Add(new XElement("Name", item));
            //    }
            //    XDocument document = new XDocument();
            //    document.Add(element);
            //    document.Save(saveFileDialog.FileName, SaveOptions.None);
            //}
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                using (XmlReader reader = XmlReader.Create(openFileDialog.FileName))
                {
                    reader.ReadStartElement("Items");

                    while (reader.Name == "Name")
                    {
                        XElement el = (XElement)XNode.ReadFrom(reader);
                        listBox1.Items.Add(el.Value);
                    }

                    reader.ReadEndElement();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int _random = random.Next(0, 3);
            int first = random.Next(1, 1000);
            int second = random.Next(1, 1000);
            string _text = null;

            switch (_random)
            {
                case 0:
                    Task.Run(() => _text = Convert.ToString(mathLib.Div(first, second))).Wait();
                    textBox3.Text = _text;
                    _text = first + "/" + second + "=" + textBox3.Text;
                    listBox1.Items.Add(_text);
                    _text = null;
                    break;
                case 1:
                    Task.Run(() => _text = Convert.ToString(mathLib.Mul(first, second))).Wait();
                    textBox3.Text = _text;
                    _text = first + "*" + second + "=" + textBox3.Text;
                    listBox1.Items.Add(_text);
                    _text = null;
                    break;
                case 2:
                    Task.Run(() => _text = Convert.ToString(mathLib.Sub(first, second))).Wait();
                    textBox3.Text = _text;
                    _text = first + "-" + second + "=" + textBox3.Text;
                    listBox1.Items.Add(_text);
                    _text = null;
                    break;
                case 3:
                    Task.Run(() => _text = Convert.ToString(mathLib.Add(first, second))).Wait();
                    textBox3.Text = _text;
                    _text = first + "+" + second + "=" + textBox3.Text;
                    listBox1.Items.Add(_text);
                    _text = null;
                    break;
                default:
                    break;
            }
        }
    }
}