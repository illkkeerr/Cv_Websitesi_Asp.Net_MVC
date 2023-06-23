using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CV.Models
{
	public class Yetenek
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Boş geçilemez.")]
		[Display(Name = "Ad")]
		[StringLength(150, ErrorMessage = "Max 150 karakter olmalıdır.")]
		public string Ad { get; set; }

		[Required(ErrorMessage = "Boş geçilemez.")]
		public byte Seviye { get; set; }
	}
}