using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestao__de_Contrato.Models;

namespace Gestao__de_Contrato.Formes.Corporacao
{
    public partial class Index : Form
    {

        public Index()
        {
            InitializeComponent();
            this.grouplista.Visible = false;
            btnSalvar.Enabled = txtEndereco.Text == "" ? false : true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }
        #region Funções do sistema
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ModificarBotoes(sender);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void Index_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.button2, "Busque por CNPJ ou Razão social, se esses campos estiverem vazios listará todos os cadastrados");

        }      

        private void txtRazao_TextChanged(object sender, EventArgs e)
        {
            VailidarCampos();
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = !(string.IsNullOrWhiteSpace(txtEndereco.Text));

        }

        private void maskCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskCNPJ.Enabled = !(string.IsNullOrWhiteSpace(txtRazao.Text));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ModificarBotoes(sender);

        }      

        private void drigEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = Convert.ToInt32(drigEmpresas.CurrentRow.Cells["CÓDIGO"].Value);
            if (linha > 0)
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            ModificarBotoes(sender);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ModificarBotoes(sender);
            }
            catch (Exception)
            {

                MessageBox.Show("Comando não reconhecido");
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(drigEmpresas.CurrentRow.Cells["CÓDIGO"].Value);
            Empresa empresa = new Empresa();
            var result = empresa.BuscarPorId(id);
            if (MessageBox.Show("Excluir Empresa " + result.NomeRazaoSocial + "-" + result.Cnpj, "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                empresa.Excluir(id);
                CarregaTabelaEmpresa(empresa.ListarEmpresas());
            }           
           
        }
        #endregion

        #region Métodos Alternativos
        //Bloqueia o boão de salvar se os campos RAZAO,CNPJ e endereço estiverem Como String.Empty (Vazios)
        private void VailidarCampos()
        {
            btnSalvar.Enabled = !(string.IsNullOrWhiteSpace(txtRazao.Text));
            btnSalvar.Enabled = !(string.IsNullOrWhiteSpace(maskCNPJ.Text.Replace("  ,   ,   /    -", "")));

        }
        //Alternar texto dos botões para realizar funcões distintas e controlar os eventos
        private void ModificarBotoes(object sender)
        {
            Empresa empresa = new Empresa();
            Button btn = sender as Button;
            string nome = txtRazao.Text;
            string cnpj = maskCNPJ.Text.Replace(",", "").Replace("/", "").Replace("-", "").Trim();
            string endereco = txtEndereco.Text;
            string telefone = maskTelefone.Text.Replace("(", "").Replace(" ","").Replace(")", "").Replace("-", "").Trim();
            int id = 0;
            
            switch (btn.Text)
            {
                case "Editar":

                    id = Convert.ToInt32(drigEmpresas.CurrentRow.Cells["CÓDIGO"].Value);
                    empresa = empresa.BuscarPorId(id);

                    txtRazao.Text = empresa.NomeRazaoSocial;
                    txtEndereco.Text = empresa.Endereco;
                    maskCNPJ.Text = empresa.Cnpj;
                    maskTelefone.Text = empresa.Telefone;
                    btnSalvar.Text = "Atualizar";
                    button2.Text = "Cancelar";

                    break;
                case "Salvar":

                    if (nome != "" && cnpj != "" && endereco != "")
                    {
                        empresa = new Empresa
                        {
                            NomeRazaoSocial = nome,
                            Cnpj = cnpj,
                            Endereco = endereco,
                            Telefone = telefone.Trim()

                        };

                        var retorno = empresa.salvarEmpresa();
                        MessageBox.Show(retorno);
                        LimparCampos();
                        CarregaTabelaEmpresa(empresa.ListarEmpresas());

                    }
                    else
                    {
                        MessageBox.Show("Certifique-se os campos Endereço, Razão social e Cnpj estão Corretos");
                    }
                    break;
                case "Atualizar":
                    id = Convert.ToInt32(drigEmpresas.CurrentRow.Cells["CÓDIGO"].Value);
                    if (nome != "" && cnpj != "" && endereco != "")
                    {
                        empresa = new Empresa
                        {
                            EmpresaId = id,
                            NomeRazaoSocial = nome,
                            Cnpj = cnpj,
                            Endereco = endereco,
                            Telefone = telefone.Trim()
                        };

                        var retorno = empresa.AtualizarEmpresa(empresa);
                        if (retorno == "Dados atualizados com sucesso")
                        {
                            btnSalvar.Text = "Salvar";
                            button2.Text = "Buscar";
                        }
                        MessageBox.Show(retorno);
                        LimparCampos();
                        CarregaTabelaEmpresa(empresa.ListarEmpresas());

                    }
                    else
                    {
                        MessageBox.Show("Certifique-se os campos Endereço, Razão social e Cnpj estão Corretos");
                    }
                    break;
                case "Cancelar":

                    LimparCampos();
                    btnSalvar.Text = "Salvar";
                    button2.Text = "Buscar";

                    break;
                case "Fechar":

                    LimparCampos();
                    btnSalvar.Text = "Salvar";
                    button2.Text = "Buscar";
                    this.grouplista.Visible = false;

                    break;
                case "Buscar":
                    if (nome != "" || cnpj != "")
                    {
                        empresa.NomeRazaoSocial = nome;
                        empresa.Cnpj = cnpj;
                       CarregaTabelaEmpresa(empresa.Filtrar(empresa));
                    }
                    else
                    {
                        LimparCampos();

                       CarregaTabelaEmpresa(empresa.ListarEmpresas());
                    }
                    this.grouplista.Visible = true;
                    break;
                default:
                    break;
            }

        }
        // Carrega o grid com os dados necessários
        private void CarregaTabelaEmpresa(IList<Empresa> empresa)
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
        // Limpa os campos para melhor performace
        private void LimparCampos()
        {           
                txtRazao.Clear();
                maskCNPJ.Clear();
                txtEndereco.Clear();
                maskTelefone.Clear();          
        }
        #endregion

       
    }

}
