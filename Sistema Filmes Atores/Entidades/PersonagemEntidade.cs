using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Filmes_Atores.Entidades
{
    public class PersonagemEntidade
    {
        public int personagemID { get; set; }
        public int filmeID { get; set; }
        public int atorID { get; set; }
        public string tituloFilme{ get; set; }
        public string nomeAtor{ get; set; }
        public string Nome { get; set; }
        public string Papel { get; set; }
        public object[] Linha()
        {
            return new object[] { personagemID, filmeID, atorID, Nome, Papel };
        }
        public object[] LinhaLegivel()
        {
            return new object[] { personagemID, Nome, Papel, tituloFilme, nomeAtor };
        }
        public object[] LinhaParaPersonagemAddEdit()
        {
            return new object[] { personagemID, Nome, Papel, nomeAtor , atorID };
        }
    }
}
