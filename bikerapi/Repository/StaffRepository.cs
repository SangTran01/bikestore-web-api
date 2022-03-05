using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using bikerapi.Models;
using Microsoft.EntityFrameworkCore;

namespace bikerapi.Repository
{
    public class StaffRepository: IStaffRepository
    {
        private readonly BikeStoresContext _context;
        public StaffRepository(BikeStoresContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Staff>> GetStaffs()
        {
            return await _context.Staffs.ToListAsync();
        }
    }
}
