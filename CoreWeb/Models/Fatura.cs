using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWeb.Models
{
    public class Fatura
    {
        public int KullanilanMiktar { get; set; }

        public int AtikSuMiktari { get; set; }

        public decimal AraToplam { get; set; }

        public decimal AtikSuToplami { get; set; }

        public decimal GenelToplam {
            get {
                return AraToplam + AtikSuToplami;
                }
        }
    }
}
