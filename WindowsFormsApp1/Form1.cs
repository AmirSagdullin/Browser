using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int i = 0;
        TabPage[] a = new TabPage[10];
        int[] b = new int[] { };
        string[] c = new string[] { };
        String[] history = new string[] { };
        public Form1()
        {
            InitializeComponent();
            WebBrowser web = new WebBrowser();
            web.Visible = true;
            web.Dock = DockStyle.Fill;
            web.DocumentCompleted += web_DocummentCompleted;
            tabControl1.TabPages.Add("Новая вкладка");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            i += 1;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text != null)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripTextBox1.Text);
            }
            c.Append(tabControl1.SelectedTab.Text);

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            WebBrowser web = new WebBrowser();
            web.Visible = true;
            web.Dock = DockStyle.Fill;
            web.DocumentCompleted += web_DocummentCompleted;
            tabControl1.TabPages.Add("Новая вкладка");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            i += 1;
            c.Append(tabControl1.SelectedTab.Text);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
                try
                {
                    ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
                }
                catch
                {

                }
            c.Append(tabControl1.SelectedTab.Text);


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward();
            }
            catch
            {

            }
            c.Append(tabControl1.SelectedTab.Text);

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            try
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Refresh();

            }
            catch
            {

            }
        }
        void web_DocummentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 1)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                i -= 1;
            }
        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripTextBox1.Text);
                c.Append(tabControl1.SelectedTab.Text);

            }

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void добаувитьВЗакладкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a.Append(tabControl1.SelectedTab);
            listBox1.Items.Add(tabControl1.SelectedTab.Text);

        }

        private void закладкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                tabControl1.TabPages.Add(a[listBox1.SelectedIndex]);
                c.Append(tabControl1.SelectedTab.Text);

            }
        }

        private void сохранитьИсториюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void удалитьИсториюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            history = new string[] { };
        }

        private void историяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            for (int i = 0; i < history.Length; i++)
            {
                f2.listView1.Items.Add(history[i]);
            }
            f2.Show();
        }

        private void Сохранить_страницу_Click(object sender, EventArgs e)
        {
        }
    }
}
