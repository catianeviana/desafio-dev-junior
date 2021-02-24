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
    public partial class DetalheContratoForm : Form
    {
        public DetalheContratoForm()
        {
            InitializeComponent();
        }
        public void CarregarForm(int id)
        {
            ContratoModel contrato = new ContratoModel();
           var resultado= contrato.DetalharContrato(id);

            lblDtContrato.Text =resultado.Datacontrato?.ToString("dd/MM/yyyy");
            //Carrega Contratente
            lblEmpresaContratante.Text =resultado.Empresa.NomeRazaoSocial;
            lblCnpjContratante.Text = Convert.ToUInt64(resultado.Empresa.Cnpj).ToString(@"00\.000\.000\/0000\-00");
            lblEnderecoContratante.Text = resultado.Empresa.Endereco;
            if(resultado.Empresa.Telefone!="" && resultado.Empresa.Telefone.Length==10)
            blbTelefoneContratante.Text = String.Format("{0:(##) ####-####}", resultado.Empresa.Telefone);
            if (resultado.Empresa.Telefone != "" && resultado.Empresa.Telefone.Length == 11)
                blbTelefoneContratante.Text = String.Format("{0:(##) # ####-####}", resultado.Empresa.Telefone);

            //Carrega Contratado
            Empresa empresa = new Empresa();
            var contratado = empresa.BuscarPorId(resultado.IdEmpresaContratada);
            lblEmpresaContratado.Text = contratado.NomeRazaoSocial;
            lblCnpjContratado.Text = Convert.ToUInt64(contratado.Cnpj).ToString(@"00\.000\.000\/0000\-00");
            lblEnderecoContratado.Text =contratado.Endereco;
            if (resultado.Empresa.Telefone != "" && resultado.Empresa.Telefone.Length == 10)
                lblTelefoneContratado.Text = String.Format("{0:(##) ####-####}", contratado.Telefone);
            if (resultado.Empresa.Telefone != "" && resultado.Empresa.Telefone.Length == 11)
                lblTelefoneContratado.Text = String.Format("{0:(##) # ####-####}", contratado.Telefone);
           

            ////Demais opcoes do contrato

            lblObjeto.Text = resultado.Objeto;
            DescObjeto.Text =resultado.Descricao_do_Objeto;
            lblDataCarencia.Text =resultado.Carencia.ToString("dd/MM/yyyy");
            lblDataVigencia.Text =resultado.Vigencia?.ToString("dd/MM/yyyy");
            lblValor.Text =resultado.Valor.ToString("C2");
            lblDataPrazo.Text =resultado.Prazo.ToString("dd/MM/yyyy");
            lblStatus.Text = resultado.Status;



        }

       
    }
}
