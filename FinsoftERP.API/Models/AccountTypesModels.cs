using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinsoftERP.API.Models
{
    [Table("FIN_STAT_SUB")]
    public class AccountTypeSub
    {
        public AccountTypeSub()
        {
            Remarks = "XXXXXXX";
        }

        [Column("CODE")]
        public string Code { get; set; }

        [Column("CDESC")]
        public string Description { get; set; }

        public string Remarks { get; set; }

//        public virtual ICollection<SubsidiaryAccount> SubsidiaryAccounts { get; set; }

    }

    public class AccountTypeSubConfigration : IEntityTypeConfiguration<AccountTypeSub>
    {
        public void Configure(EntityTypeBuilder<AccountTypeSub> builder)
        {

            builder.HasKey(s => s.Code);

            builder.Property(s => s.Code).HasMaxLength(6).HasColumnType("VARCHAR(6)").ValueGeneratedNever();

            builder.Property(s => s.Description).HasMaxLength(100).HasColumnType("VARCHAR(100)").IsRequired();

            builder.Property(s => s.Remarks).HasMaxLength(200).HasColumnType("VARCHAR(200)");

        }

    }

}