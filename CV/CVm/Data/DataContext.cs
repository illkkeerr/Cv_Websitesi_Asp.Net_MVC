using CV.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CV.Data
{
	public class DataContext:DbContext
	{
		public DbSet<Tecrube> Tecrubes { get; set; }
		public DbSet<Egitim> Egitims { get; set; }
		public DbSet<Yetenek> Yeteneks { get; set; }
		public DbSet<HKisiselBilgiler> HKisiselBilgilers { get; set; }
		public DbSet<Hakkimda> Hakkimdas { get; set; }
		public DbSet<Kisi> Kisis { get; set; }
		public DbSet<Ikonlar> Ikonlars { get; set; }
		public DbSet<Iletisim> Iletisims { get; set; }
		public DbSet<Konum> Konums { get; set; }
		public DbSet<Referanslar> Referanslars { get; set; }
		public DbSet<Portfolyo> Portfolyos { get; set; }
	}
}