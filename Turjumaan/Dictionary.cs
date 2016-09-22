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
using System.Media;
using System.Text.RegularExpressions;

namespace Turjumaan
{
    public partial class Dictionary : Form
    {
        void LoadProc()
        {
            dataGridView1.Rows.Clear();
            foreach (KeyValuePair<string, Word> kvp in Word.dict)
            {
                string[] row = new string[3];
                row[0] = kvp.Key;
                row[1] = kvp.Value.Ru;
                row[2] = kvp.Value.Score.ToString();
                dataGridView1.Rows.Add(row);
            }
            Image playimg = Image.FromFile("playimg.png");
            Image emptyimg = Image.FromFile("empty.png");
            Bitmap playbmp = new Bitmap(playimg);
            Bitmap emptybmp = new Bitmap(emptyimg);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewImageCell cell = (DataGridViewImageCell)dataGridView1.Rows[i].Cells[3];
                DataGridViewCell eng = (DataGridViewCell)dataGridView1.Rows[i].Cells[0];
                if (File.Exists(Word.dict[eng.Value.ToString()].Audiofile))
                    cell.Value = playbmp;
                else cell.Value = emptybmp;
            }
            dataGridView1.Sort(this.colEng, ListSortDirection.Ascending);
        }

        public Dictionary()
        {
            InitializeComponent();
        }

        private void Dictionary_Load(object sender, EventArgs e)
        {
            LoadProc();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewCell cell = (DataGridViewCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                DataGridViewCell eng = (DataGridViewCell)dataGridView1.Rows[e.RowIndex].Cells[0];
                if (cell.ValueType.ToString() == "System.Drawing.Image")
                {
                    try
                    {
                        (new SoundPlayer(Word.dict[eng.Value.ToString()].Audiofile)).Play();
                    }
                    catch (Exception)
                    { }
                }
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected == false)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                }
                contextMenu.Show(Cursor.Position);
            }
        }

        private void addWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditWord aew = new AddEditWord();
            if (aew.ShowDialog() == DialogResult.OK)
            {
                string examples = aew.textBoxExmpls.Text.Replace("\r\n", "|");
                Regex rgx = new Regex(@"\|{2,}");
                examples = rgx.Replace(examples, "|");
                rgx = new Regex(@"\|$");
                examples = rgx.Replace(examples, "");

                if (aew.labelAudio.Text != "(none)") Word.WriteNew(aew.textBoxEng.Text, aew.textBoxRu.Text, examples, aew.labelAudio.Text);
                else Word.WriteNew(aew.textBoxEng.Text, aew.textBoxRu.Text, examples, "");
                LoadProc();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Regex rgx;
            AddEditWord aew = new AddEditWord();
            DataGridViewCell selcel = dataGridView1.SelectedCells[0];
            string eng = aew.textBoxEng.Text = dataGridView1.Rows[selcel.RowIndex].Cells[0].Value.ToString();
            aew.textBoxRu.Text = Word.dict[eng].Ru;
            aew.textBoxExmpls.Text = Word.dict[eng].Examples.Replace("|", "\r\n");
            rgx = new Regex(@"\\\w+\\\w+\.wav$");
            if (rgx.Match(Word.dict[eng].Audiofile).Value.Length == 0) aew.labelAudio.Text = "(none)";
            else
                aew.labelAudio.Text = rgx.Match(Word.dict[eng].Audiofile).Value;
            aew.textBoxEng.Enabled = false;
            if (aew.ShowDialog() == DialogResult.OK)
            {
                string examples = aew.textBoxExmpls.Text.Replace("\r\n", "|");
                rgx = new Regex(@"\|{2,}");
                examples = rgx.Replace(examples, "|");
                rgx = new Regex(@"\|$");
                examples = rgx.Replace(examples, "");

                Word.dict[eng].Ru = aew.textBoxRu.Text;
                string audio = "";
                if (aew.labelAudio.Text != "(none)") { audio = aew.labelAudio.Text; Word.dict[eng].Audiofile = Settings.DataPath + audio; }
                else Word.dict[eng].Audiofile = "";
                Word.dict[eng].Examples = examples;

                Word.EditWord(Word.dict[eng], audio);
                LoadProc();                
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewCell selcel = dataGridView1.SelectedCells[0];
            string eng = dataGridView1.Rows[selcel.RowIndex].Cells[0].Value.ToString();
            if (Word.DeleteWord(Word.dict[eng])) dataGridView1.Rows.RemoveAt(selcel.RowIndex);
        }

        private void clearScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewCell selcel = dataGridView1.SelectedCells[0];
            string eng = dataGridView1.Rows[selcel.RowIndex].Cells[0].Value.ToString();

            Word.ClearScores(Word.dict[eng]);
            LoadProc();
        }

        private void dataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == 2)
            {
                e.SortResult = double.Parse(e.CellValue1.ToString()).CompareTo(double.Parse(e.CellValue2.ToString()));
                e.Handled = true;
            }
        }
    }
}