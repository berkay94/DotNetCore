using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }

       

        public IActionResult Sayac(Iski k)
        {

            Fatura fat=getFatura(k);
          
            return View(fat);
        }

        public Fatura getFatura(Iski q)
        {
            Fatura fatura = new Fatura();
            fatura.KullanilanMiktar = q.sonSayac - q.ilkSayac;
          
            fatura.AtikSuToplami = (decimal)(fatura.KullanilanMiktar * 0.3);
            double birimfiyat = q.meskenTipi == "Umumi" ? 0.9 : 1.3;
            fatura.AraToplam = (decimal)(fatura.KullanilanMiktar * birimfiyat);

            return fatura;


        }
    }
}