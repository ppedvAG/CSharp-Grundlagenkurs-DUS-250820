using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M09_Demo_WinForms
{
    public partial class Form1 : Form
    {
        /*
 * ÜBUNG:
 * Das Spiel soll nach jeder Runde auch neu gestartet werden können.
 * Anzahl der Gewinne von jedem Spieler wird nach jeder Runde ausgegeben.         
 */
        // types

        // fields
        int counter = 0;

        // props

        // ctor
        public Form1()
        {
            InitializeComponent();
            btnNewGame.Enabled = false;
        }

        // methods
        void CountSteps(Button clickedBtn)
        {
            string btnText = clickedBtn.Text;

            if (btnText == "")
            {
                if (counter % 2 == 0)
                {
                    clickedBtn.Text = "X";
                    CheckWinner("X");
                }
                else
                {
                    clickedBtn.Text = "O";
                    CheckWinner("O");
                }
                counter++;
            }
            else
                MessageBox.Show("Bist du blind!? Klick wo anders!");
        }

        void CheckWinner(string x_or_o)
        {
            if (button1.Text == x_or_o && button2.Text == x_or_o && button3.Text == x_or_o)
            {
                GiveWinner(x_or_o);
            }
            else if (button4.Text == x_or_o && button5.Text == x_or_o && button6.Text == x_or_o)
            {
                GiveWinner(x_or_o);
            }
            else
          if (button7.Text == x_or_o && button8.Text == x_or_o && button9.Text == x_or_o)
            {
                GiveWinner(x_or_o);
            }
            else if (button1.Text == x_or_o && button4.Text == x_or_o && button7.Text == x_or_o)
            {
                GiveWinner(x_or_o);
            }
            else if (button2.Text == x_or_o && button5.Text == x_or_o && button8.Text == x_or_o)
            {
                GiveWinner(x_or_o);
            }
            else if (button3.Text == x_or_o && button6.Text == x_or_o && button9.Text == x_or_o)
            {
                GiveWinner(x_or_o);
            }
            else if (button1.Text == x_or_o && button5.Text == x_or_o && button9.Text == x_or_o)
            {
                GiveWinner(x_or_o);
            }
            else if (button3.Text == x_or_o && button5.Text == x_or_o && button7.Text == x_or_o)
            {
                GiveWinner(x_or_o);
            }
            else if (counter == 9)
            {
                MessageBox.Show("Unentschieden, macht lieber Sport!");
                // Environment.Exit(0); // oder:
                Close(); // schließt das aktuelle Formular
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            // CountSteps((Button)sender); // oder:
            CountSteps(sender as Button);
        }

        private void GiveWinner(string x_or_o)
        {
            MessageBox.Show($"{x_or_o} hat gewonnen");
            label3.Text += " " + x_or_o;
            btnNewGame.Enabled = true;
        }
       
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            counter = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            label3.Text = "Gewinner: ";
            btnNewGame.Enabled = false;
        }
    }
}
