using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modele.Jucatori;
using Repositories.Jucatori;
using Modele.Echipe;
using Repositories.Echipe;

namespace PSSCTema2
{
    public partial class Form1 : Form
    {
        JucatoriRepository jucatori = new JucatoriRepository();
       EchipeRepository echipe = new EchipeRepository();
        Jucatori jucatorrep=new Jucatori();
        Echipa echipa = new Echipa();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonJucator_Click(object sender, EventArgs e)
        {
            if (textBoxNume.Text.ToString() != null  || textBoxPost.Text.ToString() != null ||
                textBoxVarsta.Text.ToString() != null || textBoxNumar.Text.ToString() != null ||textBoxEchipa.Text.ToString()!=null)
            {
                Jucatori jucator = new Jucatori(textBoxNume.Text.ToString(),
                    int.Parse(textBoxVarsta.Text.ToString()), textBoxPost.Text.ToString(),
                    int.Parse(textBoxNumar.Text.ToString()), textBoxEchipa.Text.ToString());
              
                jucatori.AdaugaJucator(jucator);
                
            }

            else
                MessageBox.Show("Nu ati completat toate campurile");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonEchipa_Click(object sender, EventArgs e)
        {
            if (textBoxCampionat.Text.ToString() != null || textBoxAn.Text.ToString()!=null
                || textBoxCulori.Text.ToString()!=null || textBoxNume_echipa.Text.ToString()!=null)
          
            {
                Echipa echipa2 = new Echipa(textBoxCampionat.Text.ToString(), int.Parse(textBoxAn.Text.ToString()),
                    textBoxCulori.Text.ToString(), textBoxNume_echipa.Text.ToString());

                echipe.AdaugaEchipa(echipa2);
                MessageBox.Show("Echipa a fost adaugata");
                echipa = echipe.GasesteEchipa("abc");
            
                if (echipa != null)
                {
                    textBox1.Text = echipa.get_nume();
                    textBox3.Text = echipa.get_an_infiintare().ToString();
                    textBox2.Text = echipa.get_campionat().ToString();
                    textBox4.Text = echipa.get_nume();
                }
                else
                    MessageBox.Show("Echipa nu a fost gasita");
            }

            else
                MessageBox.Show("Nu ati completat toate campurile");
        }
    }
}
