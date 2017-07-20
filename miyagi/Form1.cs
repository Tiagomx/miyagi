using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miyagi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {  
            
         if (keyData == (Keys.Space) || keyData == (Keys.Enter))
         {
            SendKeys.Send("{TAB}");
         }

           return base.ProcessCmdKey(ref msg, keyData);
        }     

    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void somaResultadoJuri()
        {
            var textNota1 = Convert.ToDouble(label2.Text);

            var textNota2 = Convert.ToDouble(label3.Text);

            var textNota3 = Convert.ToDouble(label4.Text);

            var textNota4 = Convert.ToDouble(label5.Text);

            var textNota5 = Convert.ToDouble(label6.Text);

            var notasReunidas = new double[] { textNota1, textNota2, textNota3, textNota4, textNota5 };

            var PrimeiraNotaMaior = notasReunidas.OrderByDescending(x => x).Distinct().First();
            var SegundaNotaMaior = notasReunidas.OrderByDescending(x => x).Distinct().Skip(1).FirstOrDefault();

            var notaUm = notasReunidas.OrderByDescending(x => x).Distinct().Skip(2).FirstOrDefault();
            var notaDois = notasReunidas.OrderByDescending(x => x).Distinct().Skip(3).FirstOrDefault();
            var notaTres = notasReunidas.OrderByDescending(x => x).Distinct().Skip(4).FirstOrDefault();

            var bmp = new Bitmap(miyagi.Properties.Resources.X);

            Image imagemLabel = bmp;

            var soma = notaUm + notaDois + notaTres;

            var resultado = soma / 3;

            var lbResultado = Convert.ToDouble(label1.Text);

            lbResultado = Math.Round(resultado, 1);

            label1.Text = lbResultado.ToString();

            if (label2.Text == PrimeiraNotaMaior.ToString() || label2.Text == SegundaNotaMaior.ToString())
            {
                //Font FonteAlterada = new Font(label2.Font, FontStyle.Bold | FontStyle.Strikeout);

                label2.Image = imagemLabel;
            }

            if (label3.Text == PrimeiraNotaMaior.ToString() || label3.Text == SegundaNotaMaior.ToString())
            {
                //Font FonteAlterada = new Font(label3.Font, FontStyle.Bold | FontStyle.Strikeout);

                label3.Image = imagemLabel;
            }

            if (label4.Text == PrimeiraNotaMaior.ToString() || label4.Text == SegundaNotaMaior.ToString())
            {
               // Font FonteAlterada = new Font(label4.Font, FontStyle.Bold | FontStyle.Strikeout);

                label4.Image = imagemLabel;
            }

            if (label5.Text == PrimeiraNotaMaior.ToString() || label5.Text == SegundaNotaMaior.ToString())
            {
               // Font FonteAlterada = new Font(label5.Font, FontStyle.Bold | FontStyle.Strikeout);

                label5.Image = imagemLabel;
            }

            if (label6.Text == PrimeiraNotaMaior.ToString() || label6.Text == SegundaNotaMaior.ToString())
            {
                //Font FonteAlterada = new Font(label6.Font, FontStyle.Bold | FontStyle.Strikeout);

                label6.Image = imagemLabel;
            }
        }

        private void maskedTextBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == (Keys.Enter))
            {

                label2.Text = maskedTextBox1.Text;
                //somaResultadoJuri();
                maskedTextBox1.Text = string.Empty;
            }
        }

        private void maskedTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == (Keys.Enter))
            {
                label3.Text = maskedTextBox2.Text;
               // somaResultadoJuri();
                maskedTextBox2.Text = string.Empty;
            }
        }

        private void maskedTextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == (Keys.Enter))
            {
                label4.Text = maskedTextBox3.Text;
               // somaResultadoJuri();
                maskedTextBox3.Text = string.Empty;
            }
        }

        private void maskedTextBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == (Keys.Enter))
            {
                label5.Text = maskedTextBox4.Text;
               // somaResultadoJuri();
                maskedTextBox4.Text = string.Empty;
            }
        }

        private void maskedTextBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == (Keys.Enter))
            {
                label6.Text = maskedTextBox5.Text;
                somaResultadoJuri();
                maskedTextBox5.Text = string.Empty;
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == '.' || e.KeyChar == ',')
            //{

            //    //troca o . pela virgula
            //    e.KeyChar = ',';

            //    //Verifica se já existe alguma vírgula na string
            //    if (maskedTextBox1.Text.Contains(","))
            //    {
            //        e.Handled = true; // Caso exista, aborte 
            //    }
            //    else
            //    {
            //        MessageBox.Show("este campo aceita somente uma virgula");
            //    }
            //}

            ////aceita apenas números, tecla backspace.
            //else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            //{
            //    e.Handled = true;
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
