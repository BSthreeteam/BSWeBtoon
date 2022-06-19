using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Mvcdemo.Model.Models
{
    public partial class BSWeBtoonContext : DbContext
    {
        public BSWeBtoonContext()
        {
        }

        public BSWeBtoonContext(DbContextOptions<BSWeBtoonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Coin> Coins { get; set; }
        public virtual DbSet<Comic> Comics { get; set; }
        public virtual DbSet<ComicCheckType> ComicCheckTypes { get; set; }
        public virtual DbSet<ComicPic> ComicPics { get; set; }
        public virtual DbSet<ComicStatus> ComicStatuses { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Epsiode> Epsiodes { get; set; }
        public virtual DbSet<GetMethod> GetMethods { get; set; }
        public virtual DbSet<Keyword> Keywords { get; set; }
        public virtual DbSet<KeywordDetail> KeywordDetails { get; set; }
        public virtual DbSet<LoginType> LoginTypes { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MyLove> MyLoves { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PayMethod> PayMethods { get; set; }
        public virtual DbSet<Recharge> Recharges { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<ReportReason> ReportReasons { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<UseRecord> UseRecords { get; set; }
        public virtual DbSet<ViewRecord> ViewRecords { get; set; }
        public virtual DbSet<VireRecord> VireRecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Database=BSWeBtoon;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Coin>(entity =>
            {
                entity.ToTable("Coin");

                entity.Property(e => e.CoinId).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("money");
            });

            modelBuilder.Entity<Comic>(entity =>
            {
                entity.ToTable("Comic");

                entity.Property(e => e.Author).HasMaxLength(50);

                entity.Property(e => e.ComicCheckType).HasMaxLength(50);

                entity.Property(e => e.ComicName).HasMaxLength(50);

                entity.Property(e => e.ComicStatusId).HasMaxLength(450);

                entity.Property(e => e.LaunchDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateWeek).HasMaxLength(50);

                entity.HasOne(d => d.ComicCheckTypeNavigation)
                    .WithMany(p => p.Comics)
                    .HasForeignKey(d => d.ComicCheckType)
                    .HasConstraintName("FK_Comic_ComicCheckType");

                entity.HasOne(d => d.ComicStatus)
                    .WithMany(p => p.Comics)
                    .HasForeignKey(d => d.ComicStatusId)
                    .HasConstraintName("FK_Comic_ComicStatus");
            });

            modelBuilder.Entity<ComicCheckType>(entity =>
            {
                entity.ToTable("ComicCheckType");

                entity.Property(e => e.ComicCheckTypeId).HasMaxLength(50);
            });

            modelBuilder.Entity<ComicPic>(entity =>
            {
                entity.ToTable("ComicPic");

                entity.Property(e => e.ComicId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.EpId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Comic)
                    .WithMany(p => p.ComicPics)
                    .HasForeignKey(d => d.ComicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComicPic_Comic");

                entity.HasOne(d => d.Ep)
                    .WithMany(p => p.ComicPics)
                    .HasForeignKey(d => d.EpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComicPic_Epsiode");
            });

            modelBuilder.Entity<ComicStatus>(entity =>
            {
                entity.ToTable("ComicStatus");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.Property(e => e.ComicId).HasMaxLength(450);

                entity.Property(e => e.CommentTime).HasColumnType("datetime");

                entity.Property(e => e.EpId).HasMaxLength(450);

                entity.Property(e => e.MemberId).IsRequired();

                entity.Property(e => e.ReplyToCommentId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Comic)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.ComicId)
                    .HasConstraintName("FK_Comment_Comic");

                entity.HasOne(d => d.Ep)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.EpId)
                    .HasConstraintName("FK_Comment_Epsiode");

                entity.HasOne(d => d.ReplyToComment)
                    .WithMany(p => p.InverseReplyToComment)
                    .HasForeignKey(d => d.ReplyToCommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Comment");
            });

            modelBuilder.Entity<Epsiode>(entity =>
            {
                entity.HasKey(e => e.EpId);

                entity.ToTable("Epsiode");

                entity.Property(e => e.CheckTypeId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ComicId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Comic)
                    .WithMany(p => p.Epsiodes)
                    .HasForeignKey(d => d.ComicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Epsiode_Comic");
            });

            modelBuilder.Entity<GetMethod>(entity =>
            {
                entity.ToTable("GetMethod");

                entity.Property(e => e.GetMethodId).HasMaxLength(50);

                entity.Property(e => e.ComicId).HasMaxLength(450);

                entity.Property(e => e.GetMethodEndDate).HasColumnType("datetime");

                entity.Property(e => e.GetMethodStartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Comic)
                    .WithMany(p => p.GetMethods)
                    .HasForeignKey(d => d.ComicId)
                    .HasConstraintName("FK_GetMethod_Comic");
            });

            modelBuilder.Entity<Keyword>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Keyword");

                entity.Property(e => e.ComicId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.KeywordDetailId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Comic)
                    .WithMany()
                    .HasForeignKey(d => d.ComicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Keyword_Comic");

                entity.HasOne(d => d.KeywordDetail)
                    .WithMany()
                    .HasForeignKey(d => d.KeywordDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Keyword_KeywordDetail");
            });

            modelBuilder.Entity<KeywordDetail>(entity =>
            {
                entity.ToTable("KeywordDetail");

                entity.Property(e => e.KeywordDetailId).HasMaxLength(50);
            });

            modelBuilder.Entity<LoginType>(entity =>
            {
                entity.ToTable("LoginType");

                entity.Property(e => e.LoginTypeId).HasMaxLength(50);
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.ToTable("Member");

                entity.Property(e => e.CoinQuantity).HasColumnType("money");

                entity.Property(e => e.LoginTypeId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MemberName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Setting)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("setting");

                entity.HasOne(d => d.LoginType)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.LoginTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Member_LoginType");
            });

            modelBuilder.Entity<MyLove>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MyLove");

                entity.Property(e => e.ComicId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.MemberId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Comic)
                    .WithMany()
                    .HasForeignKey(d => d.ComicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MyLove_Comic");

                entity.HasOne(d => d.Member)
                    .WithMany()
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MyLove_Member");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.OrderId).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.EpId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.GetId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MemberId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.StockId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Ep)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.EpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Epsiode");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Member");
            });

            modelBuilder.Entity<PayMethod>(entity =>
            {
                entity.ToTable("PayMethod");

                entity.Property(e => e.PayMethodId).HasMaxLength(50);
            });

            modelBuilder.Entity<Recharge>(entity =>
            {
                entity.ToTable("Recharge");

                entity.Property(e => e.RechargeId).HasMaxLength(50);

                entity.Property(e => e.CoinId).HasMaxLength(50);

                entity.Property(e => e.MemberId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.PayMethodId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RechargeDate).HasColumnType("datetime");

                entity.HasOne(d => d.Coin)
                    .WithMany(p => p.Recharges)
                    .HasForeignKey(d => d.CoinId)
                    .HasConstraintName("FK_Recharge_Coin");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Recharges)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recharge_Member");

                entity.HasOne(d => d.PayMethod)
                    .WithMany(p => p.Recharges)
                    .HasForeignKey(d => d.PayMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recharge_PayMethod");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("Report");

                entity.Property(e => e.ReportId).HasMaxLength(50);

                entity.Property(e => e.BeReportedMemberId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CommentId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.ReportMemberId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.ReportReasonId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.BeReportedMember)
                    .WithMany(p => p.ReportBeReportedMembers)
                    .HasForeignKey(d => d.BeReportedMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Report_Member");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.CommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Report_Comment");

                entity.HasOne(d => d.ReportMember)
                    .WithMany(p => p.ReportReportMembers)
                    .HasForeignKey(d => d.ReportMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Report_Member1");

                entity.HasOne(d => d.ReportReason)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.ReportReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Report_ReportReason");
            });

            modelBuilder.Entity<ReportReason>(entity =>
            {
                entity.ToTable("ReportReason");

                entity.Property(e => e.ReportReasonId).HasMaxLength(50);
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.Property(e => e.ComicId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.MemberId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Comic)
                    .WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.ComicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stocks_Comic");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stocks_Member");
            });

            modelBuilder.Entity<UseRecord>(entity =>
            {
                entity.ToTable("UseRecord");

                entity.Property(e => e.EpId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.MemberId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.StockId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.UseDateEnd).HasColumnType("datetime");

                entity.Property(e => e.UseDateSart).HasColumnType("datetime");

                entity.HasOne(d => d.Ep)
                    .WithMany(p => p.UseRecords)
                    .HasForeignKey(d => d.EpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UseRecord_Epsiode");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.UseRecords)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UseRecord_Member");

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.UseRecords)
                    .HasForeignKey(d => d.StockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UseRecord_Stocks");
            });

            modelBuilder.Entity<ViewRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ViewRecord");

                entity.Property(e => e.ComicId).HasMaxLength(50);

                entity.Property(e => e.EpId).HasMaxLength(50);

                entity.Property(e => e.MemberId).HasMaxLength(50);
            });

            modelBuilder.Entity<VireRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VireRecord");

                entity.Property(e => e.ComicId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.ComicPicId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.EpId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.MemberId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Comic)
                    .WithMany()
                    .HasForeignKey(d => d.ComicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VireRecord_Comic");

                entity.HasOne(d => d.ComicPic)
                    .WithMany()
                    .HasForeignKey(d => d.ComicPicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VireRecord_ComicPic");

                entity.HasOne(d => d.Ep)
                    .WithMany()
                    .HasForeignKey(d => d.EpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VireRecord_Epsiode");

                entity.HasOne(d => d.Member)
                    .WithMany()
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VireRecord_Member");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
