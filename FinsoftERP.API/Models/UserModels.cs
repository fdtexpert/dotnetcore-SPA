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
    [Table("SYSTEMS_USERS")]
    public class User
    {
        public string UserName { get; set; }

        public string FullName { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

//        public virtual ICollection<SubsidiaryAccount> SubsidiaryAccounts { get; set; }

    }

    public class UserConfigration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasKey(s => s.UserName);

            builder.Property(s => s.UserName).HasMaxLength(50).HasColumnType("VARCHAR(50)").ValueGeneratedNever();

            builder.Property(s => s.FullName).HasMaxLength(300).HasColumnType("VARCHAR(300)").IsRequired();

            builder.Property(s => s.PasswordHash).IsRequired();

            builder.Property(s => s.PasswordSalt).IsRequired();

//            builder.Property(s => s.Remarks).HasMaxLength(200).HasColumnType("VARCHAR(200)");

        }

    }

}