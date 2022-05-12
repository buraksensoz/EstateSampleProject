using AppStoreOne.DocMakerHelper.DocDtos;
using AppStoreOne.DocMakerHelper.Enums;
using Spire.Doc;
using System;
using System.IO;

namespace AppStoreOne.DocMakerHelper
{
    public static class DocMaker
    {
        public static string CreateKiraDoc(KonutDocDto docDto) {
            var docFile = Path.Combine(Directory.GetCurrentDirectory(), @"Docs\konutkirasozlesme.docx");
            Document doc = new Document();
            doc.LoadFromFile(docFile);

            doc.Replace(GetDocField(EnmDocStatic.SehirIlce), IsNull(docDto.SehirIlce),true,true);
            doc.Replace(GetDocField(EnmDocStatic.Mahalle), IsNull(docDto.Mahalle), true, true);
            doc.Replace(GetDocField(EnmDocStatic.CaddeSokak), IsNull(docDto.CaddeSokak), true, true);
            doc.Replace(GetDocField(EnmDocStatic.BlokNo), IsNull(docDto.BlokNo), true, true);
            doc.Replace(GetDocField(EnmDocStatic.KiraCins), IsNull(docDto.KiraCins), true, true);
            doc.Replace(GetDocField(EnmDocStatic.Sahip), IsNull(docDto.Sahip), true, true);
            doc.Replace(GetDocField(EnmDocStatic.SahipKimlik), IsNull(docDto.SahipKimlik), true, true);
            doc.Replace(GetDocField(EnmDocStatic.SahipAdres), IsNull(docDto.SahipAdres), true, true);
            doc.Replace(GetDocField(EnmDocStatic.Kiraci), IsNull(docDto.Kiraci), true, true);
            doc.Replace(GetDocField(EnmDocStatic.KiraciKimlik), IsNull(docDto.KiraciKimlik), true, true);
            doc.Replace(GetDocField(EnmDocStatic.KiraciAdres), IsNull(docDto.KiraciAdres), true, true);
            doc.Replace(GetDocField(EnmDocStatic.SozlesmeTarih), IsNull(docDto.SozlesmeTarih.ToString("dd/MM/yyyy")), true, true);
            doc.Replace(GetDocField(EnmDocStatic.SozSureAy), IsNull(docDto.SozSureAy), true, true);
            doc.Replace(GetDocField(EnmDocStatic.KiraBedel), IsNull(String.Format("{0:0,0.00 ₺}", docDto.KiraBedel)), true, true);
            doc.Replace(GetDocField(EnmDocStatic.KiraBedelYil), IsNull(String.Format("{0:0,0.00 ₺}", docDto.KiraBedelYil)), true, true);
            doc.Replace(GetDocField(EnmDocStatic.KiraOdemeSekli), IsNull(docDto.KiraOdemeSekli), true, true);
            doc.Replace(GetDocField(EnmDocStatic.KiraKullanimSekli), IsNull(docDto.KiraKullanimSekli), true, true);
            doc.Replace(GetDocField(EnmDocStatic.KiraDurumu), IsNull(docDto.KiraDurumu), true, true);
            doc.Replace(GetDocField(EnmDocStatic.DemirBasListe), IsNull(docDto.DemirBasListe), true, true);            
            doc.Replace(GetDocField(EnmDocStatic.Depozito), IsNull(String.Format("{0:0,0.00 ₺}", docDto.Depozito)), true, true);
            doc.Replace(GetDocField(EnmDocStatic.Kefil), IsNull(docDto.Kefil), true, true);
            doc.Replace(GetDocField(EnmDocStatic.Banka), IsNull(docDto.Banka), true, true);
            doc.Replace(GetDocField(EnmDocStatic.BankaSube), IsNull(docDto.BankaSube), true, true);
            doc.Replace(GetDocField(EnmDocStatic.Iban), IsNull(docDto.Iban), true, true);
            doc.Replace(GetDocField(EnmDocStatic.Mahkeme), IsNull(docDto.Mahkeme), true, true);



            var guidCode = Guid.NewGuid().ToString();

            var savedocFile = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\docs\"+ guidCode + ".docx");
            doc.SaveToFile(savedocFile);
            doc.Close();
            return guidCode;

        }

        private static string GetDocField(string fName){ return "##" + fName + "##"; }

        private static string IsNull(string fName) { if (string.IsNullOrEmpty(fName)) return ""; else return fName; }
    }
}
