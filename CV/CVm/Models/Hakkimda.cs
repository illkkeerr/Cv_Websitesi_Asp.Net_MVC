using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CV.Models
{
	public class Hakkimda
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Boş geçilemez.")]
		[Display(Name = "Açıklama")]
		[StringLength(1200, ErrorMessage = "Max 1200 karakter olmalıdır.")]
		public string Aciklama { get; set; }
	}
}