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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){
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

            foreach (Control item in this.Controls){ //Faz com que ao clicar no botão não pule para o prox.

                if (item is Button){ //Verifica se é um botão então ele não permiti pular para o prox.
                    item.TabStop = false;
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e){
            //Acessando as propriedades.
            ((Button)sender).Text = this.VezX ? "X" : "O"; //Se for a vez do "X", ele insere o X senão insere o "O".
            ((Button)sender).Enabled = false; //Assim que inserir ele desabilita o butão.
            VezX = !VezX; //Quando for a vez do "O"
           
            //Verifica e habilita o botão do jogador da vez.
            if (VezX){ //Se for a vez do "X".
                buttonO.Enabled = false;//Desabilita o botão "O".
                buttonX.Enabled = true;//Habilita o botão "X".
            }
            else{ //Senão for a vez do "X".
                buttonO.Enabled = true; //Habilita o botão "O"
                buttonX.Enabled = false; //Desabilita o botão "X"
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
