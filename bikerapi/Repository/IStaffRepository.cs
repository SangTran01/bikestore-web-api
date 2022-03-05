using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using bikerapi.Models;

namespace bikerapi.Repository
{
    public interface IStaffRepository
    {
        public Task<IEnumerable<Staff>> GetStaffs();
    }
}
