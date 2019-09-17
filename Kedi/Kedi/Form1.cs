using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kedi
{
    public partial class Form1 : Form
    {
        private string Instructions;
        private int Input1;
        private int Input2;
        private int Answer;

        public Form1()
        {
            InitializeComponent();
        }

        private void AdditionBt_Click(object sender, EventArgs e)
        {
            Instructions = "+";
        }

        private void SubtractBt_Click(object sender, EventArgs e)
        {
            Instructions = "-";
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            Instructions = "*";
        }

        private void DivideBtn_Click(object sender, EventArgs e)

        {
            Instructions = "/";
        } 

        private void AnswerBtn_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            string IN1 = InputTxBx1.Text;
            string IN2 = InputTxBx2.Text;

            int.TryParse(IN1, out Input1);
            int.TryParse(IN2, out Input2);
             
            if (Instructions.Equals("+"))
            {
                Answer = Input1 + Input2;
            }
            else if (Instructions.Equals("-"))
            {
                Answer = Input1 - Input2;
            }
            else if (Instructions.Equals("*"))
            {
                Answer = Input1 * Input2;
            }
            else if (Instructions.Equals("/"))
            {
                Answer = Input1 / Input2; 
            }
            AnswertxBx.Text = Answer.ToString();
        }

        private void test()
        {

        }

    }
}
