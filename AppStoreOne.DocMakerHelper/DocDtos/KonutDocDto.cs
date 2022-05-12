using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppStoreOne.DocMakerHelper.DocDtos
{
    public class KonutDocDto
    {
        public string SehirIlce { get; set; } = "";
        public string Mahalle { get; set; } = "";
        public string CaddeSokak { get; set; } = "";
        public string BlokNo { get; set; } = "";
        public string KiraCins { get; set; } = "";
        public string Sahip { get; set; } = "";
        public string SahipKimlik { get; set; } = "";
        public string SahipAdres { get; set; } = "";

        public int KiraciId { get; set; }=0 ;
        public string Kiraci { get; set; } = "";
        public string KiraciKimlik { get; set; } = "";
        public string KiraciAdres { get; set; } = "";

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime SozlesmeTarih { get; set; } = DateTime.Now;
        public string SozSureAy { get; set; } = "";
        public double KiraBedel { get; set; } = 0;
        public double KiraBedelYil { get; set; } = 0;

        public string KiraOdemeSekli { get; set; } = "";
        public string KiraKullanimSekli { get; set; } = "";
        public string KiraDurumu { get; set; } = "";
        public string DemirBasListe { get; set; } = " ";

        public string Banka { get; set; } = "";

        public string BankaSube { get; set; } = "";
        public string Iban { get; set; } = "";

        public string Mahkeme { get; set; } = "";

        public string Kefil { get; set; } = "";
        public double Depozito { get; set; } = 0;





    }
}
