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
    public partial class ListaYoutubers : Form
    {
        public ListaYoutubers()
        {
            InitializeComponent();
        }

        private void btnAdicionarAluno_Click(object sender, EventArgs e)
        {
            new CadastroDeYoutubers().ShowDialog();
        }

        
        private void ListagemYoutubers()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Program.youtuber.Count(); i++)
            {
                Youtubers youtuber = Program.youtuber[i];
                dataGridView1.Rows.Add(new Object[]{


                    youtuber.GetCodigo(),
                    youtuber.GetNome(),
                    youtuber.GetNomeCanal(),
                    youtuber.GetApelido(),
                    youtuber.GetQuantidadeInscritos(),
                    youtuber.GetVizualizacoes()
                });
            }
        }

        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro para editar");
                return;
            }

            int codigo = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            new CadastroDeYoutubers(codigo).ShowDialog();
        }

        private void ListaYoutubers_Activated(object sender, EventArgs e)
        {
            ListagemYoutubers();
        }

        private void btnApagarAluno_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um dos registros para que seja possível apagar");
                return;
            }

            int codigo = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            
            for (int i = 0; i < Program.youtuber.Count(); i++)
            {
                Youtubers youtuber = Program.youtuber[i];
                if (youtuber.GetCodigo() == codigo)
                {
                    Program.youtuber.Remove(youtuber);
                    ListagemYoutubers();
                    MessageBox.Show(youtuber.GetNome() + " apagado com sucesso");
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }




    }
}
