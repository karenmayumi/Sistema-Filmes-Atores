using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Filmes_Atores.Entidades
{
    public class AtorEntidade
    {
        public int Id;
        public string Nome;
        public string NomeArtistico;
        public int Idade;
        public string Genero;
        public object[] Linha()
        {
            return new object[] { Id, Nome, NomeArtistico, Idade, Genero };
        }
    }
}
