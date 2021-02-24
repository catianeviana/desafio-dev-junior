using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestao__de_Contrato.Formes.Corporacao;
using Gestao__de_Contrato.Formes.Contrato;
using Gestao__de_Contrato.Formes;

namespace Gestao__de_Contrato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarTemplate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.TopLevel = false;
            if (panel2.Controls.Count != 0)
            {
                panel2.Controls.RemoveAt(0);
            }
            panel2.Controls.Add(index);
            index.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListarContratosForms contrato = new ListarContratosForms();
            contrato.TopLevel = false;
            if (panel2.Controls.Count != 0)
            {
                panel2.Controls.RemoveAt(0);
            }
            panel2.Controls.Add(contrato);
            contrato.Show();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            CarregarTemplate();

        }
        public void CarregarTemplate()
        {
            IndexForm inicio = new IndexForm();
            inicio.TopLevel = false;
            if (panel2.Controls.Count != 0)
            {
                panel2.Controls.RemoveAt(0);
            }
            panel2.Controls.Add(inicio);
            inicio.Show();
        }

      
    }
}
