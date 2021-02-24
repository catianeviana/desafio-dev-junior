using Gestao__de_Contrato.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao__de_Contrato
{
    public class BaseContext: DbContext
    {
        public BaseContext() : base("DB_GestaoDeContratos") { }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<ContratoModel> Contratos { get; set; }
    }
}
