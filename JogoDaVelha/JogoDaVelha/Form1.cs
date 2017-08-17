using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        bool VezX = true;

        public Form1(){

            InitializeComponent();
        }
        //Painel principal do jogo.
        private void Form1_Load(object sender, EventArgs e) {
            //Cria um evento ao clickar em cada botão do painel.
            button11.Click += new EventHandler(ButtonClick);
            button12.Click += new EventHandler(ButtonClick);
            button13.Click += new EventHandler(ButtonClick);
            button21.Click += new EventHandler(ButtonClick);
            button22.Click += new EventHandler(ButtonClick);
            button23.Click += new EventHandler(ButtonClick);
            button31.Click += new EventHandler(ButtonClick);
            button32.Click += new EventHandler(ButtonClick);
            button33.Click += new EventHandler(ButtonClick);
           
            //Sempre começa com o "X".
            buttonO.Enabled = false;
            
            //Faz com que ao clicar no botão não pule para o prox.
            foreach (Control item in this.Controls) { 

                if (item is Button) { //Verifica se é um botão então ele não permiti pular para o prox.
                    item.TabStop = false;
                }
            }
        }
        
        /*
        private void VerificarBotaoHabilitado(object sender, EventArgs e){
            foreach (Control item in this.Controls) {
               
                    ((Button)sender).Enabled = false;
                
            }
        }
        */

        private void ButtonClick(object sender, EventArgs e) {
            //Acessando as propriedades.
            ((Button)sender).Text = this.VezX ? "X" : "O"; //Se for a vez do "X", ele insere o X senão insere o "O".
            ((Button)sender).Enabled = false; //Assim que inserir ele desabilita o butão.
            VezX = !VezX; //Quando for a vez do "O"

            //Verifica e habilita o botão do jogador da vez.
            if (VezX) { //Se for a vez do "X".
                buttonO.Enabled = false;//Desabilita o botão "O".
                buttonX.Enabled = true;//Habilita o botão "X".
            }
            else { //Senão for a vez do "X".
                buttonO.Enabled = true; //Habilita o botão "O"
                buttonX.Enabled = false; //Desabilita o botão "X"
            }

            //Chama o metodo de verificação de vencedor.
            VerificaJogo();

        }

        //Verificação se à ganhador no jogo.
        private void VerificaJogo()
        {

            if (
                //Verifica a linha 1
                button11.Text != string.Empty && button11.Text == button12.Text && button12.Text == button13.Text ||
                //Verifica a linha 2
                button21.Text != string.Empty && button21.Text == button22.Text && button22.Text == button23.Text ||
                //Verifica a linha 3
                button31.Text != string.Empty && button31.Text == button32.Text && button32.Text == button33.Text ||

                //Verifica a coluna 1
                button11.Text != string.Empty && button11.Text == button21.Text && button21.Text == button31.Text ||
                //Verifica a coluna 2
                button12.Text != string.Empty && button12.Text == button22.Text && button22.Text == button32.Text ||
                //Verifica a coluna 3
                button13.Text != string.Empty && button13.Text == button23.Text && button23.Text == button33.Text ||

                //Verifica a diagonal principal
                button11.Text != string.Empty && button11.Text == button22.Text && button22.Text == button33.Text ||
                //Verifica a diagonal secundaria
                button13.Text != string.Empty && button13.Text == button22.Text && button22.Text == button31.Text

               )
            {
                //Informa quem é o ganhador.
                MessageBox.Show(string.Format("O ganhador da rodada é: {0}", !VezX ? "X" : "O"), "Fim da rodada!");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void Reiniciar_Click(object sender, EventArgs e)
        {

        }

        private void buttonO_Click(object sender, EventArgs e)
        {

        }

        private void TimeJogo_Click(object sender, EventArgs e)
        {

        }

    }
}
