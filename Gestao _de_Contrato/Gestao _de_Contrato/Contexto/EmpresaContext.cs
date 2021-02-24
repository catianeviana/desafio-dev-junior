using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestao__de_Contrato.Models;

namespace Gestao__de_Contrato.Contexto
{
    public class EmpresaContext
    {
        private readonly BaseContext db;

        public EmpresaContext()
        {
            db = new BaseContext();
        }

        public void Salvar(Empresa empresas)
        {
            db.Empresas.Add(empresas);
            db.SaveChanges();
        }
        public IList<Empresa> Listar()
        {
            return db.Empresas.ToList();
        }
        public IList<Empresa> ListarPorFiltro(Empresa empresa)
        {
            return db.Empresas.Where(e => e.NomeRazaoSocial
            .Contains(empresa.NomeRazaoSocial) && e.Cnpj.Contains(empresa.Cnpj)).ToList();
        }
        public void Atualizar(Empresa empresa)
        {
            var dados = db.Empresas.Find(empresa.EmpresaId);
            if (dados != null)
            {
                dados.NomeRazaoSocial = empresa.NomeRazaoSocial;
                dados.Cnpj = empresa.Cnpj;
                dados.Endereco = empresa.Endereco;
                dados.Telefone = empresa.Telefone;
            }
            db.SaveChanges();
        }
        public Empresa BuscarEmpresaPorId(int id)
        {
           return db.Empresas.Find(id);
        }
        public void Excluir(int id)
        {
            var dados = db.Empresas.Find(id);
            db.Empresas.Remove(dados);
            db.SaveChanges();
        }       

    }
}
