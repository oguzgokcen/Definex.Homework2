using Microsoft.EntityFrameworkCore;

namespace ProductSearchApp.Models
{
	public class ProductDb : DbContext
	{
		public ProductDb() { }
		public DbSet<Product> Product { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			=> optionsBuilder.UseSqlServer("Data Source=LAPTOP-061MDE8T;Initial Catalog=ProductDbHomework2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(
				new Product { Id = 1, ProductName = "Monitör", ProductDesc = "Büyük 27 inç monitör IPS ekran" },
				new Product { Id = 2, ProductName = "Fare", ProductDesc = "Kablosuz Bluetooth fare" },
				new Product { Id = 3, ProductName = "Klavye", ProductDesc = "Mekanik RGB aydınlatmalı klavye" },
				new Product { Id = 4, ProductName = "Kulaklık", ProductDesc = "Kablosuz kulak üstü kulaklık" },
				new Product { Id = 5, ProductName = "Hoparlör", ProductDesc = "Stereo ses sistemli hoparlör" },
				new Product { Id = 6, ProductName = "Mikrofon", ProductDesc = "Yüksek kaliteli condenser mikrofon" },
				new Product { Id = 7, ProductName = "Webcam", ProductDesc = "Full HD 1080p webcam" },
				new Product { Id = 8, ProductName = "Laptop", ProductDesc = "16GB RAM'li güçlü dizüstü bilgisayar" },
				new Product { Id = 9, ProductName = "Masaüstü Bilgisayar", ProductDesc = "Oyuncular için güçlü masaüstü PC" },
				new Product { Id = 10, ProductName = "Router", ProductDesc = "Hızlı ve güçlü kablosuz internet router" },
				new Product { Id = 11, ProductName = "SSD", ProductDesc = "1TB NVMe SSD" },
				new Product { Id = 12, ProductName = "HDD", ProductDesc = "2TB Harici Hard Disk" },
				new Product { Id = 13, ProductName = "RAM", ProductDesc = "DDR4 16GB RAM" },
				new Product { Id = 14, ProductName = "Ekran Kartı", ProductDesc = "RTX 3060 12GB ekran kartı" },
				new Product { Id = 15, ProductName = "Anakart", ProductDesc = "Yeni nesil anakart destekli işlemci" },
				new Product { Id = 16, ProductName = "İşlemci", ProductDesc = "Intel i7 12. nesil işlemci" },
				new Product { Id = 17, ProductName = "Mouse Pad", ProductDesc = "RGB aydınlatmalı büyük mouse pad" },
				new Product { Id = 18, ProductName = "USB Bellek", ProductDesc = "128GB hızlı USB bellek" },
				new Product { Id = 19, ProductName = "Kamera", ProductDesc = "4K çözünürlüklü video kamera" },
				new Product { Id = 20, ProductName = "Güç Kaynağı", ProductDesc = "750W modüler güç kaynağı" });
		}
	}
}
