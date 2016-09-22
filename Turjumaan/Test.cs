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
using System.Media;

namespace Turjumaan
{
    public partial class Test : Form
    {
        const bool ENG = true;
        const bool RU = false;
        const bool RIGHT = true;
        const bool WRONG = false;
        const string strNext = "вперед";
        const string strCheck = "проверить";

        private string audiofile;
        Random rnd = new Random();
        List<string> serving = new List<string>();
        List<string> keys = new List<string>();
        List<double> values = new List<double>();
        int counter = 0;

        private void SevingProbability(double maxnum)
        {
            double previous = 0;

            for (int i = 0; i < values.Count; i++)
            {
                values[i] = 10 - Word.dict[keys[i]].Score;
                values[i] = values[i] / maxnum + previous;
                previous = values[i];
            }
        }

        private void GetServing()
        {
            if (Settings.LittleServingCount == Word.serving.Count && Word.LearnedCount == 0) { serving = Word.serving; return; }
            if (Settings.LittleServingCount > Word.serving.Count - Word.LearnedCount) Settings.LittleServingCount = Word.serving.Count - Word.LearnedCount;
            
            serving.Clear();
            keys.Clear();
            values.Clear();
            Random rnd = new Random();
            double maxnum = 0;

            foreach (string str in Word.serving)
            {
                double score = 10 - Word.dict[str].Score;
                if (Word.dict[str].Score != 10)
                {
                    keys.Add(str);
                    values.Add(score);
                    maxnum += score;
                }
            }

            SevingProbability(maxnum);

            int count = 0;

                while (count < Settings.LittleServingCount)
                {
                    double rand;
                    do rand = rnd.NextDouble();
                    while (rand == 0);

                    int index = values.BinarySearch(rand);
                    if (index < 0) index = ~index;

                    count++;
                    serving.Add(keys[index]);
                    maxnum -= 10 - Word.dict[keys[index]].Score;
                    keys.RemoveAt(index);
                    values.RemoveAt(index);
                    SevingProbability(maxnum);
                }
        }
        
