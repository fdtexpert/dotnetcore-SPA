
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity.ModelConfiguration;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinsoftERP.API.Models
{

    [Table("LD_MAIN1")]
    public class PrvSubsidiaryAccount
    {
        [MaxLength(8), Key, Column("CODE")]
        public string Code { get; set; }

        [Required, MaxLength(100), Column("CDESC")]
        public string Description { get; set; }

        [Required]
        public string Remarks { get; set; }

        [Required, Column("ACC_TYPE")]
        public string AccountTypeSubCode1 { get; set; }

        [ForeignKey("AccountTypeSubCode1")]
        public AccountTypeSub AccountTypeSub1 { get; set; }


    }

    [Table("LD_MAIN")]
    public class SubsidiaryAccount
    {
        [Column("CODE")]
        public string Code { get; set; }

        [Column("CDESC"), Required]
        public string Description { get; set; }

        public string Remarks { get; set; }

        [Column("ACC_TYPE"), Display(Name = "Account Type")]
        public string AccountTypeSubCode { get; set; }

        //  [ForeignKey("AccountTypeSubCode")]
        public virtual AccountTypeSub AccountTypeSub { get; set; }


    }

    public class SubsidiaryAccountConfigration : IEntityTypeConfiguration<SubsidiaryAccount>
    {
        //public SubsidiaryAccountConfigration()
        public void Configure(EntityTypeBuilder<SubsidiaryAccount> builder)
        {


            builder.HasKey(s => s.Code);

            builder.Property(s => s.Code).HasMaxLength(8).HasColumnType("VARCHAR(8)").ValueGeneratedNever();

            builder.Property(s => s.Description).HasMaxLength(100).HasColumnType("VARCHAR(100)").IsRequired();

            builder.Property(s => s.Remarks).HasMaxLength(200).HasColumnType("VARCHAR(200)");

            builder.Property(s => s.AccountTypeSubCode).HasMaxLength(6).HasColumnType("VARCHAR(6)").IsRequired();

//            builder.HasRequired<AccountTypeSub>(a => a.AccountTypeSub).WithMany().HasForeignKey(s => s.AccountTypeSubCode).WillCascadeOnDelete(false);
            builder.HasOne<AccountTypeSub>(a => a.AccountTypeSub).WithMany().HasForeignKey(s => s.AccountTypeSubCode).OnDelete(DeleteBehavior.Restrict);

            //HasRequired(s => s.AccountTypeSub).WithMany(a => a.SubsidiaryAccounts).HasForeignKey(s => s.AccountTypeSubCode).WillCascadeOnDelete(false);


        }

    }

        [Table("LD_GEN")]
        public class GeneralAccount
        {
            [Column("CODE")]
            public string Code { get; set; }

            [Column("CDESC"), Required]
            public string Description { get; set; }

            public string Remarks { get; set; }

        }

        public class GeneralAccountConfigration : IEntityTypeConfiguration<GeneralAccount>
        {
            public void Configure(EntityTypeBuilder<GeneralAccount> builder)
            {

                builder.HasKey(s => s.Code);

                builder.Property(s => s.Code).HasMaxLength(4).HasColumnType("VARCHAR(4)").ValueGeneratedNever();

                builder.Property(s => s.Description).HasMaxLength(100).HasColumnType("VARCHAR(100)").IsRequired();

                builder.Property(s => s.Remarks).HasMaxLength(200).HasColumnType("VARCHAR(200)");

            }

        }

        [Table("LD_CTRL")]
        public class ControlAccount
        {
            [Column("CODE")]
            public string Code { get; set; }

            [Column("CDESC"), Required]
            public string Description { get; set; }

            public string Remarks { get; set; }

        }

        public class ControlAccountConfigration : IEntityTypeConfiguration<ControlAccount>
        {
            public void Configure(EntityTypeBuilder<ControlAccount> builder)
            {

                builder.HasKey(s => s.Code);

                builder.Property(s => s.Code).HasMaxLength(2).HasColumnType("VARCHAR(2)").ValueGeneratedNever();

                builder.Property(s => s.Description).HasMaxLength(100).HasColumnType("VARCHAR(100)").IsRequired();

                builder.Property(s => s.Remarks).HasMaxLength(200).HasColumnType("VARCHAR(200)");

            }

        }

        public class ChartOfAccountDto
        {
            public string Code { get; set; }

            public string Description { get; set; }

            public string Remarks { get; set; }

            public string AccountTypeSubCode { get; set; }


        }

        public class ControlAccountDto
        {
            public string Code { get; set; }

            public string Description { get; set; }

            public string Remarks { get; set; }


        }

        public class ChartOfAccountMeta
        {
            public FldDetail Code { get; set; }

            public FldDetail Description { get; set; }

            public FldDetail Remarks { get; set; }

            public FldDetail AccountTypeSubCode { get; set; }


        }


    }