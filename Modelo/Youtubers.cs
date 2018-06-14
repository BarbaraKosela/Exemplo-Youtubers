using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class  Youtubers
    {
        
        private int Codigo;
        private string Nome;
        private string Sobrenome;
        private string Apelido;
        private string NomeCanal;
        private int QuantidadeInscritos;
        private int Vizualizacoes;
        private int QuantidadeLikes;
        private string Descricao;
        private double Renda;
        private string Link;
        private int QuantidadeVideos;
        private string Nascionalidade;
        private string Categoria;
        private bool Anuncio;
        private bool Patrocinador;
        private int Strike;
        private string Plataforma;
        private bool Streamer;
        


        

        public int GetCodigo()
        {
            return Codigo;
            
        }

        

        public void SetNome(string nome)
        {
            if (nome.Trim().Count() < 3)
            {
                throw new Exception("O nome deve conter no mínimo 3 caracteres");
            }

            if (nome.Trim().Count() > 25)
            {
                throw new Exception("O nome deve conter no máximo 25 caracteres");
            }

            Nome = nome;
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetSobrenome(string sobrenome)
        {
            if (sobrenome.Trim().Count() < 3)
            {
                throw new Exception("O sobrenome deve conter no mínimo 3 caracteres");
            }

            if (sobrenome.Trim().Count() > 25)
            {
                throw new Exception("O sobrenome deve conter no máximo 25 caracteres");
            }

            Sobrenome = sobrenome;
        }

        public string GetSobrenome()
        {
            return Sobrenome;
        }

        public void SetApelido(string apelido)
        {
            if (apelido.Trim().Count() < 3)
            {
                throw new Exception("O apelido deve conter no mínimo 3 caracteres");
            }

            if (apelido.Trim().Count() > 25)
            {
                throw new Exception("O apelido deve conter no máximo 25 caracteres");
            }

            Apelido = apelido;
        }

        public string GetApelido()
        {
            return Apelido;
        }



        public void SetNomeCanal(string nomeCanal)
        {
            if (nomeCanal.Trim().Count() < 3)
            {
                throw new Exception("O nome do canal deve conter no mínimo 3 caracteres");
            }

            if (nomeCanal.Trim().Count() > 100)
            {
                throw new Exception("O nome do canal deve conter no máximo 100 caracteres");
            }

            NomeCanal = nomeCanal;
        }

        public string GetNomeCanal()
        {
            return NomeCanal;
        }



        public void SetQuantidadeInscritos(int quantidadeInscritos)
        {
            if (quantidadeInscritos < 1)
            {
                throw new Exception("Você não é tão infeliz de não ter nenhum inscritos");
            }

            if (quantidadeInscritos > 10000000)
            {
                throw new Exception("Você não tem capacidade de ser tão foda assim");
            }

            QuantidadeInscritos = quantidadeInscritos;
        }

        public int GetQuantidadeInscritos()
        {
            return QuantidadeInscritos;

        }

        public void SetVizualizacoes(int vizualizacoes)
        {
            if (vizualizacoes < 1)
            {
                throw new Exception("Você não é tão bosta assim, digite um número de visualização válido");
            }

            if (vizualizacoes > 100000000)
            {
                throw new Exception("Você ainda não está nesse nível");
            }

            Vizualizacoes = vizualizacoes;
        }

        public int GetVizualizacoes()
        {
            return Vizualizacoes;
        }





        public void SetQuantidadeLikes(int quantidadeLikes)
        {
            if (quantidadeLikes < 1)
            {
                throw new Exception("Relaxa, alguém no mundo deve gostar de você");
            }

            if (quantidadeLikes > 100000000)
            {
                throw new Exception("Você obviamente ainda não chegou no nível God");
            }

            QuantidadeLikes = quantidadeLikes;
        }

        public int GetQuantidadeLikes()
        {
            return QuantidadeLikes;
        }






        public void SetDescricao(string descricao)
        {
            if (descricao.Trim().Count() < 5)
            {
                throw new Exception("Seu número de caracteres para o canal deve ser maior do que 5");
            }

            if (descricao.Trim().Count() > 200)
            {
                throw new Exception("Limite de caracteres excedido, digite uma descrição válida");
            }

            Descricao = descricao;
        }

        public string GetDescricao()
        {
            return Descricao;
        }





        public void SetRenda(double renda)
        {
            if (renda < 1)
            {
                throw new Exception("A renda deve ser ao mínimo maior do que 1");
            }

            if (renda > 100000000)
            {
                throw new Exception("Você não é o Silvio Santos");
            }

            Renda = renda;
        }

        public double GetRenda()
        {
            return Renda;
        }


        public void SetLink(string link)
        {
            if (link.Trim().Count() < 5)
            {
                throw new Exception("O link deve conter ao mínimo 5 caracteres");
            }

            if (link.Trim().Count() > 200)
            {
                throw new Exception("Limite de caracteres excedido, digite um link válido");
            }

            Link = link;
        }

        public string GetLink()
        {
            return Link;
        }





        public void SetQuantidadeVideos(int quantidadeVideos)
        {
            if (quantidadeVideos < 1)
            {
                throw new Exception("Qual é, pelo menos alguma merda você deve ter feito na sua vida, digite novamente");
            }

            if (quantidadeVideos > 100000000)
            {
                throw new Exception("Caralho, você não consegue ser tão desocupado na sua vida, digite novamente");
            }

            QuantidadeVideos = quantidadeVideos;
        }

        public int GetQuantidadeVideos()
        {
            return QuantidadeVideos;
        }




        public void SetNascionalidade(string nascionalidade)
        {
            if (nascionalidade.Trim().Count() < 5)
            {
                throw new Exception("A nascionalidade deve conter ao mínimo 5 caracteres");
            }

            if (nascionalidade.Trim().Count() > 200)
            {
                throw new Exception("Limite de caracteres excedido, digite uma nascionalidade válida");
            }

            Nascionalidade = nascionalidade;
        }

        public string GetNascionalidade()
        {
            return Nascionalidade;
        }



        public void SetCategoria(string categoria)
        {
            if (categoria.Trim().Count() < 5)
            {
                throw new Exception("A nascionalidade deve conter ao mínimo 5 caracteres");
            }

            if (categoria.Trim().Count() > 70)
            {
                throw new Exception("Limite de caracteres excedido, digite uma categoria válida");
            }

            Categoria = categoria;
        }

        public string GetCategoria()
        {
            return Categoria;
        }



        public void SetAnuncio(bool anuncio)
        {
            if (anuncio == false)
            {
                throw new Exception("Selecione se é ou não monetizado");
            }

            Anuncio = anuncio;
        }

        public bool GetAnuncio()
        {
            return Anuncio;
        }


        public void SetPatrocinador(bool patrocinador)
        {
            if (patrocinador == false)
            {
                throw new Exception("Selecione uma opção de patrocinador");
            }

            Patrocinador = patrocinador;
        }

        public bool GetPatrocinador()
        {
            return Patrocinador;
        }


        public void SetStrike(int strike)
        {
            if (strike < 1)
            {
                throw new Exception("Impossível você nunca ter feito merda neste site, por favor, digite novamente");
            }

            if (strike > 3)
            {
                throw new Exception("Como você ainda existe no youtube? Impossível receber tantos strikes, digite novamente");
            }

            Strike = strike;
        }

        public int GetStrike()
        {
            return Strike;
        }


        public void SetPlataforma(string plataforma)
        {
            if (plataforma.Trim().Count() < 3)
            {
                throw new Exception("A plataforma deve conter ao mínimo 3 caracteres");
            }

            if (plataforma.Trim().Count() > 70)
            {
                throw new Exception("Limite de caracteres excedido, digite uma plataforma válida");
            }

            Plataforma = plataforma;
        }

        public string GetPlataforma()
        {
            return Plataforma;
        }

        public void SetStreamer(bool streamer)
        {
            if (streamer == false)
            {
                throw new Exception("Selecione uma opção de streamer");
            }

            Streamer = streamer;
        }

        public bool GetStreamer()
        {
            return Streamer;
        }



        
    }
}
