using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind_VideoIgra
{
    public partial class Form2 : Form
    {
        int trenutno_polje;
        public Form2()
        {
            InitializeComponent();
            Load += new EventHandler(Igra_Load);
        }
        
        private void Igra_Load(object sender,System.EventArgs e)
        {
            trenutno_polje = 1;
            Random rd = new Random();

            for(int i = 0;i < 4; i++)
            {
                
                int rand = rd.Next(1,7);

                PictureBox sledeci = (PictureBox)this.Controls["PictureBox1_" +(i+1)];
                Button odredjivacBoje = (Button)this.Controls["Button" + rand];

                sledeci.BackColor = odredjivacBoje.BackColor;
            }
        } 
      
       // int skok = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox trenutno = (PictureBox)this.Controls["PictureBox" + trenutno_polje];
            trenutno.BackColor = button1.BackColor;

            trenutno_polje=trenutno_polje + 1;

           /* if(trenutno_polje / 4 == 0)
            {
               // skok = skok + 4;
                trenutno_polje = 1;
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PictureBox trenutno = (PictureBox)this.Controls["PictureBox" + trenutno_polje];
            trenutno.BackColor = button2.BackColor;

            trenutno_polje = trenutno_polje + 1;

            /*if (trenutno_polje % 4 == 0)
            {
                //skok = skok + 4;
                trenutno_polje = 1;
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PictureBox trenutno = (PictureBox)this.Controls["PictureBox" + trenutno_polje];
            trenutno.BackColor = button3.BackColor;

            trenutno_polje = trenutno_polje + 1;

           /* if (trenutno_polje % 4 == 0)
            {
                //skok = skok + 4;
                trenutno_polje = 1;
            }*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PictureBox trenutno = (PictureBox)this.Controls["PictureBox" + trenutno_polje];
            trenutno.BackColor = button4.BackColor;

            trenutno_polje = trenutno_polje + 1;

           /* if (trenutno_polje % 4 == 0)
            {
                //skok = skok + 4;
                trenutno_polje = 1;
            }*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PictureBox trenutno = (PictureBox)this.Controls["PictureBox" + trenutno_polje];
            trenutno.BackColor = button5.BackColor;

            trenutno_polje = trenutno_polje + 1;

            /*if (trenutno_polje % 4 == 0)
            {
               // skok = skok + 4;
                trenutno_polje = 1;
            }*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PictureBox trenutno = (PictureBox)this.Controls["PictureBox" + trenutno_polje];
            trenutno.BackColor = button6.BackColor;

            trenutno_polje = trenutno_polje + 1;

            /*if (trenutno_polje % 4 == 0)
            {
                //skok = skok + 4;
                trenutno_polje = 1;
            }*/
        }
    }
}
