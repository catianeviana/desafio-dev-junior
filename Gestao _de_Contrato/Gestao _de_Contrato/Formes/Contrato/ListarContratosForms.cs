using Gestao__de_Contrato.Models;
using Gestao__de_Contrato.TiposEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Windows.Forms;

namespace Gestao__de_Contrato.Formes.Contrato
{
    public partial class ListarContratosForms : Form
    {
        public int Id { get; set; }
        public ListarContratosForms()
        {

            InitializeComponent();
            Index();
            AlterarVisibilidadeDosBotoes();
            CarregarCombobox();
            CarregarComboFiltro();
            radioTodos.Checked = true;
        }
        #region Funções Sistemas
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            IndexContratoForm contrato = new IndexContratoForm();
            contrato.TopLevel = false;
            contrato.ListaContratosForms = this;
            if (panel1.Controls.Count != 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            panel1.Controls.Add(contrato);
            contrato.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FiltrarPorCampos();
        }

        private void radioTodos_CheckedChanged(object sender, EventArgs e)
        {
            Permisao();
        }

        private void drigContratos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(drigContratos.CurrentRow.Cells["CÓDIGO"].Value);
            if (id > 0)
            {
                btn_Detalhar.Enabled = true;
                btn_Editar.Enabled = btn_Detalhar.Enabled;
                btn_Excluir.Enabled = btn_Editar.Enabled;
            }
        }

        private void radioContrato_CheckedChanged(object sender, EventArgs e)
        {
            Permisao();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(drigContratos.CurrentRow.Cells["CÓDIGO"].Value);
            ContratoModel contratoModels = new ContratoModel();
            if (id > 0)
            {
                AlterarVisibilidadeDosBotoes();
                var itemContrato = contratoModels.BuscarPorId(id);
                IndexContratoForm contrato = new IndexContratoForm();
                contrato.TopLevel = false;
                contrato.Editar(itemContrato);
                contrato.ListaContratosForms = this;
                if (panel1.Controls.Count != 0)
                {
                    panel1.Controls.RemoveAt(0);
                }
                panel1.Controls.Add(contrato);
                contrato.Show();

            }
            else
            {
                MessageBox.Show("Selecione um contrato");
            }

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(drigContratos.CurrentRow.Cells["CÓDIGO"].Value);
            if (id > 0 && MessageBox.Show("Excluir Contrato?","Confirmar",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                ContratoModel contrato = new ContratoModel();

                MessageBox.Show(contrato.Deletar(id));
                Index();
            }

        }

        private void btn_Detalhar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(drigContratos.CurrentRow.Cells["CÓDIGO"].Value);
            if (id > 0)
            {
                DetalheContratoForm formDetalhar = new DetalheContratoForm();
                formDetalhar.CarregarForm(id);
                formDetalhar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Contrato não selecionado, Tente novamente");
            }

        }

        #endregion

        #region Funções Alternativas
        public bool ValidarData(DateTime? data)
        {
            DateTime valor;
            return DateTime.TryParseExact(data.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out valor);


        }

        public void Permisao()
        {
            radioTodos.Checked = radioTodos.Checked == true ? true : false;
            if (radioTodos.Checked == true)
            {
                maskdataInicio.Enabled = false;
                maskdataInicio.Clear();
            }
            else
            {
                maskdataInicio.Enabled = true;
            }
        }

        public void FiltrarPorCampos()
        {
            ContratoModel contratoModel = new ContratoModel();
            DateTime? datainicio = maskdataInicio.Text == "  /  /" ? null : Convert.ToDateTime(maskdataInicio.Text.Trim()) as DateTime?;
            string radio = radioTodos.Checked == true ? radioTodos.Text : radioContrato.Checked == true ? radioContrato.Text : radioButton3.Text;

            contratoModel.Objeto = comboContrato.Text;
            contratoModel.Status = TipoStatus.Text;
            if (radio == "Contrato")
                contratoModel.Datacontrato = datainicio;
            if (radio == "Vigência")
                contratoModel.Vigencia = datainicio;
            var retorno = contratoModel.BuscarLike(contratoModel);
            CarregaListarDeContrato(retorno);

        }

