using AppStoreOne.Business.Enums;
using AppStoreOne.Business.Helper;
using AppStoreOne.Business.Interfaces;
using AppStoreOne.DocMakerHelper;
using AppStoreOne.DocMakerHelper.DocDtos;
using AppStoreOne.Dtos.Dtos;
using AppStoreOne.Dtos.EstateTypeDtos;
using AppStoreOne.Entities.Concrete;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using MimeKit;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStoreOne.Shopy.Controllers
{
    public class EstateController : Controller
    {
        private readonly IEstateService _estateService;
        private readonly IMapper _mapper;
        private readonly ICustomerService _customerService;
        private readonly IConfiguration _configuration;


        public EstateController(IEstateService estateService, IMapper mapper, ICustomerService customerService, IConfiguration configuration)
        {
            _estateService = estateService;
            _customerService = customerService;
            _mapper = mapper;
            _configuration = configuration;

        }




        public async Task<IActionResult> Index()
        {
            var model = _mapper.Map<List<EstateListDto>>(await _estateService.GetAllAsync());
            return View(model);
        }

        public async Task<IActionResult> AddDaire()
        {
            var model = new EstateDaireDto();
            model.EmlakTipi = (int)EnmEmlakTip.Daire;
            model.Durum = (int)EnmDurum.Aktif;
            List<Sehir> cities = AddressHelper.GetSehirList();
            List<Customer> customers = await _customerService.GetAllAsync();
            ViewBag.sehirler = new SelectList(cities, "Sehir_key", "Sehir_title");
            ViewBag.musteriler = new SelectList(customers, "Id", "MusteriAdi");

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddDaire(EstateDaireDto model)
        {
            if (ModelState.IsValid)
            {

                var NewEstate = _mapper.Map<Estate>(model);

                await _estateService.AddAsync(NewEstate);

                return RedirectToAction("Index", "Estate");
            }

            List<Sehir> cities = AddressHelper.GetSehirList();
            List<Ilce> ilceler = null;
            List<Mahalle> mahalleler = null;
            List<Customer> customers = await _customerService.GetAllAsync();
            ViewBag.sehirler = new SelectList(cities, "Sehir_key", "Sehir_title");


            if (!string.IsNullOrEmpty(model.Il))
                ilceler = AddressHelper.GetIlceList(model.Il);
            if (!string.IsNullOrEmpty(model.Ilce))
                mahalleler = AddressHelper.GetMahalleList(model.Ilce);


            ViewBag.ilceler = ilceler != null ? new SelectList(ilceler, "Ilce_key", "Ilce_title") : null;

            ViewBag.mahalleler = mahalleler != null ? new SelectList(mahalleler, "Mahalle_key", "Mahalle_title") : null;

            ViewBag.musteriler = new SelectList(customers, "Id", "MusteriAdi");


            return View(model);

        }


        public async Task<IActionResult> UpdateDaire(int id)
        {
            var model = _mapper.Map<EstateDaireDto>(await _estateService.FindByIdAsync(id));
            List<Sehir> cities = AddressHelper.GetSehirList();
            List<Ilce> ilceler = null;
            List<Mahalle> mahalleler = null;
            ViewBag.sehirler = new SelectList(cities, "Sehir_key", "Sehir_title");

            if (!string.IsNullOrEmpty(model.Il))
                ilceler = AddressHelper.GetIlceList(model.Il);
            if (!string.IsNullOrEmpty(model.Ilce))
                mahalleler = AddressHelper.GetMahalleList(model.Ilce);


            ViewBag.ilceler = ilceler != null ? new SelectList(ilceler, "Ilce_key", "Ilce_title") : null;

            ViewBag.mahalleler = mahalleler != null ? new SelectList(mahalleler, "Mahalle_key", "Mahalle_title") : null;

            List<Customer> customers = await _customerService.GetAllAsync();
            ViewBag.musteriler = new SelectList(customers, "Id", "MusteriAdi");

            return View(model);
        }



        [HttpPost]
        public async Task<IActionResult> UpdateDaire(EstateDaireDto model)
        {
            if (ModelState.IsValid)
            {

                var NewEstate = _mapper.Map<Estate>(model);

                await _estateService.Update(NewEstate);

                return RedirectToAction("Index", "Estate");
            }

            List<Sehir> cities = AddressHelper.GetSehirList();
            List<Ilce> ilceler = null;
            List<Mahalle> mahalleler = null;
            List<Customer> customers = await _customerService.GetAllAsync();
            ViewBag.sehirler = new SelectList(cities, "Sehir_key", "Sehir_title");


            if (!string.IsNullOrEmpty(model.Il))
                ilceler = AddressHelper.GetIlceList(model.Il);
            if (!string.IsNullOrEmpty(model.Ilce))
                mahalleler = AddressHelper.GetMahalleList(model.Ilce);


            ViewBag.ilceler = ilceler != null ? new SelectList(ilceler, "Ilce_key", "Ilce_title") : null;

            ViewBag.mahalleler = mahalleler != null ? new SelectList(mahalleler, "Mahalle_key", "Mahalle_title") : null;

            ViewBag.musteriler = new SelectList(customers, "Id", "MusteriAdi");


            return View(model);

        }





        public JsonResult LoadIlce(string sehir_key)
        {
            var Ilce = AddressHelper.GetIlceList(sehir_key);
            return Json(new SelectList(Ilce, "Ilce_key", "Ilce_title"));

        }

        public JsonResult LoadMahalle(string ilce_key)
        {
            var Mahalle = AddressHelper.GetMahalleList(ilce_key);
            return Json(new SelectList(Mahalle, "Mahalle_key", "Mahalle_title"));

        }

        public async Task<JsonResult> GetCustomer(int id)
        {
            var customer = await _customerService.FindByIdAsync(id);
            return Json(JsonConvert.SerializeObject(customer));

        }


        public async Task<IActionResult> KiraKontCreate(int id)
        {

            var estate = await _estateService.FindByIdAsync(id);
            var sahip = await _customerService.FindByIdAsync(estate.SahipId);

            KonutDocDto doc = new KonutDocDto();

            doc.SehirIlce = AddressHelper.GetSehir(estate.Il).Sehir_title + "\\" + AddressHelper.GetIlce(estate.Ilce).Ilce_title;
            doc.Mahalle = AddressHelper.GetMahalle(estate.Semt).Mahalle_title;
            doc.CaddeSokak = estate.Adres;
            doc.KiraDurumu = "Boş";
            doc.BlokNo = estate.SiteAdi + " " + estate.Blok + " " + estate.DaireNo;
            doc.KiraBedel = estate.Fiyat;
            doc.SozlesmeTarih = DateTime.Now.Date;
            doc.Sahip = sahip.MusteriAdi;
            doc.SahipAdres = sahip.Adres1;
            doc.SahipKimlik = sahip.IdentityNo;
            doc.KiraKullanimSekli = "Mesken";
            doc.SozSureAy = "12 Ay";
            doc.KiraOdemeSekli = "Banka Hesabına";
            doc.Mahkeme = doc.SehirIlce;
            doc.Banka = sahip.Banka;
            doc.BankaSube = sahip.BankaSube;
            doc.Iban = sahip.Iban;
            doc.Depozito = doc.KiraBedel;
            doc.KiraCins = "Konut";



            ViewBag.musteriler = new SelectList(
                await _customerService.GetAllAsync(), "Id", "MusteriAdi");


            return View(doc);


        }

        [HttpPost]
        public async Task<IActionResult> KiraKontCreate(KonutDocDto doc)
        {
            doc.KiraBedelYil = doc.KiraBedel * 12;
            var exportedfile = DocMaker.CreateKiraDoc(doc);
            var filelocation = _configuration["StaticLocalHostAddress"] + "docs/" + exportedfile + ".docx";
            var bytes = await DownloadHelper.DownloadFile(filelocation);
            if (bytes != null)
            {
                return File(bytes, MimeTypes.GetMimeType("KiraKontrat.docx"), "KiraKontrat.docx");
            }

            ViewBag.musteriler = new SelectList(
                await _customerService.GetAllAsync(), "Id", "MusteriAdi");

            return View(doc);
        }
    }
}
