using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ColorDialog clr = new ColorDialog();
        FontDialog fnt = new FontDialog();
        SaveFileDialog sv = new SaveFileDialog();
        OpenFileDialog opn = new OpenFileDialog();
        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            clr.ShowDialog();
            richTextBox1.SelectionBackColor = clr.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fnt.ShowDialog();
            richTextBox1.SelectionFont = fnt.Font;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sv.Filter = "(*.pc)|*.pc";
            sv.ShowDialog();
            richTextBox1.SaveFile(sv.FileName);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opn.Filter = "(*.pc)|*.pc";
            opn.ShowDialog();
            richTextBox1.LoadFile(opn.FileName);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + Clipboard.GetText();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Koray Medya");
        }
    }
}