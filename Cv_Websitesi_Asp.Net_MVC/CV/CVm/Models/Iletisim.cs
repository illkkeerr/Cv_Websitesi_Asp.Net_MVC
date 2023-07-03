using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CV.Models
{
	public class Iletisim
	{
		[Key]
		public int Id { get; set; }
		public string Ad { get; set; }
		public string Email { get; set; }
		public string Mesaj { get; set; }
	}
}