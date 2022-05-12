using AppStoreOne.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStoreOne.Dtos.EstateTypeDtos
{
    public class EstateDto
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Adres { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }
        public string Bilgi { get; set; }
        public int EmlakTipi { get; set; }
        public int M2 { get; set; }
        public double Fiyat { get; set; }
        public int Islem { get; set; }
        public int Durum { get; set; }
        public Customer Sahip { get; set; }
        public int SahipId { get; set; }
        public DateTime IslemTarih { get; set; }
        public DateTime SonlanmaTarih { get; set; }



    }
}