        private string NewWord(Word wrd, bool eng)
        {
            textNative.Multiline = false;
            string retexmpl = null;
            if (wrd.Audiofile != "(none)" && eng)
                if (File.Exists(wrd.Audiofile))
                {
                    picPlay.Visible = true;
                    try
                    {
                        (new SoundPlayer(wrd.Audiofile)).Play();
                        audiofile = wrd.Audiofile;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Не удается проиграть аудио", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else picPlay.Visible = false;
            else picPlay.Visible = false;
                   
            string[] _exmpl = wrd.Examples.Split(new Char[] { '|' });
            string[] _russian = wrd.Ru.Split(new string[] { "; " }, StringSplitOptions.RemoveEmptyEntries);
            string exmpl = _exmpl[rnd.Next(_exmpl.Length)];
            string russian = _russian[rnd.Next(_russian.Length)];
            string word = eng ? wrd.Eng : russian;
            try
            {
                retexmpl = (!eng) ? exmpl.Substring(0, exmpl.IndexOf('-') - 1) : exmpl.Substring(exmpl.IndexOf('-') + 2); 
                exmpl = eng ? exmpl.Substring(0, exmpl.IndexOf('-') - 1) : exmpl.Substring(exmpl.IndexOf('-') + 1);
            }
            catch (Exception) { exmpl = " "; retexmpl = " "; }

            textNative.ReadOnly = false;
            textNative.Text = "";
            textNative.SelectionColor = Color.Black;
            textForeign.Text = Environment.NewLine + Environment.NewLine + word + Environment.NewLine;
            textForeign.SelectionStart = textForeign.Text.Length;
            textForeign.SelectionColor = Color.DarkGray;
            textForeign.SelectionFont = new Font("Verdana", 10, FontStyle.Regular);
            textForeign.AppendText(exmpl);
            textForeign.SelectAll();
            textForeign.SelectionAlignment = HorizontalAlignment.Center;

            return retexmpl;
        }

        int right = 0, wrong = 0, learned = 0;
        List<string> learnedList = new List<string>();

        private bool Check(Word wrd, bool eng)
        {
            buttonCheck.Text = strNext;
            textNative.ReadOnly = true;
            textNative.BackColor = Color.White;
            textNative.Multiline = true;
            string answer = textNative.Text;
            string rightanswer = eng ? wrd.Ru : wrd.Eng;
            rightanswer = rightanswer.Replace(", ", "|");

            if (!Regex.IsMatch(answer, rightanswer))
            {
                textNative.SelectAll();
                textNative.SelectionFont = new Font(textNative.SelectionFont.Name, textNative.SelectionFont.SizeInPoints, FontStyle.Strikeout | FontStyle.Bold);
                textNative.SelectionColor = Color.Red;
                textNative.SelectionStart = textNative.TextLength;
                textNative.AppendText(Environment.NewLine);
                textNative.SelectionFont = new Font(textNative.SelectionFont.Name, textNative.SelectionFont.SizeInPoints, FontStyle.Bold);
                textNative.SelectionColor = Color.DarkGreen;
                rightanswer = rightanswer.Replace("|", ", ");
                textNative.AppendText(rightanswer);
                wrong++;
                Word.dict[wrd.Eng].Score -= Settings.deltaDown;
                if (Word.dict[wrd.Eng].Score < 0) Word.dict[wrd.Eng].Score = 0;
                return WRONG;
            }
            else
            {
                textNative.Text = null;
                textNative.SelectionStart = 0;
                textNative.SelectionColor = Color.DarkGreen;
                rightanswer = rightanswer.Replace("|", ", ");
                textNative.AppendText(rightanswer);
                right++;
                Word.dict[wrd.Eng].Score += Settings.deltaUp;
                if (Word.dict[wrd.Eng].Score >= 10) { Word.dict[wrd.Eng].Score = 10; learnedList.Add(wrd.Eng); Word.LearnedCount++; learned++; }
                return RIGHT;
            }
        }

        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            toolTipCheck.SetToolTip(buttonCheck, "Проверить (горячая клавиша - 1)");
            toolTipSkip.SetToolTip(buttonSkip, "Пропустить слово (горячая клавиша - 2)");
            try { GetServing(); }
            catch (Exception E) { MessageBox.Show(E.Message, "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }

            buttonCheck.PerformClick();
       }

        private void textNative_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex rgx = new Regex(@"[а-яА-Яa-zA-ZĘęÓóĄąŚśŁłŻżŹźćŃńĆć\p{C}\-\ ]");
            if (!rgx.IsMatch(e.KeyChar.ToString())) e.Handled = true;
        }

        private void textNative_TextChanged(object sender, EventArgs e)
        {
            buttonCheck.Enabled = textNative.TextLength == 0 ? false : true;
            buttonSkip.Enabled = !buttonCheck.Enabled;
        }

        string exmpl = " ";
        bool lang = ENG;


        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (buttonCheck.Text == strNext)
            {
                if (counter == serving.Count)
                {
                    string msg = "Правильно: " + right + Environment.NewLine + "Неправильно: " + wrong + Environment.NewLine + "Выученные слова (" + learned + "):" + Environment.NewLine;
                    foreach (string str in learnedList) msg += str + ", ";
                    msg = msg.Substring(0, msg.Length - 2);
                    MessageBox.Show(msg, "Тест окончен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Word.WriteDB();
                    this.Close();
                    return;
                }
                switch (Settings.Lang)
                {
                    case "eng":
                        lang = ENG; break;
                    case "rus":
                        lang = RU; break;
                    default:
                        lang = Convert.ToBoolean(rnd.Next(2)); break;
                }
                exmpl = NewWord(Word.dict[serving[counter]], lang); 
                buttonCheck.Text = strCheck;
                buttonCheck.Enabled = false;
                buttonSkip.Enabled = true;
                return;
            }
            else
            {
                if (exmpl != " ") textForeign.AppendText(" — " + exmpl);
                buttonCheck.Text = strNext;
                Check(Word.dict[serving[counter]], lang);
                counter++;
            }
        }

        private void picPlay_Click(object sender, EventArgs e)
        {
            try
            {
                (new SoundPlayer(audiofile)).Play();
            }
            catch (Exception)
            {
                MessageBox.Show("Не удается проиграть аудио", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textNative_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                buttonCheck.PerformClick();
                buttonCheck.Focus();
            }
            if (e.KeyCode == Keys.D2)
            {
                buttonSkip.PerformClick();
                buttonCheck.Focus();
            }
        }

        private void buttonCheck_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                buttonCheck.PerformClick();
                buttonCheck.Focus();
            }
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            textNative.Text = "— пропущено";
            buttonCheck_Click(sender, e);
        }
    }
}
