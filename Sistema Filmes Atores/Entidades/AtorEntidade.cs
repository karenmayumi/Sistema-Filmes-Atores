using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Filmes_Atores.Entidades
{
    public class AtorEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeArtistico { get; set; }
        public int Idade { get; set; }
        public string Genero { get; set; }
        public object[] Linha()
        {
            return new object[] { Id, Nome, NomeArtistico, Idade, Genero };
        }public object[] LinhaParaPersonagem()
        {
            return new object[] { Id, Nome, NomeArtistico };
        }
    }
}
