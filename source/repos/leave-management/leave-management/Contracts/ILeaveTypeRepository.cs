using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using leave_management.Data;

namespace leave_management.Contracts
{
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        Task<ICollection<LeaveType>> GetEmployeesByLeaveTypes(int id);
    }
}
