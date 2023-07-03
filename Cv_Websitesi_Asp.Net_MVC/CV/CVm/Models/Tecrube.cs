using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace CV.Models
{
	public class Tecrube
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Boş geçilemez.")]
		[Display(Name = "İşin Tanımı")]
		[StringLength(150, ErrorMessage = "Max 150 karakter olmalıdır.")]
		public string YapilanIs { get; set; }
		[Required(ErrorMessage = "Boş geçilemez.")]
		[Display(Name = "İşyeri")]
		[StringLength(150, ErrorMessage = "Max 150 karakter olmalıdır.")]
		public string IsyeriAdi { get; set; }

		[Required(ErrorMessage = "Boş geçilemez.")]
		[Display(Name = "Başlama Tarihi")]
		[StringLength(20, ErrorMessage = "Max 20 karakter olmalıdır.")]
		public string BaslangicTarihi { get; set; }

		[Required(ErrorMessage = "Boş geçilemez.")]
		[Display(Name = "Bitiş tarihi")]
		[StringLength(20, ErrorMessage = "Max 20 karakter olmalıdır.")]
		public string Bitistarihi { get; set; }

		[Display(Name = "Açıklama")]
		[StringLength(500, ErrorMessage = "Max 500 karakter olmalıdır.")]
		public string Aciklama { get; set; }

	}
}