using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CV.Models
{
	public class HKisiselBilgiler
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Boş geçilemez.")]
		[Display(Name = "Ad")]
		[StringLength(100, ErrorMessage = "Max 100 karakter olmalıdır.")]
		public string Ad { get; set; }

		[Required(ErrorMessage = "Boş geçilemez.")]
		[Display(Name = "Bağlantı")]
		[StringLength(150, ErrorMessage = "Max 150 karakter olmalıdır.")]
		public string Baglanti { get; set; }


		[Required(ErrorMessage = "Boş geçilemez.")]
		[Display(Name = "Açıklama")]
		[StringLength(200, ErrorMessage = "Max 200 karakter olmalıdır.")]
		public string Aciklama { get; set; }
	}
}