        public void Index()
        {
            ContratoModel contrato = new ContratoModel();
            CarregaListarDeContrato(contrato.ListarContratos());
        }

        private void CarregarCombobox()
        {
            comboContrato.DataSource = Enum.GetValues(typeof(TipoContrato))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            comboContrato.DisplayMember = "Description";
            comboContrato.ValueMember = "value";
        }

        private void CarregarComboFiltro()
        {
            TipoStatus.DataSource = Enum.GetValues(typeof(TipoStatus))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            TipoStatus.DisplayMember = "Description";
            TipoStatus.ValueMember = "value";
        }

        private void CarregaListarDeContrato(IList<ContratoModel> contratoModel)
        {
            // Definindo variável de tabela
            DataTable dt = new DataTable("temp");
            // Definindo os campos da Tabela           
            dt.Columns.Add("CÓDIGO", typeof(int));
            dt.Columns.Add("STATUS", typeof(string));
            dt.Columns.Add("CONTRATENTE", typeof(string));
            dt.Columns.Add("CONTRATADO", typeof(string));
            dt.Columns.Add("OBJETO", typeof(string));
            dt.Columns.Add("DATA CONTRATO", typeof(string));
            dt.Columns.Add("CARENCIA", typeof(string));
            dt.Columns.Add("VIGENCIA", typeof(string));
            dt.Columns.Add("VALOR", typeof(string));
            dt.Columns.Add("PRAZO", typeof(string));

            foreach (var item in contratoModel)
            {
                var contratado = item.Empresa.BuscarPorId(item.IdEmpresaContratada);

                dt.Rows.Add(
                    item.ContratoId,
                    item.Status,
                    item.Empresa.NomeRazaoSocial,
                    contratado.NomeRazaoSocial,
                    item.Objeto,
                    item.Datacontrato?.ToString("dd/MM/yyyy"),
                    item.Carencia.ToString("dd/MM/yyyy"),
                    item.Vigencia?.ToString("dd/MM/yyyy"),
                    item.Valor.ToString("C2"),
                    item.Prazo.ToString("dd/MM/yyyy")
                    );
                dt.Columns[1].ColumnName.Equals("STATUS");
            }
            // Incluindo a tabela no DataSet                         
            drigContratos.DataSource = dt;
            drigContratos.ReadOnly = true;
            // alterar a largura           
            FormatarColunaDaGrid();
        }

        public void FormatarColunaDaGrid()
        {
            foreach (DataGridViewColumn column in drigContratos.Columns)
            {
                //Formatar os tamanho das coluna 
                var nomeColuna = column.DataPropertyName;
                switch (nomeColuna)
                {
                    case "CÓDIGO":
                        column.Width = 50;
                        break;
                    case "STATUS":
                        column.Width = 65;
                        break;
                    case "DATA CONTRATO":
                        column.Width = 70;
                        break;
                    case "CARENCIA":
                        column.Width = 70;
                        break;
                    case "VIGENCIA":
                        column.Width = 70;
                        break;
                    case "PRAZO":
                        column.Width = 70;
                        break;
                    case "VALOR":
                        column.Width = 74;
                        break;
                    case "OBJETO":
                        column.Width = 75;
                        break;
                    default:
                        column.Width = 180;
                        break;
                }
            }
        }

        public void RetornarAoIndex()
        {
            ListarContratosForms listaIndex = new ListarContratosForms();
            listaIndex.TopLevel = false;
            if (panel1.Controls.Count != 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            panel1.Controls.Add(listaIndex);
            listaIndex.Show();
        }

        public void AlterarVisibilidadeDosBotoes()
        {

            btn_Detalhar.Enabled = btn_Detalhar.Enabled == true ? false : true;
            btn_Editar.Enabled = btn_Detalhar.Enabled;
            btn_Excluir.Enabled = btn_Editar.Enabled;
        }

        public void PerssistirForm()
        {
            IndexContratoForm contrato = new IndexContratoForm();
            contrato.TopLevel = false;
            contrato.ListaContratosForms = this;
            if (panel1.Controls.Count != 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            panel1.Controls.Add(contrato);
            contrato.Show();
        }

        #endregion


    }
}
