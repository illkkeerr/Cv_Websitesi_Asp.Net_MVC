
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CV.Models
{
	public class Portfolyo
	{
		[Key]
		public int Id { get; set; }
		public string Resim { get; set; }
		public string Programlar { get; set; }
		public string Baslik { get; set; }
		public string Aciklama { get; set; }
		public string Link { get; set; }
	}
}