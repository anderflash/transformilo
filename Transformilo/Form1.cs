using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* =============================== Indicação do Stackoverflow ==============
public partial class Form1 : Form
{

    private const int WM_SETREDRAW = 0xB;

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

    private Dictionary<string, string> replacements = new Dictionary<string, string>();

    public Form1()
    {
        InitializeComponent();

        replacements.Add("cx", "ĉ");
        replacements.Add("ae", "æ");
        // etc...
    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {
        int prevStart = richTextBox1.SelectionStart;
        int prevLength = richTextBox1.SelectionLength;
        SendMessage(richTextBox1.Handle, WM_SETREDRAW, false, 0);

        int index;
        int start;
        foreach (KeyValuePair<string,string> pair in replacements)
        {
            start = 0;
            index = richTextBox1.Find(pair.Key, start, RichTextBoxFinds.None);
            while (index != -1)
            {
                richTextBox1.Select(index, pair.Key.Length);
                richTextBox1.SelectedText = pair.Value;
                index = richTextBox1.Find(pair.Key, ++start, RichTextBoxFinds.None);
            }
        }

        richTextBox1.Select(prevStart, prevLength);
        SendMessage(richTextBox1.Handle, WM_SETREDRAW, true, 0);
        richTextBox1.Invalidate();
    }

}

=================================================================*/


namespace Transformilo
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> replacements = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();

            replacements.Add("cx", "ĉ");
            replacements.Add("Cx", "Ĉ");
            replacements.Add("cX", "ĉ");
            replacements.Add("CX", "Ĉ");

            replacements.Add("gx", "ĝ");
            replacements.Add("Gx", "Ĝ");
            replacements.Add("gX", "ĝ");
            replacements.Add("GX", "Ĝ");

            replacements.Add("hx", "ĥ");
            replacements.Add("Hx", "Ĥ");
            replacements.Add("hX", "ĥ");
            replacements.Add("HX", "Ĥ");

            replacements.Add("jx", "ĵ");
            replacements.Add("Jx", "Ĵ");
            replacements.Add("jX", "ĵ");
            replacements.Add("JX", "Ĵ");

            replacements.Add("sx", "ŝ");
            replacements.Add("Sx", "Ŝ");
            replacements.Add("sX", "ŝ");
            replacements.Add("SX", "Ŝ");

            replacements.Add("ux", "ŭ");
            replacements.Add("Ux", "Ŭ");
            replacements.Add("uX", "ŭ");
            replacements.Add("UX", "Ŭ");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbAutoReplacements.Checked = false;

            richTextBox1.Text = richTextBox1.Text.Replace("cx", "ĉ");
            richTextBox1.Text = richTextBox1.Text.Replace("Cx", "Ĉ");
            richTextBox1.Text = richTextBox1.Text.Replace("cX", "ĉ");
            richTextBox1.Text = richTextBox1.Text.Replace("CX", "Ĉ");

            richTextBox1.Text = richTextBox1.Text.Replace("gx", "ĝ");
            richTextBox1.Text = richTextBox1.Text.Replace("Gx", "Ĝ");
            richTextBox1.Text = richTextBox1.Text.Replace("gX", "ĝ");
            richTextBox1.Text = richTextBox1.Text.Replace("GX", "Ĝ");

            richTextBox1.Text = richTextBox1.Text.Replace("hx", "ĥ");
            richTextBox1.Text = richTextBox1.Text.Replace("Hx", "Ĥ");
            richTextBox1.Text = richTextBox1.Text.Replace("hX", "ĥ");
            richTextBox1.Text = richTextBox1.Text.Replace("HX", "Ĥ");

            richTextBox1.Text = richTextBox1.Text.Replace("jx", "ĵ");
            richTextBox1.Text = richTextBox1.Text.Replace("Jx", "Ĵ");
            richTextBox1.Text = richTextBox1.Text.Replace("jX", "ĵ");
            richTextBox1.Text = richTextBox1.Text.Replace("JX", "Ĵ");

            richTextBox1.Text = richTextBox1.Text.Replace("sx", "ŝ");
            richTextBox1.Text = richTextBox1.Text.Replace("Sx", "Ŝ");
            richTextBox1.Text = richTextBox1.Text.Replace("sX", "ŝ");
            richTextBox1.Text = richTextBox1.Text.Replace("SX", "Ŝ");

            richTextBox1.Text = richTextBox1.Text.Replace("ux", "ŭ");
            richTextBox1.Text = richTextBox1.Text.Replace("Ux", "Ŭ");
            richTextBox1.Text = richTextBox1.Text.Replace("uX", "ŭ");
            richTextBox1.Text = richTextBox1.Text.Replace("UX", "Ŭ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbAutoReplacements.Checked=false;

            richTextBox1.Text = richTextBox1.Text.Replace("ĉ", "cx");
            richTextBox1.Text = richTextBox1.Text.Replace("Ĉ", "Cx");

            richTextBox1.Text = richTextBox1.Text.Replace("ĝ", "gx");
            richTextBox1.Text = richTextBox1.Text.Replace("Ĝ", "Gx");

            richTextBox1.Text = richTextBox1.Text.Replace("ĥ", "hx");
            richTextBox1.Text = richTextBox1.Text.Replace("Ĥ", "Hx");

            richTextBox1.Text = richTextBox1.Text.Replace("ĵ", "jx");
            richTextBox1.Text = richTextBox1.Text.Replace("Ĵ", "Jx");

            richTextBox1.Text = richTextBox1.Text.Replace("ŝ", "sx");
            richTextBox1.Text = richTextBox1.Text.Replace("Ŝ", "Sx");

            richTextBox1.Text = richTextBox1.Text.Replace("ŭ", "ux");
            richTextBox1.Text = richTextBox1.Text.Replace("Ŭ", "Ux");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            cbAutoReplacements.Checked = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            //Copia do editor para a memória do computador.

            Clipboard.SetText(richTextBox1.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (cbAutoReplacements.Checked)
            {
                int prevStart = richTextBox1.SelectionStart;
                int prevLength = richTextBox1.SelectionLength;
                //SendMessage(richTextBox1.Handle, WM_SETREDRAW, false, 0);

                int index;
                int start;
                foreach (KeyValuePair<string, string> pair in replacements)
                {
                    start = 0;
                    index = richTextBox1.Find(pair.Key, start, RichTextBoxFinds.MatchCase);
                    while (index != -1)
                    {
                        richTextBox1.Select(index, pair.Key.Length);
                        richTextBox1.SelectedText = pair.Value;
                        index = richTextBox1.Find(pair.Key, ++start, RichTextBoxFinds.MatchCase);
                    }
                }

                //richTextBox1.Select(prevStart, prevLength);
                //SendMessage(richTextBox1.Handle, WM_SETREDRAW, true, 0);
                richTextBox1.Invalidate();
            }


        }
    }
}
