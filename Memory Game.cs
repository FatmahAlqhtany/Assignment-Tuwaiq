using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Random ran = new Random();
        List<String> num = new List<String>()
        {
            "one","one","Two","Two","Three","Three","Four","Four",
            "Five","Five","Six","Six","Seven","Seven","Eight","Eight"

        };

        Label frist, second;
        public Form1()
        {
            InitializeComponent();
            assigThenumber();
           
        }
        private void assigThenumber()
        {
            if (frist != null && second != null) return;
            Label label;
            int Reandom;
            for (int i = 0; i<tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];
                else continue;

                Reandom = ran.Next(0, num.Count);
                label.Text = num[Reandom];
                num.RemoveAt(Reandom);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label click = sender as Label;
            if (click == null) return;
            if (click.ForeColor == Color.Black) return;
            if(frist == null)
            {
                frist = click;
                frist.ForeColor = Color.Black;
                return;
            }
            second = click;
            second.ForeColor = Color.Black;
            win();
            if (frist.Text == second.Text)
            {
                frist = null;
                second = null;
            }
           else timer1.Start();
        }
        private void win()
        {
            Label label;
            for(int i = 0; i<tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;
                if (label != null && label.ForeColor == label.BackColor)
                {
                    return;
                }
             
            }
            MessageBox.Show("You Win");
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            frist.ForeColor = frist.BackColor;
            second.ForeColor = second.BackColor;

            frist = null;
            second = null;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
