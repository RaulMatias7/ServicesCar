﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicesCars.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class db_estacaoEntities : DbContext
    {
        public db_estacaoEntities()
            : base("name=db_estacaoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FuncGroup> FuncGroup { get; set; }
        public virtual DbSet<Grupos> Grupos { get; set; }
        public virtual DbSet<Servicos> Servicos { get; set; }
        public virtual DbSet<SubServicos> SubServicos { get; set; }
        public virtual DbSet<Funcionarios> Funcionarios { get; set; }
        public virtual DbSet<Sistema> Sistema { get; set; }
        public virtual DbSet<Atendimento> Atendimento { get; set; }
        public virtual DbSet<Pagamentos> Pagamentos { get; set; }
        public virtual DbSet<vwAtendimentos> vwAtendimentos { get; set; }
        public virtual DbSet<Caixa> Caixa { get; set; }
        public virtual DbSet<vwCaixa> vwCaixa { get; set; }
        public virtual DbSet<Promocoes> Promocoes { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<FaturasEmpresa> FaturasEmpresa { get; set; }
        public virtual DbSet<vwFacturasEmpresas> vwFacturasEmpresas { get; set; }
    
        public virtual ObjectResult<Pagamentos> spUpdateCaixa(Nullable<int> idPagamento)
        {
            var idPagamentoParameter = idPagamento.HasValue ?
                new ObjectParameter("idPagamento", idPagamento) :
                new ObjectParameter("idPagamento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Pagamentos>("spUpdateCaixa", idPagamentoParameter);
        }
    
        public virtual ObjectResult<Pagamentos> spUpdateCaixa(Nullable<int> idPagamento, MergeOption mergeOption)
        {
            var idPagamentoParameter = idPagamento.HasValue ?
                new ObjectParameter("idPagamento", idPagamento) :
                new ObjectParameter("idPagamento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Pagamentos>("spUpdateCaixa", mergeOption, idPagamentoParameter);
        }
    }
}
