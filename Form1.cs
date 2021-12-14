using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*|R F(*.rtf)|*.rtf";
        }
        string filename = string.Empty;
        private void saveasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, richTextBox1.Text);
            richTextBox1.SaveFile(filename, RichTextBoxStreamType.RichText);


            //{
            //    if (filename == string.Empty)
            //    {
            //        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //            filename = saveFileDialog1.FileName;
            //    }
            //    if (filename != string.Empty)
            //    {
            //        try
            //        {
            //            richTextBox1.SaveFile(filename, RichTextBoxStreamType.RichText);
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }
        
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Rich Text Format|*.rtf", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    richTextBox1.LoadFile(ofd.FileName);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            fontDialog1.ShowColor = true;
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
            richTextBox1.SelectionColor = fontDialog1.Color;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK))
                {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                this.Text = saveFileDialog1.FileName;
            }
        }

        private void fonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void CancelToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void RepeatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void AlignToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void LeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void RightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, richTextBox1.Text);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename);
            richTextBox1.Text = fileText;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                richTextBox1.ContextMenuStrip = contextMenuStrip2;
            }
        }

        private void Сopy1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void Paste1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void Cute1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void Cancel1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void Repeat1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void тестToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string find = textBox1.Text;
            if (richTextBox1.Text.Contains(find))
            {
                int i = 0;
                while (i <= richTextBox1.Text.Length - find.Length)
                {
                    i = richTextBox1.Text.IndexOf(find, i);
                    if (i < 0) break;
                    richTextBox1.SelectionStart = i;
                    richTextBox1.SelectionLength = find.Length;
                    richTextBox1.SelectionBackColor = Color.Blue;
                    i += find.Length;
                }
            }
            else
            {

                MessageBox.Show("НЕТ СОВПАДЕНИЙ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }
        }



        //private void rStripMenuItem_Click(string[] words)
        //{
        //    foreach (string word in words)
        //    {
        //        int startIndex = 0;
        //        while (startIndex < richTextBox1.TextLength)
        //        {

        //            int wordStartIndex = richTextBox1.Find(word, startIndex, RichTextBoxFinds.None);
        //            if (wordStartIndex != -1)
        //            {
        //                richTextBox1.SelectionStart = wordStartIndex;
        //                richTextBox1.SelectionLength = word.Length;
        //                richTextBox1.SelectionBackColor = Color.Yellow;
        //            }
        //            else
        //                break;
        //            startIndex += wordStartIndex + word.Length;
        //        }
        //    }
        //}
    }
   
    }

