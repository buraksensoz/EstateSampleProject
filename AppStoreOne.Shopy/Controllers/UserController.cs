using AppStoreOne.Business.Interfaces;
using AppStoreOne.Dtos.Dtos;
using AppStoreOne.Entities.Concrete;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStoreOne.Shopy.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;

        }

        public async Task<IActionResult> Index()
        {
            var userlist = await _userService.GetAllAsync();
            return View(_mapper.Map<List<UserListDto>>(userlist));
        }

        public IActionResult AddUser()
        {

            var model = new UserAddDto();

            return View(model);
        }
        [HttpPost]

        public async Task<IActionResult> AddUser(UserAddDto model)
        {
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<User>(model);
                await _userService.AddAsync(user);
                return RedirectToAction("index", "user");
            }
            return View(model);
        }

        public async Task<IActionResult> UpdateUser(int id)
        {

            var model = await _userService.FindByIdAsync(id);

            return View(_mapper.Map<UserUpdateDto>(model));

        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(UserUpdateDto model)
        {
            if (ModelState.IsValid)
            {

                var user = _mapper.Map<User>(model);
                await _userService.Update(user);
                return RedirectToAction("index", "user");

            }


            return View(model);

        }

        public async Task<IActionResult> DeleteUser(int id)
        {

            var model = await _userService.FindByIdAsync(id);
            if (model != null)
                await _userService.Remove(model);
            return RedirectToAction("index", "user");

        }

    }
}
