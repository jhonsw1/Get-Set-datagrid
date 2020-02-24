using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaGenerica
{
    public partial class Form1 : Form
    {
        Cliente clientes = new Cliente();
        List<Cliente> listarClientes = new List<Cliente>();
        public Form1()
        {
            InitializeComponent();
            carregaTabela();

        }
        public void salvarCli()
        {
            Cliente clientes = new Cliente()
            {
                data = Convert.ToDateTime(txtData.Text),
                nome = txtNome.Text,
                idade = int.Parse(txtIdade.Text)

            };

            listarClientes.Add(clientes);
        }
        public void carregaTabela()
        {
            var data = from cli in listarClientes
                       select new
                       {
                           Data_Registro = cli.data,
                           Nome_Cliente = cli.nome,
                           Idade_Cliente = cli.idade
                       };
            gridClientes.DataSource = data.ToList();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                salvarCli();
                carregaTabela();
                carregarCmbox();
                MessageBox.Show("Salvo com sucesso!!!");
                txtData.Clear();
                txtNome.Clear();
                txtIdade.Clear();

            }
            catch (Exception error)
            {

                MessageBox.Show("NÃO FOI SALVO" + error);

            }

        }
        public void carregarCmbox()
        {
            cmbExcluir.Items.Clear();
            foreach (var item in listarClientes)
            {
                cmbExcluir.Items.Add(item.nome);
            }

        }
        public void removerDadosGrid()
        {
            var excluir = listarClientes.Where(a => a.nome.Equals(cmbExcluir.Text)).FirstOrDefault();
            listarClientes.Remove(excluir);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            removerDadosGrid();
            carregaTabela();
            carregarCmbox();
            ToString();
        }
        public void alterarDados()
        {
            var editar = listarClientes.Where(a => a.nome.Equals(cmbExcluir.Text)).FirstOrDefault();
            if (editar.nome == cmbExcluir.Text)
            {
                txtData.Text = Convert.ToString(editar.data);
                txtNome.Text = editar.nome;
                txtIdade.Text = Convert.ToString(editar.idade);
                listarClientes.Remove(editar);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarDados();
            ToString();
            carregarCmbox();
        }
        public override string ToString()
        {
            return cmbExcluir.Text = "[Selecione]";
        }
    }
}
