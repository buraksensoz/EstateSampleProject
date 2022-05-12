﻿using System;

namespace AppStoreOne.Entities.Concrete
{
    public class Estate : ITable
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Adres { get; set; }
        public string SiteAdi { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }
        public string Blok { get; set; }
        public string Kat { get; set; }
        public string DaireNo { get; set; }
        public string Ada { get; set; }
        public string Pafta { get; set; }
        public string Parsel { get; set; }
        public string Bilgi { get; set; }
        public int EmlakTipi { get; set; }
        public int M2 { get; set; }
        public int Oda { get; set; }
        public int Salon { get; set; }
        public int Banyo { get; set; }
        public int Mutfak { get; set; }
        public int Balkon { get; set; }
        public double Fiyat { get; set; }
        public int Islem { get; set; }
        public int Durum { get; set; }
        public Customer Sahip { get; set; }
        public int SahipId { get; set; }
        public DateTime IslemTarih { get; set; }
        public DateTime SonlanmaTarih { get; set; }




    }
}
