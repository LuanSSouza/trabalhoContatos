using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoContatos.Controllers;
using TrabalhoContatos.Models;

namespace TrabalhoContatos
{
    public partial class GUI : Form
    {
        private Contatos contatos = new Contatos();
        public GUI()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var contato = this.contatos.pesquisar(new Contato(txtEmail.Text));

            if (contatos.pesquisar(new Contato(txtEmail.Text)) != null) {
                txtNome.Text = contato.Nome;
                txtFone.Text = contato.Fone;
            }
            else
                MessageBox.Show("Nenhum item encontrado!");

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtNome.Text = "";
            txtFone.Text = "";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "") MessageBox.Show("Digite o e-mail");
            else {
                if (contatos.pesquisar(new Contato(txtEmail.Text)) == null)
                    this.contatos.incluir(new Contato(txtEmail.Text, txtNome.Text, txtFone.Text));
                else
                    this.contatos.alterar(new Contato(txtEmail.Text, txtNome.Text, txtFone.Text));
                txtEmail.Text = "";
                txtNome.Text = "";
                txtFone.Text = "";
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "") MessageBox.Show("Digite o e-mail");
            else if (this.contatos.excluir(new Contato(txtEmail.Text))){
                MessageBox.Show("Excluído com Sucesso!");
                txtEmail.Text = "";
                txtNome.Text = "";
                txtFone.Text = "";
            }
            else
                MessageBox.Show("Falha ao excluir!");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lbxListar.Items.Clear();
            this.contatos.ListaContatos.ForEach(i => lbxListar.Items.Add(i.Email + " | " + i.Nome + " | " + i.Fone));
        }
    }
}
