using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M10_Demo_delegates
{
    public partial class Form1 : Form
    {
        // types
        #region benutzerdefinierter Delegat
        public delegate int IntIntIntDelegate(int a, int b);
        #endregion

        // fields
        IntIntIntDelegate iiiDel;
        Func<int, int, int> iiiFuncDel;

        // ctors
        public Form1()
        {
            InitializeComponent();
        }

        // methods
        #region Methoden für Delegaten
        int Addiere(int a, int b)
        {
            MessageBox.Show($"Addiere: {a + b}");
            lblSumme.Text = $"SUMME: {a + b}";
            return a + b;
        }
        int Subtrahiere(int a, int b)
        {
            MessageBox.Show($"Subtrahiere: {a - b}");
            lblDifferenz.Text = $"DIFFERENZ: {a - b}";
            return a - b;
        }
        #endregion

        #region Einsetzen v. benutzerdef. Del.


        private void btnPlus_Click(object sender, EventArgs e)
        {
            iiiDel = new IntIntIntDelegate(Addiere);
            // lblResult.Text = iiiDel.Invoke(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
            // oder:
            lblResult.Text = iiiDel(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            iiiDel = new IntIntIntDelegate(Subtrahiere);
            lblResult.Text = iiiDel(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            iiiDel = new IntIntIntDelegate(Addiere);
            iiiDel += Subtrahiere;            
            lblResult.Text = iiiDel(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }
        #endregion

        #region Einsetzen v. Func-Delegaten
        private void btnFuncDel_Click(object sender, EventArgs e)
        {
            iiiFuncDel = Addiere;
            iiiFuncDel += Subtrahiere;
            iiiFuncDel(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            // den Delegaten clearen:
            iiiFuncDel = null;
        }
        #endregion
    }
}
