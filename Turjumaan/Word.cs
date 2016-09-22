using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Turjumaan
{
    class Word
    {
        public static void MakeDB()
        {
            Dictionary<string, Word> temp = new Dictionary<string, Word>();
            if (File.Exists("words.db"))
            {
                try
                {
                    StreamReader streamread = new StreamReader("words.db");
                    while (streamread.Peek() >= 0)
                    {
                        String row = streamread.ReadLine();
                        if (row.Length == 0) continue;
                        string[] split = row.Split(new Char[] { '\t' });
                        Word wrd = new Word(split[0], split[1], double.Parse(split[3]), split[4], split[2]);
                        temp.Add(split[0], wrd);
                        if (wrd.Score >= 10) LearnedCount++;
                    }
                    Word.dict = temp;
                    streamread.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка чтения базы данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public static void WriteNew(string english, string russian, string examples, string audio)
        {
            try
            {
                StreamWriter streamwrite = new StreamWriter("words.db", true);
                Word wrd = new Word(english, russian, examples, audio);
                Word.dict.Add(english, wrd);
                streamwrite.WriteLine(english + "\t" + russian + "\t" + audio + "\t0\t" + examples);
                streamwrite.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка создания базы данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void EditWord(Word wrd, string audio)
        {
            try
            {
                string[] lines = File.ReadAllLines("words.db");
                Regex rgx = new Regex(@"^" + wrd.Eng);
                for (int i = 0; i < lines.Count(); i++)
                    if (rgx.IsMatch(lines[i]))
                    {
                        lines[i] = wrd.Eng + "\t" + wrd.Ru + "\t" + audio + "\t" + wrd.Score + "\t" + wrd.Examples;
                        break;
                    }
                File.WriteAllLines("words.db", lines);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка создания базы данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void WriteDB()
        {
            try
            {
                string[] lines = new string[dict.Count];
                int i = 0;
                foreach (KeyValuePair<string, Word> kvp in dict)
                {
                    string audio = kvp.Value.Audiofile.Substring(Settings.DataPath.Length);
                    lines[i] = kvp.Value.Eng + "\t" + kvp.Value.Ru + "\t" + audio + "\t" + kvp.Value.Score + "\t" + kvp.Value.Examples;
                    i++;
                }
                File.WriteAllLines("words.db", lines);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка создания базы данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void ClearScores(Word wrd)
        {
            try
            {
                string[] lines = File.ReadAllLines("words.db");
                Regex rgx = new Regex(@"^" + wrd.Eng);
                for (int i = 0; i < lines.Count(); i++)
                    if (rgx.IsMatch(lines[i]))
                    {
                        string[] splt = lines[i].Split(new Char[] { '\t' });
                        lines[i] = splt[0] + "\t" + splt[1] + "\t" + splt[2] + "\t0\t" + splt[4];
                        break;
                    }
                File.WriteAllLines("words.db", lines);
                if (wrd.Score >= 10) LearnedCount--;
                Word.dict[wrd.Eng].Score = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка создания базы данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        public static bool DeleteWord(Word wrd)
        {
            try
            {
                if (serving.IndexOf(wrd.Eng) != -1) throw new Exception("Это слово находится в текущей порции!");
                string[] lines = File.ReadAllLines("words.db");
                Regex rgx = new Regex(@"^" + wrd.Eng);
                for (int i = 0; i < lines.Count(); i++)
                    if (rgx.IsMatch(lines[i]))
                    {
                        lines[i] = lines[lines.Count() - 1];
                        lines[lines.Count() - 1] = "";
                        Array.Resize(ref lines, lines.Count() - 1);
                        break;
                    }
                File.WriteAllLines("words.db", lines);
                if (wrd.Score >= 10) LearnedCount--;
                return true;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public static int GetServing()
        {
            try
            {
                int servcount;
                serving = new List<string>();
                LearnedCount = 0;
                foreach (KeyValuePair<string, Word> wrd in dict)
                    if (wrd.Value.Score != 10) serving.Add(wrd.Key);
                if (Settings.MaxServingCount < serving.Count)
                {
                    servcount = Settings.MaxServingCount;
                    serving.Shuffle();
                    serving.RemoveRange(servcount, serving.Count - servcount);
                }
                else servcount = serving.Count;
                File.WriteAllLines("serving.db", serving);
                return servcount;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return 0;
        }

        public static void GetLearned()
        {
            int count = 0;
            foreach (string str in serving)
                if (dict[str].Score == 10) count++;
            LearnedCount = count;
        }

        public Word(string english, string russian, string examples, string audio)
        {
            this.Eng = english;
            this.Ru = russian;
            this.Score = 0;
            this.Examples = examples;
            this.Audiofile = Settings.DataPath + audio;
        }

        public Word(string english, string russian, double scores, string examples, string audio)
        {
            this.Eng = english;
            this.Ru = russian;
            this.Score = scores;
            this.Examples = examples;
            this.Audiofile = Settings.DataPath + audio;
        }

        public string Eng;
        public string Ru;
        public double Score;
        public string Audiofile = null;
        public string Examples;
        public static Dictionary<string, Word> dict;
        public static List<string> serving;
        public static int LearnedCount = 0;

    }
}
