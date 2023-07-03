using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CV.Models
{
	public class Kisi
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Boş geçilemez.")]	
		[StringLength(150, ErrorMessage = "Max 150 karakter olmalıdır.")]
		public string Resim { get; set; }
		[Required(ErrorMessage = "Boş geçilemez.")]
		[StringLength(150, ErrorMessage = "Max 150 karakter olmalıdır.")]
		public string Ad { get; set; }
		[Required(ErrorMessage = "Boş geçilemez.")]
		[StringLength(150, ErrorMessage = "Max 150 karakter olmalıdır.")]
		public string Meslek { get; set; }

		[Required(ErrorMessage = "Boş geçilemez.")]
		[StringLength(150, ErrorMessage = "Max 150 karakter olmalıdır.")]
		public string ArkaResim { get; set; }
		
	}
}