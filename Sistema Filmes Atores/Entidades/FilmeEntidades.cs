using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Filmes_Atores.Entidades
{
    public class FilmeEntidades
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public int Duracao { get; set; }
        public string IdadeIndicada { get; set; }
        public string Sinopse { get; set; }
        public string Atores { get; set; }
        public object[] Linha()
        {
            return new object[] { Id, Titulo, Categoria, Duracao, IdadeIndicada, Sinopse, Atores};
        }
    }
}
