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
                data = txtData.Text,
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
                MessageBox.Show("Salvo com sucesso!!!");
                txtData.Clear();
                txtNome.Clear();
                txtIdade.Clear();

            }
            catch(Exception error)
            { 
              
                    MessageBox.Show("NÃO FOI SALVO" + error);
                
            }
           
        }
    }
}
