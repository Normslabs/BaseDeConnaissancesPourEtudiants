using BaseDeConnaissancesEtudiants.DataAccess.Interceptors;
using BaseDeConnaissancesEtudiants.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeConnaissancesEtudiants.DataAccess.Contexts;
internal class ComponentsContext : DbContext {

    public DbSet<TextKnowledgeComponent> TextKnowledgeComponents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.AddInterceptors(new SoftDeleteInterceptor());
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<TextKnowledgeComponent>(model => {
            model.HasKey(model => model.Id);
            model.HasQueryFilter(model => model.IsDeleted == false);
            model.Property(model => model.DisplayName).HasMaxLength(128);
            model.Property(model => model.FormatType).HasColumnType("nvarchar(24)");
            model.Property(model => model.TextContent).HasColumnType("text");
            model.Property(model => model.IsDeleted).HasDefaultValue(false);
            model.Property(model => model.CreatedAt).HasDefaultValueSql("getdate()");
            model.Property(model => model.UpdatedAt).HasDefaultValueSql("getdate()").HasComputedColumnSql("getdate()");
            model.HasData(new TextKnowledgeComponent(1, "Expressions et Instructions", TextFormatEnum.HTML, "", false, null, null, null));
        });
    }
}
