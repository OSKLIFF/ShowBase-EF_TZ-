using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public string _filepath;
        public Form1()
        {
            InitializeComponent();
            File_BT.Click += File_BT_Click;
            Save_BT.Click += Save_BT_Click;
            Size_Font.KeyUp += Size_Font_KeyUp;
            Size_Font.ValueChanged += Size_Font_ValueChanged;
        }
        private void Size_Font_ValueChanged(object sender, EventArgs e)
        {
            Content_Viewer.Font = new Font("Calibri", (float)Size_Font.Value);
        }
        private void Size_Font_KeyUp(object sender, KeyEventArgs e)
        {
            if (Size_Font.Value < 8)
                Size_Font.Value = 8;
            if (Size_Font.Value > 16)
                Size_Font.Value = 16;
        }
        private void Save_BT_Click(object sender, EventArgs e)
        {
            if (_filepath == null)
            {
                MessageBox.Show("Вы не выбрали файл!");
                return;
            }
            File.WriteAllText(_filepath, Content_Viewer.Text);
            MessageBox.Show("Файл изменен!");
        }
        private void File_BT_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Показать все файлы | *.txt";
            dialog.ShowDialog();
            if (dialog.FileName == "")
                return;
            StreamReader reader = new StreamReader(dialog.OpenFile());
            _filepath = dialog.FileName;
            Content_Viewer.Text = reader.ReadToEnd();
            reader.Close();
        }
    }
}
