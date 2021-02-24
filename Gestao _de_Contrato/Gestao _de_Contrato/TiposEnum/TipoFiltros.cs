using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Gestao__de_Contrato.TiposEnum
{
    public enum TipoFiltros
    {
        [Description("Todos")]
        todos,
        [Description("Contrato")]
        objeto,
        [Description("Vigência")]
        vigencia,
        [Description("Data do Contrato")]
        dataInsercaoContato,        
        [Description("Status")]
        situacao,


    }
}
