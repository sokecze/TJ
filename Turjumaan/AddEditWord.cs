using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Turjumaan
{
    public partial class AddEditWord : Form
    {
        string str;

        public AddEditWord()
        {
            InitializeComponent();
        }

        private void textBoxEng_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex rgx = new Regex(@"[a-zA-ZĘęÓóĄąŚśŁłŻżŹźćŃń\p{C}\-\ ']");
            if (!rgx.IsMatch(e.KeyChar.ToString())) e.Handled = true;
        }

        private void textBoxEng_TextChanged(object sender, EventArgs e)
        {
            str = textBoxEng.Text;
            str = str.ToLower();
            try
            {
                if (File.Exists(Settings.DataPath + "\\" + str[0] + "\\" + str + ".wav"))
                {
                    labelAudio.Text = "\\" + str[0] + "\\" + str + ".wav";
                }
            }
            catch (Exception)
            {

            }
        }

        private void labelAudio_MouseDown(object sender, MouseEventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (labelAudio.Text == "(none)") of.InitialDirectory = Settings.DataPath;
            else of.InitialDirectory = Settings.DataPath + "\\" + labelAudio.Text.ToString()[1] + "\\";
            of.FileName = str + ".wav";
            of.Filter = "wav files (*.wav)|*.wav";

            if (of.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (!of.FileName.Contains(Settings.DataPath)) throw new Exception("Файл должен находиться в каталоге, укзанном в настройках!");
                    labelAudio.Text = of.FileName.Substring(Settings.DataPath.Length);
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textBoxRu_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex rgx = new Regex(@"[а-яА-Я\p{C}\-,\ ]");
            if (!rgx.IsMatch(e.KeyChar.ToString())) e.Handled = true;
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            labelAudio.Text = "(none)";
        }

        private void AddEditWord_Load(object sender, EventArgs e)
        {

        }

        private void textBoxExmpls_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex rgx = new Regex(@"[а-яА-Яa-zA-Z\p{C}\p{P}\ ]");
            if (!rgx.IsMatch(e.KeyChar.ToString())) e.Handled = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxEng.Text.Length == 0) throw new Exception("Поле английского языка не может быть пустым!");
                if (textBoxRu.Text.Length == 0) throw new Exception("Поле русского языка не может быть пустым!");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.Cancel;
            }
        }

    }
}
