﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dao
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class amEntities : DbContext
    {
        public amEntities()
            : base("name=amEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<addr> addr { get; set; }
        public DbSet<admin> admin { get; set; }
        public DbSet<app> app { get; set; }
        public DbSet<cat> cat { get; set; }
        public DbSet<goodstype> goodstype { get; set; }
        public DbSet<recommended> recommended { get; set; }
        public DbSet<upfeedbackinfo> upfeedbackinfo { get; set; }
        public DbSet<grade> grade { get; set; }
        public DbSet<qualificationtype> qualificationtype { get; set; }
        public DbSet<traintype> traintype { get; set; }
        public DbSet<orderpingjia> orderpingjia { get; set; }
        public DbSet<consumptionnote> consumptionnote { get; set; }
        public DbSet<user> user { get; set; }
        public DbSet<applicationinfo> applicationinfo { get; set; }
        public DbSet<appraisalaccident> appraisalaccident { get; set; }
        public DbSet<appraisalapplication> appraisalapplication { get; set; }
        public DbSet<expertsdesigninfo> expertsdesigninfo { get; set; }
        public DbSet<expertsproofinfo> expertsproofinfo { get; set; }
        public DbSet<fault> fault { get; set; }
        public DbSet<testing> testing { get; set; }
        public DbSet<train> train { get; set; }
        public DbSet<ad> ad { get; set; }
        public DbSet<AuthPermission> AuthPermission { get; set; }
        public DbSet<AuthRelation> AuthRelation { get; set; }
        public DbSet<AuthRole> AuthRole { get; set; }
        public DbSet<AuthUser> AuthUser { get; set; }
        public DbSet<AuthUserPermission> AuthUserPermission { get; set; }
        public DbSet<AuthUserRole> AuthUserRole { get; set; }
        public DbSet<config> config { get; set; }
        public DbSet<faulttype> faulttype { get; set; }
        public DbSet<newstype> newstype { get; set; }
        public DbSet<goods> goods { get; set; }
        public DbSet<expresscode> expresscode { get; set; }
        public DbSet<news> news { get; set; }
        public DbSet<ordergoods> ordergoods { get; set; }
        public DbSet<alipay> alipay { get; set; }
        public DbSet<threelogin> threelogin { get; set; }
        public DbSet<order> order { get; set; }
    }
}
