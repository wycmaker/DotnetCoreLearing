using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DotnetCoreLearning.Dal.Models
{
    public partial class QueryTestContext : DbContext
    {
        public QueryTestContext()
        {
        }

        public QueryTestContext(DbContextOptions<QueryTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cource> Cources { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QueryTest;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_CI_AS");

            modelBuilder.Entity<Cource>(entity =>
            {
                entity.ToTable("Cource");

                entity.Property(e => e.CourceId)
                    .HasColumnName("CourceID")
                    .HasComment("流水編號");

                entity.Property(e => e.AcademicYear).HasComment("學年度");

                entity.Property(e => e.CampusId)
                    .HasColumnName("CampusID")
                    .HasComment("校區ID");

                entity.Property(e => e.ClassroomId)
                    .HasColumnName("ClassroomID")
                    .HasComment("教室ID");

                entity.Property(e => e.CourceCategory).HasComment("課程類別");

                entity.Property(e => e.CourceCount).HasComment("總堂數");

                entity.Property(e => e.CourceDate).HasComment("上課日別");

                entity.Property(e => e.CourceEndTime).HasComment("上課結束時間");

                entity.Property(e => e.CourcePrice)
                    .HasColumnType("decimal(8, 2)")
                    .HasComment("課程單價");

                entity.Property(e => e.CourceProperty).HasComment("課程性質");

                entity.Property(e => e.CourceSalePrice)
                    .HasColumnType("decimal(8, 2)")
                    .HasComment("課程優惠價");

                entity.Property(e => e.CourceStartTime).HasComment("上課開始時間");

                entity.Property(e => e.CourceStatus).HasComment("開課狀態");

                entity.Property(e => e.CourceSymbol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("課程代號");

                entity.Property(e => e.CreateDateTime).HasComment("建立時間");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("建立者");

                entity.Property(e => e.CurrentStudentPrice)
                    .HasColumnType("decimal(8, 2)")
                    .HasComment("班內生優惠價");

                entity.Property(e => e.Deposit)
                    .HasColumnType("decimal(8, 2)")
                    .HasComment("訂金");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasComment("結束日期");

                entity.Property(e => e.Grade).HasComment("年級");

                entity.Property(e => e.GroupPrice)
                    .HasColumnType("decimal(8, 2)")
                    .HasComment("團體報名優惠價");

                entity.Property(e => e.IsDiscount).HasComment("是否符合科數優惠");

                entity.Property(e => e.ModifyDateTime).HasComment("修改時間");

                entity.Property(e => e.ModifyUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("修改者");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasComment("課程名稱");

                entity.Property(e => e.Note).HasComment("備註");

                entity.Property(e => e.SchoolGrade).HasComment("學校階級");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasComment("開始日期");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
