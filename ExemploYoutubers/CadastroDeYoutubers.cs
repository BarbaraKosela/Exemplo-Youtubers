using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploYoutubers
{
    public partial class CadastroDeYoutubers : Form
    {
        private Youtubers youtuber;
        private int codigo;
        public CadastroDeYoutubers()
        {
            InitializeComponent();
            this.youtuber = youtuber;
        }

        public CadastroDeYoutubers(int codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            for (int i = 0; i < Program.youtuber.Count(); i++)
            {
                Youtubers youtuber = Program.youtuber[i];
                if (youtuber.GetCodigo() == codigo)
                {
                    
                    txtNome.Text = youtuber.GetNome();
                    txtSobrenome.Text = youtuber.GetSobrenome();
                    txtApelido.Text = youtuber.GetApelido();
                    txtNomeCanal.Text = youtuber.GetNomeCanal();
                    txtQuantidadeInscritos.Text = Convert.ToString(youtuber.GetQuantidadeInscritos());
                    txtVisualizacoes.Text = Convert.ToString(youtuber.GetVizualizacoes());
                    txtQuantidadeLikes.Text = Convert.ToString(youtuber.GetQuantidadeLikes());
                    txtDescricao.Text = youtuber.GetDescricao();
                    txtRenda.Text = Convert.ToString(youtuber.GetRenda());
                    txtLinkCanal.Text = youtuber.GetLink();
                    txtQuantidadeVideos.Text = Convert.ToString(youtuber.GetQuantidadeVideos());
                    txtNacionalidade.Text = youtuber.GetNascionalidade();
                    txtCategoria.Text = youtuber.GetCategoria();
                    txtStrikes.Text = Convert.ToString(youtuber.GetStrike());
                    txtPlataforma.Text = youtuber.GetPlataforma();
                    this.youtuber = youtuber;
                     
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool novoYoutuber = youtuber == null;
                if (youtuber == null)
                {
                    youtuber = new Youtubers();
                }


                youtuber.SetNome(txtNome.Text);
                youtuber.SetSobrenome(txtSobrenome.Text);
                youtuber.SetApelido(txtApelido.Text);
                youtuber.SetNomeCanal(txtNomeCanal.Text);
                youtuber.SetQuantidadeInscritos(Convert.ToInt32(txtQuantidadeInscritos.Text));
                youtuber.SetVizualizacoes(Convert.ToInt32(txtVisualizacoes.Text));
                youtuber.SetQuantidadeLikes(Convert.ToInt32(txtQuantidadeLikes.Text));
                youtuber.SetDescricao(txtDescricao.Text);
                youtuber.SetRenda(Convert.ToDouble(txtRenda.Text));
                youtuber.SetLink(txtLinkCanal.Text);
                youtuber.SetQuantidadeVideos(Convert.ToInt32(txtQuantidadeVideos.Text));
                youtuber.SetNascionalidade(txtNacionalidade.Text);
                youtuber.SetCategoria(txtCategoria.Text);
                youtuber.SetStrike(Convert.ToInt32(txtStrikes.Text));
                youtuber.SetPlataforma(txtPlataforma.Text);

                if (novoYoutuber)
                {
                    Program.youtuber.Add(youtuber);
                    MessageBox.Show("Cadastro de youtuber realizado com sucesso! Bem-vindo ao Youtube!");

                }

                else
                {
                    for (int i = 0; i < Program.youtuber.Count(); i++)
                    {
                        Youtubers youtubers = Program.youtuber[i];
                        if (youtuber.GetCodigo() == youtubers.GetCodigo())
                        {
                            Program.youtuber[i] = youtuber;
                            MessageBox.Show("Youtuber alterado com sucesso");
                            return;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            

                
            

                
                


            

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        }

        

}
  
