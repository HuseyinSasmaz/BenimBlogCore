using BenimBlogCore.Models.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BenimBlogCore.Models.Context
{
    public class Context:IdentityDbContext<UygulamaKullanıcısı,UygulamaRolu,int>    
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MYHP\\SQLEXPRESS;database=DbBenimBlogCore;integrated security=true;MultipleActiveResultSets=true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Mesajlar2>()
                .HasOne(x=>x.GönderKullanıcı)
                .WithMany(y=>y.YazarGönderen)
                .HasForeignKey(z=>z.GönderenID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Mesajlar2>()
            .HasOne(x => x.AlanKullanıcı)
            .WithMany(y => y.YazarAlıcı)
            .HasForeignKey(z => z.AlanID)
            .OnDelete(DeleteBehavior.ClientSetNull);
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkımızda> Hakkımızdas { get; set; }
        public DbSet<İletisim> İletisims { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Yazar> Yazars { get; set; }
        public DbSet<Yorum> Yorums { get; set; }
        public DbSet<HaberBulteni> HaberBultenis { get; set; }
        public DbSet<BlogReyting> BlogsReyting { get; set; }
        public DbSet<Bildirimler> Bildirimlers { get; set; }
        public DbSet<Mesajlar> Mesajlars { get; set; }  
        public DbSet<Mesajlar2> Mesajlar2s { get; set; }  
        public DbSet<Admin> Admins { get; set; }    
    }
}
