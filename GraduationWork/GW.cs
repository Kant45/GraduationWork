using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GraduationWork {
    public partial class GW : DbContext {
        public GW()
            : base("name=GW") {
        }

        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Equipment>()
                .Property(e => e.Стоимость__руб__)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Equipment>()
                .Property(e => e.Сумма__руб__)
                .HasPrecision(18, 0);
        }
    }
}
