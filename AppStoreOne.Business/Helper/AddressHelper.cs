using AppStoreOne.Entities.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AppStoreOne.Business.Helper
{
    public static class AddressHelper
    {

        public static  List<Sehir> GetSehirList() { 
            var cityFile = Path.Combine(Directory.GetCurrentDirectory(), $"JsonData\\sehir.json");
            var JSON = System.IO.File.ReadAllText(cityFile);
            var sehirler= JsonConvert.DeserializeObject<List<Sehir>>(JSON);
            return sehirler.OrderBy(I => I.Sehir_title).ToList();
        }

        public static List<Ilce> GetIlceList(string sehirkey)
        {
            var ilceFile = Path.Combine(Directory.GetCurrentDirectory(), $"JsonData\\Ilce.json");
            var JSON = System.IO.File.ReadAllText(ilceFile);
            var ilceler= JsonConvert.DeserializeObject<List<Ilce>>(JSON);
            return ilceler.Where(I => I.Ilce_sehirkey == sehirkey).OrderBy(I => I.Ilce_title).ToList();
        }

        public static List<Mahalle> GetMahalleList(string ilcekey)
        {
            var mahalleFile = Path.Combine(Directory.GetCurrentDirectory(), $"JsonData\\mahalle.json");
            var JSON = System.IO.File.ReadAllText(mahalleFile);
            var mahalleler = JsonConvert.DeserializeObject<List<Mahalle>>(JSON);
            return mahalleler.Where(I => I.Mahalle_ilcekey == ilcekey).OrderBy(I => I.Mahalle_title).ToList();
        }

        public static Sehir GetSehir(string sehirkey)
        {
            var file = Path.Combine(Directory.GetCurrentDirectory(), $"JsonData\\sehir.json");
            var JSON = System.IO.File.ReadAllText(file);
            var listitem = JsonConvert.DeserializeObject<List<Sehir>>(JSON);
            return listitem.Where(I => I.Sehir_key == sehirkey).FirstOrDefault();
        }
        public static Ilce GetIlce(string ilcekey)
        {
            var file = Path.Combine(Directory.GetCurrentDirectory(), $"JsonData\\Ilce.json");
            var JSON = System.IO.File.ReadAllText(file);
            var listitem = JsonConvert.DeserializeObject<List<Ilce>>(JSON);
            return listitem.Where(I => I.Ilce_key == ilcekey).FirstOrDefault();
        }

        public static Mahalle GetMahalle(string mahalleKey)
        {
            var file = Path.Combine(Directory.GetCurrentDirectory(), $"JsonData\\mahalle.json");
            var JSON = System.IO.File.ReadAllText(file);
            var listitem = JsonConvert.DeserializeObject<List<Mahalle>>(JSON);
            return listitem.Where(I => I.Mahalle_key == mahalleKey).FirstOrDefault();
        }

    }
}
