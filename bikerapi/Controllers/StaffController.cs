using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bikerapi.Models;
using bikerapi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bikerapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StaffController : ControllerBase
    {
        private readonly IStaffRepository _staffRepository;
        public StaffController(IStaffRepository staffRepository) {
            _staffRepository = staffRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Staff>> GetStaffs()
        {
            var res = await _staffRepository.GetStaffs();
            return res;
        }
    }
}
