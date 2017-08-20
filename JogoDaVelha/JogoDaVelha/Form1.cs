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
        //Inicia o jogo sempre com a vez do "X"
        bool VezX = true;
        //Inicialização do placar.
        int placax = 0, placao = 0;
        

        public Form1()
        {

            InitializeComponent();
        }
        //Painel principal do jogo.
        private void Form1_Load(object sender, EventArgs e)
        {
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

            //Inicialização do placar.
            PlacarX.Text = Convert.ToString(placax);
            PlacarO.Text = Convert.ToString(placao);

            //Sempre começa com o "X".
            buttonO.Enabled = false;

            //Faz com que ao clicar no botão não pule para o prox.
            foreach (Control item in this.Controls)
            {

                if (item is Button)
                { //Verifica se é um botão então ele não permiti pular para o prox.
                    item.TabStop = false;
                }
            }
        }

        //Metodo para marcação de jogadas, "X" e "O".
        private void ButtonClick(object sender, EventArgs e)
        {
            //Acessando as propriedades.
            ((Button)sender).Text = this.VezX ? "X" : "O"; //Se for a vez do "X", ele insere o X senão insere o "O".
            ((Button)sender).Enabled = false; //Assim que inserir ele desabilita o butão.
            VezX = !VezX; //Quando for a vez do "O"

            //Verifica e habilita o botão do jogador da vez.
            if (VezX)
            { //Se for a vez do "X".
                buttonO.Enabled = false;//Desabilita o botão "O".
                buttonX.Enabled = true;//Habilita o botão "X".
            }
            else
            { //Senão for a vez do "X".
                buttonO.Enabled = true; //Habilita o botão "O"
                buttonX.Enabled = false; //Desabilita o botão "X"
            }

            //Chama o metodo de verificação da partida.
            VerificaJogo();
           
        }

        //Metodo de verificação da partida.
        private void VerificaJogo()
        {
            //Verificação se à ganhador no jogo.
            if (
                //Verificação da linha 1
                button11.Text != string.Empty && button11.Text == button12.Text && button12.Text == button13.Text ||
                //Verificação da linha 2
                button21.Text != string.Empty && button21.Text == button22.Text && button22.Text == button23.Text ||
                //Verificação da linha 3
                button31.Text != string.Empty && button31.Text == button32.Text && button32.Text == button33.Text ||

                //Verificação da coluna 1
                button11.Text != string.Empty && button11.Text == button21.Text && button21.Text == button31.Text ||
                //Verificação da coluna 2
                button12.Text != string.Empty && button12.Text == button22.Text && button22.Text == button32.Text ||
                //Verificação da coluna 3
                button13.Text != string.Empty && button13.Text == button23.Text && button23.Text == button33.Text ||

                //Verificação da diagonal principal
                button11.Text != string.Empty && button11.Text == button22.Text && button22.Text == button33.Text ||
                //Verificação da diagonal secundaria
                button13.Text != string.Empty && button13.Text == button22.Text && button22.Text == button31.Text
                )
            {
                //Chama metodo de desabilita os botões.   
                DesabilitandoTodosBotoes();

                //Chama o metodo de placar.
                Placarxo();

                //Informa quem é o ganhador.
                MessageBox.Show(string.Format("O ganhador da rodada é: {0}", !VezX ? "X" : "O"));

                //Mostra o placar atualizado.
                PlacarX.Text = Convert.ToString(placax);
                PlacarO.Text = Convert.ToString(placao);

            }
            // Caso não tenha ganhador, chama o metodo de verificação de empate.
            else
            {
                //Chamada de metodo.
                VerificaEmpate();
            }

        }

        //Metodo para fazer a pontuação do placar.
        private void Placarxo() {

            /*
             A ideia aqui é verificar a vez do jogador, mais como já foi informado que houve um
             ganhador então ele pega e pontua quem fez a ultima jogada.
             
             Só lembrando que após ser informado que houve um ganhador todos os butôes de jogada
             são desabilitados e assim faz com que não haja um erro na pontuação.

            */
            // Verificação de jogada.
            if (VezX) // Se a vez de jogar for do "X"
            {
                placao += 1; // O jogador "O" vai ser pontuado
            }
            else if (!VezX) // Se a vez de jogar for do "O"
            {
                placax += 1; // O jogador "X" vai ser pontuado
            }


        }

        //Metodo para verificar um empate.
        private void VerificaEmpate()
        {
            if (
                button11.Text != string.Empty && //Se o botão 1 da linha 1 for diferente de vazio.
                button12.Text != string.Empty && //Se o botão 2 da linha 1 for diferente de vazio.
                button13.Text != string.Empty && //Se o botão 3 da linha 1 for diferente de vazio.
                button21.Text != string.Empty && //Se o botão 1 da linha 2 for diferente de vazio.
                button22.Text != string.Empty && //Se o botão 2 da linha 2 for diferente de vazio.
                button23.Text != string.Empty && //Se o botão 3 da linha 2 for diferente de vazio.
                button31.Text != string.Empty && //Se o botão 1 da linha 3 for diferente de vazio.
                button32.Text != string.Empty && //Se o botão 2 da linha 3 for diferente de vazio.
                button33.Text != string.Empty    //Se o botão 3 da linha 3 for diferente de vazio.
                )
            {
                //Informa que teve um empate na jogada.
                MessageBox.Show("Houve um empate!");
            }
        }

        //Metodo para a desabilitação dos botões.
        private void DesabilitandoTodosBotoes()
        {

            //Verifica se à botões habilitados e desabilita, evitando jogadas após uma vitoria. 
            if (button11.Enabled)
            { // Botão 1 da primeira linha.
                button11.Enabled = false;
            }
            if (button12.Enabled)
            { // Botão 2 da primeira linha.
                button12.Enabled = false;
            }
            if (button13.Enabled)
            { // Botão 3 da primeira linha.
                button13.Enabled = false;
            }
            if (button21.Enabled)
            { // Botão 1 da segunda linha.
                button21.Enabled = false;
            }
            if (button22.Enabled)
            { //Botão 2 da segunda linha.
                button22.Enabled = false;
            }
            if (button23.Enabled)
            { //Botão 3 da segunda linha.
                button23.Enabled = false;
            }
            if (button31.Enabled)
            { // Botão 1 da terceira linha.
                button31.Enabled = false;
            }
            if (button32.Enabled)
            { // Botão 2 da terceira linha.
                button32.Enabled = false;
            }
            if (button33.Enabled)
            { // Botão 3 da terceira linha.
                button33.Enabled = false;
            }
        }

        //Metodo de reiniciar o jogo.
        private void ReiniciarJogo()
        {
            //Vai verificar no painel tudo que for botão
            foreach (Control item in this.Controls)
            {
                //Se o item for botão então ele atribui os valores para cada botão.
                if (item is Button)
                {

                    item.Enabled = true;// Habilita os botões novamente
                    item.Text = String.Empty;// Todos os botões ficam vazios.
                    buttonX.Text = "X";// Atribiu o nome do botão "X".
                    buttonO.Text = "O";// Atribui o nome do botão "O".

                    // Verifica quem fez a ultima jogada antes de reiniciar o jogo.
                    if (!VezX)// "!" Faz a negação da VezX, então se não for a vez do "x".
                    {
                        buttonX.Enabled = false;// Caso não for a vez do "X" ele desabilita.
                    }
                    else// Senão ele habilita o botão do "X"
                    {
                        buttonO.Enabled = false;// Caso for a vez do "X" ele desabilita o "O".
                    }
                    Reiniciar.Text = "REINICIAR";//Botão de Reiniciar recebe seu devido nome.

                }
            }
        }
        
        //Metodo de ação ao clicar no botão reiniciar.
        private void Reiniciar_Click(object sender, EventArgs e)
        {
            //Chama o metodo de reiniciar o jogo.
            ReiniciarJogo();
        }

        //Metodo de ação ao clicar no link "Marcus Viana".
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Contato com o desenvolvedor do jogo.
            System.Diagnostics.Process.Start("https://github.com/mvsviana");
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

        private void buttonO_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void TimeJogo_Click(object sender, EventArgs e)
        {

        }

        private void tempojogo_Tick(object sender, EventArgs e)
        {
         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
