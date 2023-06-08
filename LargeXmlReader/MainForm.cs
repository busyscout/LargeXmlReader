using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace LargeXmlReader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            var filePath = txtFile.Text;
            if (String.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("Please, enter file path");
                return;
            }
            var elementName = txtElementName.Text.Trim();
            if (String.IsNullOrWhiteSpace(elementName))
            {
                MessageBox.Show("Please, enter element name");
                return;
            }
            txtResult.Text = null;
            var sb = new StringBuilder();
            var elementsCount = (int)numElementsCount.Value;
            var filter = this.txtFilter.Text;
            if (String.IsNullOrWhiteSpace(filter))
                filter = null;
            using (var r = XmlReader.Create(filePath))
            {
                //Reading root element
                while (r.Read())
                {
                    if (r.NodeType == XmlNodeType.Element)
                        break;
                }
                var counter = 0; //Number of read elements
                while (r.Read())
                {
                    if (r.NodeType == XmlNodeType.Element && r.LocalName == elementName)
                    {
                        var outerXml = r.ReadOuterXml();
                        if (filter != null)
                        {
                            if (!outerXml.Contains(filter))
                                continue;
                        }
                        sb.AppendLine(outerXml);
                        counter++;
                        if (counter >= elementsCount)
                            break;
                    }
                }
            }
            txtResult.Text = sb.ToString();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.txtFile.Text = dialog.FileName;
                }
            }
        }

        private void btnReadSample_Click(object sender, EventArgs e)
        {
            var filePath = txtFile.Text;
            if (String.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("Please, enter file path");
                return;
            }
            txtResult.Text = null;
            var offset = (int)numSampleOffset.Value;
            var bytesToRead = (int)numSampleBytes.Value;
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                var buffer = new byte[bytesToRead];
                var byteCount = fs.Read(buffer, offset, bytesToRead);
                txtResult.Text = Encoding.UTF8.GetString(buffer, 0, byteCount);
            }
        }
    }
}
