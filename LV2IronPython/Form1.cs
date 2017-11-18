using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython;
using IronPython.Hosting;
using IronPython.Runtime;
using Microsoft.Scripting.Hosting;
using Microsoft.Scripting;

namespace LV2IronPython
{
   
    public partial class Form1 : Form
    {
        ScriptEngine m_pyEngine = null;
        ScriptScope m_pyScope = null;
        public Form1()
        {
            InitializeComponent();
            //py stuff
            m_pyEngine = Python.CreateEngine();
            m_pyScope = m_pyEngine.CreateScope();
        }

        private void label3_Click(object sender, EventArgs e){}

        private void addToolStripMenuItem_Click(object sender, EventArgs e) //zbrajanje
        {
            int first = 0;
            int second = 0;
            if (Int32.TryParse(tbX2.Text, out second) && Int32.TryParse(tbX1.Text, out first))
                tbResult.Text = (first + second).ToString();
        }

        private void subToolStripMenuItem_Click(object sender, EventArgs e) //oduzimanje
        {
            int first = 0;
            int second = 0;
            if (Int32.TryParse(tbX2.Text, out second) && Int32.TryParse(tbX1.Text, out first))
                tbResult.Text = (first - second).ToString();
        }

        private void mulToolStripMenuItem_Click(object sender, EventArgs e) //mnozenje
        {
            int first = 0;
            int second = 0;
            if (Int32.TryParse(tbX2.Text, out second) && Int32.TryParse(tbX1.Text, out first))
                tbResult.Text = (first * second).ToString();
        }

        private void divToolStripMenuItem_Click(object sender, EventArgs e) //dijeljenje
        {
            int first = 0;
            int second = 0;
            if (Int32.TryParse(tbX2.Text, out second) && Int32.TryParse(tbX1.Text, out first))
                tbResult.Text = (first / second).ToString();
        }

        private void loadExtensionsToolStripMenuItem_Click(object sender, EventArgs e) //učitavanje py dodatnih operacija
        {
            openFileDialog1.ShowDialog();
            ScriptSource ss = m_pyEngine.CreateScriptSourceFromFile(openFileDialog1.FileName);
            ss.Execute(m_pyScope);
            dynamic Dodaj = m_pyScope.GetVariable("Dodaj");
            Dodaj(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) //zatvaranje prozora
        {
            if (MessageBox.Show("Do you want close this window?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }
    }
}
