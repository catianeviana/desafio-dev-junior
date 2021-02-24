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
using Gestao__de_Contrato.TiposEnum;



namespace Gestao__de_Contrato.Formes.Contrato
{
    public partial class IndexContratoForm : Form
    {
        public int Id { get; set; }
        public Button BotaoClicado { get; set; }
        public ListarContratosForms ListaContratosForms { get; set; }
        public IndexContratoForm()
        {
            InitializeComponent();
            CarregarCombobox();
            CarregarComboboxStatus();
        }

        #region Funções do Sistema
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoContrato? contrato = comboBox1.SelectedValue as TipoContrato?;
            if (contrato != TipoContrato.Selecione)
            {
                AlterarVisibilidade();
            }
            else
            {
                AlterarVisibilidade();
            }


        }

        private void btnBuscarContratante_Click(object sender, EventArgs e)
        {
            FormBuscaEmpresa buscaEmpresa = new FormBuscaEmpresa();
            buscaEmpresa.Contrato = this;
            buscaEmpresa.BotaoClicado = sender as Button;
            buscaEmpresa.ShowDialog();
        }

        private void btnBuscarContratado_Click(object sender, EventArgs e)
        {
            FormBuscaEmpresa buscaEmpresa = new FormBuscaEmpresa();
            buscaEmpresa.Contrato = this;
            buscaEmpresa.BotaoClicado = sender as Button;
            buscaEmpresa.ShowDialog();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "Salvar")
            {
                Salvar();
                
            }
            else
            {
                Atualizar();
            }
               
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ListaContratosForms.RetornarAoIndex();
            this.Close();

        }
        #endregion

        #region Métodos alternativos
        private void CarregarCombobox()
        {
            comboBox1.DataSource = Enum.GetValues(typeof(TipoContrato))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            comboBox1.DisplayMember = "Description";
            comboBox1.ValueMember = "value";
        }
        private void CarregarComboboxStatus()
        {

            comboBox2.DataSource = Enum.GetValues(typeof(TipoStatus))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                /// Removendo o Selecione do enum sem afetar os outros forms
                .Where(item => item.Description.ToString() != "Selecione..")
                .OrderBy(item => item.value)
                .ToList();
            comboBox2.DisplayMember = "Description";
            comboBox2.ValueMember = "value";


        }
        public void AlterarVisibilidade()
        {
            txtContratado.Enabled = txtContratado.Enabled == true ? false : true;
            txtContratante.Enabled = txtContratado.Enabled;
            txtValor.Enabled = txtContratado.Enabled;

            maskContratado.Enabled = txtContratado.Enabled;
            maskContratante.Enabled = txtContratado.Enabled;

            btnBuscarContratado.Enabled = txtContratado.Enabled;
            btnBuscarContratante.Enabled = txtContratado.Enabled;
            btnSalvar.Enabled = txtContratado.Enabled;

            dataCarencia.Enabled = txtContratado.Enabled;
            dataVigencia.Enabled = txtContratado.Enabled;
            dataPrazo.Enabled = txtContratado.Enabled;

            richDescObjeto.Enabled = txtContratado.Enabled;

            comboBox2.Enabled = txtContratado.Enabled;
        }
        public void Salvar()
        {
            if (txtContratado.Text != "" && txtContratante.Text != "" && txtValor.Text != "")
            {

                ContratoModel contrato = new ContratoModel();
                contrato.Datacontrato = dateContrato.Value.Date;               
                contrato.Status = comboBox2.Text;
                contrato.Descricao_do_Objeto = richDescObjeto.Text;
                contrato.Objeto = comboBox1.Text;
                contrato.Carencia = dataCarencia.Value.Date;
                contrato.IdEmpresaContratada = Convert.ToInt32(lblIdContratado.Text);
                contrato.IdEmpresaContratante = Convert.ToInt32(lblIdContratante.Text);
                contrato.Prazo = dataPrazo.Value.Date;
                contrato.Valor = decimal.Parse(txtValor.Text.Replace(".", "").Replace(",", ""));
                contrato.Vigencia = dataVigencia.Value.Date;
                if (MessageBox.Show(contrato.salvarContrato(), "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ListaContratosForms.PerssistirForm();
                }
                else 
                {
                    ListaContratosForms.RetornarAoIndex();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Campos Contratante,Contratado e Valor não podem ser nulos");
            }


        }
        public void CarregarEmpresa(Empresa empresa, object sender)
        {
            Button btn = sender as Button;
            if (btn.Name == "btnBuscarContratante")
            {
                txtContratante.Text = empresa.NomeRazaoSocial;
                maskContratante.Text = empresa.Cnpj;
                lblIdContratante.Text = empresa.EmpresaId.ToString();
            }
            else
            {
                txtContratado.Text = empresa.NomeRazaoSocial;
                maskContratado.Text = empresa.Cnpj;
                lblIdContratado.Text = empresa.EmpresaId.ToString();
            }

        }
        public void Editar(ContratoModel contrato)
        {
            lblIdCOntrato.Text = contrato.ContratoId.ToString();
            dateContrato.Value = contrato.Datacontrato.Value.Date;
            comboBox1.Text=contrato.Objeto;
            comboBox2.Text = contrato.Status;
            richDescObjeto.Text = contrato.Descricao_do_Objeto;
            dataCarencia.Value = contrato.Carencia.Date;
            lblIdContratado.Text = contrato.IdEmpresaContratada.ToString();
            lblIdContratante.Text = contrato.IdEmpresaContratante.ToString();
            dataPrazo.Value = contrato.Prazo.Date;
            txtValor.Text = contrato.Valor.ToString("C2");
            dataVigencia.Value = contrato.Vigencia.Value.Date;
            Empresa empresa = new Empresa();
            var contratado = empresa.BuscarPorId(contrato.IdEmpresaContratada);
            txtContratado.Text = contratado.NomeRazaoSocial;
            maskContratado.Text = contratado.Cnpj;
            var contratante = empresa.BuscarPorId(contrato.IdEmpresaContratante);
            txtContratante.Text = contratante.NomeRazaoSocial;
            maskContratante.Text = contratante.Cnpj;
            btnSalvar.Text = "Atualizar";
        }
        public void Atualizar()
        {            
            if (txtContratado.Text != "" && txtContratante.Text != "" && txtValor.Text != "")
            {

                ContratoModel contrato = new ContratoModel();
                contrato.ContratoId =int.Parse( lblIdCOntrato.Text);
                contrato.Datacontrato = dateContrato.Value.Date;               
                contrato.Status = comboBox2.Text;
                contrato.Descricao_do_Objeto = richDescObjeto.Text;
                contrato.Objeto = comboBox1.Text;
                contrato.Carencia = dataCarencia.Value.Date;
                contrato.IdEmpresaContratada = Convert.ToInt32(lblIdContratado.Text);
                contrato.IdEmpresaContratante = Convert.ToInt32(lblIdContratante.Text);
                contrato.Prazo = dataPrazo.Value.Date;
                contrato.Valor = Convert.ToDecimal(txtValor.Text.Replace("R$",""));
                contrato.Vigencia = dataVigencia.Value.Date;
                MessageBox.Show(contrato.AtualizarContrato(contrato));
                ListaContratosForms.RetornarAoIndex();
                this.Close();
            }
            else
            {
                MessageBox.Show("Campos Contratante,Contratado e Valor não podem ser nulos");
            }

        }
       
        #endregion

    }
}
