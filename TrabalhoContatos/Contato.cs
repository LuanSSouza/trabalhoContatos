using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoContatos
{
    class Contato
    {
        // Variáveis
        private string email; //primaria
        private string nome;
        private string fone;

        //Getters e Setters
        public string Email {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        public string Fone
        {
            get { return this.fone; }
            set { this.fone = value; }
        }

        // Construtores
        public Contato() :this("","","") {}

        public Contato(string email) {
            this.email = email;
        }

        public Contato(string email, string nome, string fone) {
            this.email = email;
            this.nome = nome;
            this.fone = fone;
        }

        // Override Equals
        public override bool Equals(Object obj)
        {
            return this.email.Equals(((Contato)obj).email);
        }
    }
}
