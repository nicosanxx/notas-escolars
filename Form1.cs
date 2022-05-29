using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace notas_escolars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_nota01.Text == "" || txt_nota02.Text == "" || txt_nota03.Text == "" || txt_nota04.Text =="")
            {
                MessageBox.Show("FAVOR PREENCHER TODAS OS CAMPOS", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                decimal nota01 = Convert.ToDecimal(txt_nota01.Text);
                decimal nota02 = Convert.ToDecimal(txt_nota02.Text);
                decimal nota03 = Convert.ToDecimal(txt_nota03.Text);
                decimal nota04 = Convert.ToDecimal(txt_nota04.Text);

                decimal media;

                //CALCULOS

                media = (nota01 + nota02 + nota03 + nota04) / 4;

                if (media >= 7) //APROVADO
                {

                    txt_result.Text = media + " APROVADO";
                    txt_result.ForeColor = Color.Blue;

                }
                else // REPROVADO
                {

                    txt_result.Text = media + " REPROVADO";

                    if (media < 7)
                    {

                       MessageBox.Show("NOTA ABAIXO DE 7 COLOCAR A NOTA DO EXAME", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        lb_exam.Enabled = true;
                        txt_exam.Enabled = true;


                    if (txt_exam.Text != "") // COLOCANDO VALOR NULO NA MEDIA PRA NAO CRASHAR
                    {

                            decimal exame = Convert.ToDecimal(txt_exam.Text);
                            decimal nova_media = media + exame;


                            if (nova_media >= 5)
                            {

                                txt_result.Text = nova_media + " APROVADO POR EXAME";


                            }
                            else
                            {

                                txt_result.Text = nova_media + " REPROVADO";

                            }






                    }






                    }

                }

                

                




            }



        }
    }
}
