using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BodeOfWarServer;

namespace piBodeWar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            lstPartidas.Items.Clear();
            string strPartidas = Jogo.ListarPartidas("T");
            string[] arrPartidas = strPartidas.Split('\n');
            // partidas.Replace();

            for(int i = 0; i < arrPartidas.Length; i++)
            {
                lstPartidas.Items.Add(arrPartidas[i]);

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstJogadores_Click(object sender, EventArgs e)
        {
          
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string senha = txtSenha.Text;
            string status = Jogo.CriarPartida(nome, senha);

            if(status.Length <= 4)
            {
                status = "Partida criada com sucesso!";
            }

            txtStatus.Text = status;

        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            lstJogadores.Items.Clear();

            string idPartida = lstPartidas.SelectedItem.ToString();
            string[] arrPartida = idPartida.Split(',');

            idPartida = arrPartida[0];

            string strJogadores = Jogo.ListarJogadores(Int32.Parse(idPartida));

            string[] arrJogadores = strJogadores.Split('\n');


            for(int i = 0; i < arrJogadores.Length; i++)
            {
                lstJogadores.Items.Add(arrJogadores[i]);
            }
        }
    }
}
