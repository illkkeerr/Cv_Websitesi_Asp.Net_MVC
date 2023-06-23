using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CV.Models
{
	public class Referanslar
	{
		public int Id { get; set; }
		public string Resim { get; set; }
		public string Ad { get; set; }
		public string Meslek { get; set; }
		public string Firma { get; set; }
		public string Yorum { get; set; }
	}
}