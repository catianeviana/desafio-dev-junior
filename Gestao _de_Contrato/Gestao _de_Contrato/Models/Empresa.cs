using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestao__de_Contrato.Contexto;

namespace Gestao__de_Contrato.Models
{
    [Table("Empresas")]
    public class Empresa
    {
        readonly private EmpresaContext _contexto;
        [Key()]
        public int EmpresaId { get; set; }
        public string NomeRazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public virtual IList<ContratoModel> Contrato { get; set; } = new List<ContratoModel>();

        public Empresa()
        {
            _contexto = new EmpresaContext();
        }
        public string salvarEmpresa()
        {
            _contexto.Salvar(this);
            return "Empresa Salva";
        }
        public IList<Empresa> ListarEmpresas()
        {
            return _contexto.Listar();
        }
        public Empresa BuscarPorId(int id)
        {
            return _contexto.BuscarEmpresaPorId(id);
        }
        public IList<Empresa> Filtrar(Empresa empresa)
        {
            return _contexto.ListarPorFiltro(empresa);
        }
        public void Excluir(int id)
        {
            _contexto.Excluir(id);
        }
        public string AtualizarEmpresa(Empresa empresa)
        {
            _contexto.Atualizar(empresa);
            return "Empresa Atualizada";
        }
    }

}
