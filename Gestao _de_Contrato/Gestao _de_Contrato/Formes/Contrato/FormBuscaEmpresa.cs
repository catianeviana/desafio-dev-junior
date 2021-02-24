using Gestao__de_Contrato.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao__de_Contrato.Formes.Contrato
{
    public partial class FormBuscaEmpresa : Form
    {
        public IndexContratoForm Contrato { get; set; }
        public Button BotaoClicado { get; set; }
        public FormBuscaEmpresa()
        {
            InitializeComponent();
            btnAdicionar.Enabled = false;
            CarregaTabelaEmpresa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void drigEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = Convert.ToInt32(drigEmpresas.CurrentRow.Cells["CÓDIGO"].Value);

            btnAdicionar.Enabled = linha > 0 ? true : false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(drigEmpresas.CurrentRow.Cells["CÓDIGO"].Value);
            Empresa empresa = new Empresa();


            if (id > 0)
            {
                empresa = empresa.BuscarPorId(id);
                Contrato.CarregarEmpresa(empresa, BotaoClicado);
                Contrato.Id = 1;
                this.Close();

            }
            else
            {
                MessageBox.Show("Algo deu errado tente novamente");
            }
        }

        private void CarregaTabelaEmpresa()
        {
            IList<Empresa> empresa = new Empresa().ListarEmpresas();
            if (empresa == null)
                MessageBox.Show("Registro não encontrado!!");
            // Definindo variável de tabela
            DataTable dt = new DataTable("temp");
            // Definindo os campos da Tabela           
            dt.Columns.Add("CÓDIGO", typeof(int));
            dt.Columns.Add("NOME", typeof(string));
            dt.Columns.Add("CNPJ", typeof(string));
            dt.Columns.Add("ENDEREÇO", typeof(string));
            dt.Columns.Add("TELEFONE", typeof(string));

            foreach (var item in empresa)
            {
                dt.Rows.Add(item.EmpresaId, item.NomeRazaoSocial, item.Cnpj, item.Endereco, item.Telefone);
            }
            // Incluindo a tabela no DataSet           
            drigEmpresas.DataSource = dt;
            drigEmpresas.ReadOnly = true;
            // alterar a largura
            foreach (DataGridViewColumn column in drigEmpresas.Columns)
            {
                if (column.DataPropertyName == "CÓDIGO")
                {
                    //tamanho fixo da primeira coluna                    
                    column.Width = 50;
                }
                else
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }

        }
        private void CarregaTabelaEmpresa_Por_Like(IList<Empresa> empresa)
        {           
            if (empresa == null)
                MessageBox.Show("Registro não encontrado!!");
            // Definindo variável de tabela
            DataTable dt = new DataTable("temp");
            // Definindo os campos da Tabela           
            dt.Columns.Add("CÓDIGO", typeof(int));
            dt.Columns.Add("NOME", typeof(string));
            dt.Columns.Add("CNPJ", typeof(string));
            dt.Columns.Add("ENDEREÇO", typeof(string));
            dt.Columns.Add("TELEFONE", typeof(string));

            foreach (var item in empresa)
            {
                dt.Rows.Add(item.EmpresaId, item.NomeRazaoSocial, item.Cnpj, item.Endereco, item.Telefone);
            }
            // Incluindo a tabela no DataSet           
            drigEmpresas.DataSource = dt;
            drigEmpresas.ReadOnly = true;
            // alterar a largura
            foreach (DataGridViewColumn column in drigEmpresas.Columns)
            {
                if (column.DataPropertyName == "CÓDIGO")
                {
                    //tamanho fixo da primeira coluna                    
                    column.Width = 50;
                }
                else
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
                        
            if (txtRazao.Text == "")
                CarregaTabelaEmpresa();
            int i = 0;
            string s = txtRazao.Text;
            bool resultado = int.TryParse(s, out i);           
            Empresa empresa = new Empresa();
            
            if (resultado==true)
            {             
                empresa.Cnpj = s;
                empresa.NomeRazaoSocial = "";
               CarregaTabelaEmpresa_Por_Like(empresa.Filtrar(empresa));
            }
            else
            {
                empresa.Cnpj = "";
                empresa.NomeRazaoSocial = s;
               CarregaTabelaEmpresa_Por_Like(empresa.Filtrar(empresa));
            }
        }
    }
}
