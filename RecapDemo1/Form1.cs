using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Button button = new Button();*/ //Buton Nesnesi oluşturulmuş oldu
            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;

            for (int i = 0; i<buttons.GetUpperBound(0); i++) //sıfırıncı boyutun en buyuk alabileceği değer
            {
                for (int j=0; j<buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button(); // buttonu yenile
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;

                    if((i+j)%2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i,j]);
                }
                //satırlar  bitti
                top += 50;//ikinci satıra geçtiğinde 50 arttır. 
                left = 0;
            }

            
        }
    }
}
