using AppStoreOne.Business.Interfaces;
using AppStoreOne.Dtos.Dtos;
using AppStoreOne.Entities.Concrete;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStoreOne.Shopy.Controllers
{
    public class CustomerController : Controller
    {

        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        public CustomerController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var customerList = await _customerService.GetAllAsync();
            return View(_mapper.Map<List<CustomerListDto>>(customerList));
        }

        public IActionResult AddCustomer()
        {

            return View(new CustomerAddDto());
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomerAsync(CustomerAddDto model)
        {
            if (ModelState.IsValid)
            {
                await _customerService.AddAsync(_mapper.Map<Customer>(model));
                return RedirectToAction("index", "customer");

            }


            return View(model);
        }


        public async Task<IActionResult> UpdateCustomer(int id)
        {
            var model = await _customerService.FindByIdAsync(id);

            return View(_mapper.Map<CustomerUpdateDto>(model));
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCustomer(CustomerUpdateDto model)
        {
            if (ModelState.IsValid)
            {

                await _customerService.Update(_mapper.Map<Customer>(model));
                return RedirectToAction("index", "customer");
            }

            return View(model);
        }

        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var model = await _customerService.FindByIdAsync(id);
            await _customerService.Remove(model);
            return RedirectToAction("index", "customer");

        }

    }
}
