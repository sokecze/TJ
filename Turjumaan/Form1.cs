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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Turjumaan
{
    public partial class Main : Form
    {
       private void GetLearnedCount()
        {
            int temp = 0;
            foreach (string wrd in Word.serving)
                try 
                {
                    if (Word.dict[wrd].Score == 10) temp++;
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            Word.LearnedCount = temp;
            labelNum.Text = temp.ToString();
        }

        public Main()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsWindow settings = new SettingsWindow();
            settings.ShowDialog();
            if (File.Exists("serving.db") == false) buttonGet.Visible = true; 
        }

        private void Main_Load(object sender, EventArgs e)
        {

            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            if (File.Exists("settings") == true)
            {
                StreamReader sr = new StreamReader("settings");
                Settings.LittleServingCount = int.Parse(sr.ReadLine());
                Settings.MaxServingCount = int.Parse(sr.ReadLine());
                Settings.Lang = sr.ReadLine();
                Settings.DataPath = sr.ReadLine();
                Settings.deltaUp = double.Parse(sr.ReadLine());
                Settings.deltaDown = double.Parse(sr.ReadLine());
                sr.Close();
            }
            Word.MakeDB();
            if (File.Exists("serving.db") == false) buttonGet.Visible = true; 
            else {
                try { 
                    Word.serving = new List<string>(File.ReadAllLines("serving.db")); 
                    labelMaxNum.Text = Word.serving.Count.ToString(); 
                    GetLearnedCount();
                    if (Word.serving.Count() == Word.LearnedCount) buttonGet.Visible = true;
                }
                catch (Exception E) { MessageBox.Show(E.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            buttonTest.Enabled = buttonGet.Visible ? false : true;
        }

        private void buttonDictionary_Click(object sender, EventArgs e)
        {
            Dictionary dict = new Dictionary();
            dict.ShowDialog();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            labelMaxNum.Text = Word.GetServing().ToString();
            labelNum.Text = "0";
            buttonGet.Visible = false;
        }

        private void buttonGet_VisibleChanged(object sender, EventArgs e)
        {
            buttonTest.Enabled = buttonGet.Visible ? false : true;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            Test tst = new Test();
            tst.ShowDialog();
            labelNum.Text = Word.LearnedCount.ToString();
            if (Word.LearnedCount == Word.serving.Count()) buttonGet.Visible = true;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tj " + Settings.version + Environment.NewLine + "by Nikita Yanenko", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}