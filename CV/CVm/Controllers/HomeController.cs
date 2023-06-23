using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using CV.Data;
using CV.Models;

namespace CV.Controllers
{

	public class HomeController : Controller
	{
		DataContext db = new DataContext();

		public ActionResult Index()
		{

			return View();
		}

		public PartialViewResult HeadPartial()
		{
			return PartialView();
		}

		public PartialViewResult FooterPartial()
		{

			ViewBag.dgr = db.Kisis.Find(1);
			var deger = db.Ikonlars.ToList();
			return PartialView(deger);
		}

		public PartialViewResult Kunye()
		{
			ViewBag.dgr = db.Ikonlars.ToList();
			var deger = db.Kisis.Find(1);
			return PartialView(deger);
		}

		public PartialViewResult Hakkimizda()
		{

			ViewBag.dgr = db.Hakkimdas.ToList();
			var deger = db.HKisiselBilgilers.ToList();
			return PartialView(deger);
		}

		public PartialViewResult Navbar()
		{
			var deger = db.Kisis.Find(1);
			return PartialView(deger);
		}

		public PartialViewResult Yetenekler()
		{
			var deger = db.Yeteneks.ToList();

			return PartialView(deger);
		}

		public PartialViewResult Tecrubeler()
		{
			var deger = db.Tecrubes.ToList();
			return PartialView(deger);
		}

		public PartialViewResult Egitimler()
		{
			var deger = db.Egitims.ToList();
			return PartialView(deger);
		}

		public PartialViewResult Portfolyo()
		{
			ViewBag.dgr = db.HKisiselBilgilers.Find(5);
			var deger = db.Portfolyos.ToList();
			return PartialView(deger);
		}

		public PartialViewResult Referanslar()
		{
			var deger = db.Referanslars.ToList();
			return PartialView(deger);
		}
		[HttpGet]
		public PartialViewResult Iletisim()
		{
			ViewBag.dgr = db.HKisiselBilgilers.Where(x => x.Ad == "Email").FirstOrDefault();
			//ViewBag.dgr2 = db.Iletisims.Find(1);
			//ViewBag.Message = "";
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult Iletisim(Iletisim i)
		{
			ViewBag.dgr = db.HKisiselBilgilers.Where(x => x.Ad == "Email").FirstOrDefault();
			//ViewBag.dgr2 = db.Konums.Find(1);
			var deger = db.HKisiselBilgilers.Where(x => x.Ad == "Email").FirstOrDefault();
			try
			{
				string senderName = i.Ad;
				string senderEmail = i.Email;
				string message = i.Mesaj;
				Iletisim ileti = new Iletisim();
				ileti.Ad = senderName;
				ileti.Email = senderEmail;
				ileti.Mesaj = message;
				db.Iletisims.Add(i);
				db.SaveChanges();

				ViewBag.Message = "Mesajınız başarıyla gönderildi!";

			}
			catch (Exception ex)
			{

				ViewBag.Message = "Mesaj gönderilirken bir hata oluştu: " + ex.Message;
			}

			return PartialView();
		}

	}




}
