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
        public Form2()
        {
            InitializeComponent();
            Load += new EventHandler(Igra_Load);
        }
        
        private void Igra_Load(object sender,System.EventArgs e)
        {
            Random rd = new Random();

            for(int i = 0;i < 4; i++)
            {
                
                int rand = rd.Next(1,7);

                PictureBox sledeci = (PictureBox)this.Controls["PictureBox1_" +(i+1)];
                Button odredjivacBoje = (Button)this.Controls["Button" + rand];

                sledeci.BackColor = odredjivacBoje.BackColor;
            }
        } 
      
        int trenutno_polje = 0;
        int trenutni_red = 0;


    }
}
