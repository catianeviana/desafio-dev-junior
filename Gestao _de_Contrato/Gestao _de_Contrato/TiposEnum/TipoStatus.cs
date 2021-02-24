using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Gestao__de_Contrato.TiposEnum
{
  public enum TipoStatus
    {
        [Description("Selecione..")]
        selecione,
        [Description("Em Edição")]
        Em_Edicao,
        [Description("Ativo")]
        Ativo,
        [Description("Cancelado")]
        Cancelado
    }
}
