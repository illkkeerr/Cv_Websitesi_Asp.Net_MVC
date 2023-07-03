using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CV.Models
{
	public class Konum
	{
		[Key]
		public int Id { get; set; }
		public string Adres { get; set; }
	}
}