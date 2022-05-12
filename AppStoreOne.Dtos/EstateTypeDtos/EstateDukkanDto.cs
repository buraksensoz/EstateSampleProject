using System;
using System.Collections.Generic;
using System.Text;

namespace AppStoreOne.Dtos.EstateTypeDtos
{
    public class EstateDukkanDto:EstateDto
    {
        public string SiteAdi { get; set; }
        public string Blok { get; set; }
        public string Kat { get; set; }
        public string DaireNo { get; set; }
        public int Banyo { get; set; }
        public int Mutfak { get; set; }

    }
}
