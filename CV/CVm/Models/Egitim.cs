using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CV.Models
{
	public class Egitim
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Boş geçilemez.")]
		[Display(Name = "Bölüm")]
		[StringLength(150, ErrorMessage = "Max 150 karakter olmalıdır.")]
		public string Bolum { get; set; }

		[Required(ErrorMessage = "Boş geçilemez.")]
		[Display(Name = "Okul")]
		[StringLength(150, ErrorMessage = "Max 150 karakter olmalıdır.")]
		public string Okul { get; set; }

		[Required(ErrorMessage = "Boş geçilemez.")]
		[Display(Name = "Başlama Tarihi")]
		[StringLength(20, ErrorMessage = "Max 20 karakter olmalıdır.")]
		public string BaslangicTarih { get; set; }

		[Required(ErrorMessage = "Boş geçilemez.")]
		[Display(Name = "Bitiş Tarihi")]
		[StringLength(20, ErrorMessage = "Max 20 karakter olmalıdır.")]
		public string BitisTarih { get; set; }

		[Display(Name = "Açıklama")]
		[StringLength(500, ErrorMessage = "Max 20 karakter olmalıdır.")]
		public string Aciklama { get; set; }
	}
}