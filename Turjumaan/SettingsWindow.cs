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

namespace Turjumaan
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textWordsCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            e.Handled = true;
        }

        private void double_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;
            TextBox Sender = (TextBox)sender;
            if (Sender.Text.Contains(',') && e.KeyChar == ',') e.Handled = true;
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            textWordsCount.Text = Settings.LittleServingCount.ToString();
            textMaxNumOfWords.Text = Settings.MaxServingCount.ToString();
            textDeltaDown.Text = Settings.deltaDown.ToString();
            textDeltaUp.Text = Settings.deltaUp.ToString();
            label5.Text = Settings.DataPath;
            switch (Settings.Lang)
            {
                case "rus":
                    comboLang.SelectedIndex = 0;
                    break;
                case "eng":
                    comboLang.SelectedIndex = 1;
                    break;
                default:
                    comboLang.SelectedIndex = 2;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                if (double.Parse(textWordsCount.Text) > double.Parse(textMaxNumOfWords.Text)) throw new Exception("Количество изучаемых слов не может быть больше порции!");
                if (double.Parse(textDeltaUp.Text) > 10 || double.Parse(textDeltaDown.Text) > 10) throw new Exception("Приращение не может быть больше 10!");
                if (int.Parse(textWordsCount.Text) < 2 || int.Parse(textMaxNumOfWords.Text) < 2) throw new Exception("Некорректный размер порции");
                StreamWriter sw = new StreamWriter("settings");
                sw.WriteLine(textWordsCount.Text);
                sw.WriteLine(textMaxNumOfWords.Text);
                string langstr;
                switch(comboLang.SelectedIndex)
                {
                    case 0: 
                        langstr = "rus";
                        break;
                    case 1:
                        langstr = "eng";
                        break;
                    default:
                        langstr = "both";
                        break;
                }
                sw.WriteLine(langstr);
                sw.WriteLine(label5.Text);
                sw.WriteLine(textDeltaUp.Text);
                sw.Write(textDeltaDown.Text);
                sw.Close();
                Settings.LittleServingCount = int.Parse(textWordsCount.Text);
                if (Settings.MaxServingCount != int.Parse(textMaxNumOfWords.Text))
                    if (MessageBox.Show("Вы изменили размер текущей порции, желаете получить новую?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        if (File.Exists("serving.db")) File.Delete("serving.db");
                Settings.MaxServingCount = int.Parse(textMaxNumOfWords.Text);
                Settings.Lang = langstr;
                Settings.deltaUp = double.Parse(textDeltaUp.Text);
                Settings.deltaDown = double.Parse(textDeltaDown.Text);
                Settings.DataPath = label5.Text;
                this.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbrowse = new FolderBrowserDialog();
            DialogResult result = fbrowse.ShowDialog();
            if (result == DialogResult.OK)
            {
                label5.Text = fbrowse.SelectedPath;
                Settings.DataPath = fbrowse.SelectedPath;
            }
        }
    }
}
