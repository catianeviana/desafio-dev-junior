using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Gestao__de_Contrato.TiposEnum
{
   public enum TipoContrato
    {
        [Description("Selecione..")]
        Selecione,
        [Description("Empréstimo")]
        Emprestimo,
        [Description("Arrendamento")]
        Arrendamento,
        [Description("Seguro")]
        Seguro,
        [Description("Locação de Serviços")]
        Locacao_de_Servicos,
        [Description("Equipamento")]
        Equipamento
    }
}
