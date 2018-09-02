using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoContatos.Models;

namespace TrabalhoContatos.Controllers
{
    class Contatos
    {
        private List<Contato> listaContatos;

        public List<Contato> ListaContatos { get { return this.listaContatos; } }

        public Contatos() {
            this.listaContatos = new List<Contato>();
        }

        public void incluir(Contato c) {
            this.listaContatos.Add(c);
        }

        public void alterar(Contato c) {
            int index = this.listaContatos.IndexOf(c);
            this.listaContatos[index] = c;
        }

        public bool excluir(Contato c) {
            return listaContatos.Remove(c);
        }

        public Contato pesquisar(Contato c) {
            return this.listaContatos.FirstOrDefault(item => item.Equals(c));
        }
    }
}
