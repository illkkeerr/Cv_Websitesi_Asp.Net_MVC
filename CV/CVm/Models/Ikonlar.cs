using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CV.Models
{
	public class Ikonlar
	{
		[Key]
		public int ID { get; set; }
		public string Ad { get; set; }
		public string Font { get; set; }

		public string Baglanti { get; set; }
	}
}