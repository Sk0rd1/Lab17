using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab17
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            float valueA = float.Parse(textBoxA.Text);
            float valueB = float.Parse(textBoxB.Text);

            DrawEngine drawEngine = new DrawEngine(valueA, valueB);

            Graphics graphics = pictureBoxRhombus.CreateGraphics();
            Pen pen = new Pen(Color.Black, 3);

            graphics.Clear(Color.White);
            drawEngine.Draw(graphics, pen);

            //pictureBoxRhombus.Image = new Bitmap(pictureBoxRhombus.Width, pictureBoxRhombus.Height);
            //label1.Text = pictureBoxRhombus.Width.ToString();
            //label2.Text = pictureBoxRhombus.Height.ToString();
        }

        private void buttonSerialize_Click(object sender, EventArgs e)
        {
            SerializeEngine serializeEngine = new SerializeEngine(float.Parse(textBoxA.Text), float.Parse(textBoxB.Text));
            serializeEngine.SerializeBinary(textBoxBinary.Text);
        }

        private void buttonDeserialize_Click(object sender, EventArgs e)
        {
            SerializeEngine serializeEngine = new SerializeEngine();
            serializeEngine = serializeEngine.DeserializeBinary(textBoxBinary.Text);

            textBoxA.Text = serializeEngine.A.ToString();
            textBoxB.Text = serializeEngine.B.ToString();

        }

        private void buttonSerializeXML_Click(object sender, EventArgs e)
        {
            SerializeEngine serializeEngine = new SerializeEngine(float.Parse(textBoxA.Text), float.Parse(textBoxB.Text));
            serializeEngine.SerializeXml(textBoxXML.Text);
        }

        private void buttonDeserializeXML_Click(object sender, EventArgs e)
        {
            SerializeEngine serializeEngine = new SerializeEngine();
            serializeEngine = serializeEngine.DeserializeXml(textBoxXML.Text);

            textBoxA.Text = serializeEngine.A.ToString();
            textBoxB.Text = serializeEngine.B.ToString();
        }

        private void textBoxBinary_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
