using System.Collections.Generic;

namespace AppStoreOne.Entities.Concrete
{
    public class Customer : ITable
    {
        public int Id { get; set; }
        public string MusteriAdi { get; set; }
        public string Telefon { get; set; }
        public string Gsm { get; set; }
        public string Fax { get; set; }
        public string Adres1 { get; set; }
        public string Adres2 { get; set; }
        public string Eposta { get; set; }
        public string Web { get; set; }
        public string IdentityNo { get; set; }
        public string MusteriBilgi { get; set; }
        public int MusteriTip { get; set; }
        public List<Estate> Estates { get; set; }

        public string Banka { get; set; }

        public string BankaSube { get; set; }
        public string Iban { get; set; }
    }
}
