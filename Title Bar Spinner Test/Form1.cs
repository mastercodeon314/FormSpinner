using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleCore.Cli;
namespace Title_Bar_Spinner_Test
{
    public partial class Form1 : Form
    {
        private FormSpinner spinner;
        public Form1()
        {
            InitializeComponent();

            spinner = new FormSpinner(this);
            spinner.Current = FormSpinner.Dots;
            this.comboBox1.SelectedIndex = 0;
        }

        private void spinnerCtrlBtn_Click(object sender, EventArgs e)
        {
            if (spinner.IsRunning == false)
            {
                spinner.Start();
                spinnerCtrlBtn.Text = "Stop Spinner";
            }
            else
            {
                spinner.Stop();
                spinnerCtrlBtn.Text = "Start Spinner";
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = this.comboBox1.SelectedItem as string;
            switch (selectedItem)
            {
                
                case "Dots":
                {
                    spinner.Current = FormSpinner.Dots;
                    spinner.Reset();
                    break;
                }
                case "Dots2":
                {
                    spinner.Current = FormSpinner.Dots2;
                    spinner.Reset();
                    break;
                }
                case "Dots3":
                {
                    spinner.Current = FormSpinner.Dots3;
                    spinner.Reset();
                    break;
                }
                case "Dots4":
                {
                    spinner.Current = FormSpinner.Dots4;
                    spinner.Reset();
                    break;
                }
                case "Dots5":
                {
                    spinner.Current = FormSpinner.Dots5;
                    spinner.Reset();
                    break;
                }
                case "Dots8Bit":
                {
                    spinner.Current = FormSpinner.Dots8Bit;
                    spinner.Reset();
                    break;
                }
                case "Dots9":
                {
                    spinner.Current = FormSpinner.Dots9;
                    spinner.Reset();
                    break;
                }
                case "Dots10":
                {
                    spinner.Current = FormSpinner.Dots10;
                    spinner.Reset();
                    break;
                }
                case "Dots11":
                {
                    spinner.Current = FormSpinner.Dots11;
                    spinner.Reset();
                    break;
                }
                case "Dots12":
                {
                    spinner.Current = FormSpinner.Dots12;
                    spinner.Reset();
                    break;
                }
                case "Progress7":
                {
                    spinner.Current = FormSpinner.Progress7;
                    spinner.Reset();
                    break;
                }
                case "Progress10":
                {
                    spinner.Current = FormSpinner.Progress10;
                    spinner.Reset();
                    break;
                }
                case "Line":
                {
                    spinner.Current = FormSpinner.Line;
                    spinner.Reset();
                    break;
                }
            }
        }
    }
}