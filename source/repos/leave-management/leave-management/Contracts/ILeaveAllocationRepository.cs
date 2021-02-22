using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using leave_management.Data;

namespace leave_management.Contracts
{
    public interface ILeaveAllocationRepository : IRepositoryBase<LeaveAllocation>
    {
        Task<bool> CheckAllocation(int leavetypeid, string employeeid);
        Task<ICollection<LeaveAllocation>> GetLeaveAllocationsByEmployee(string employeeid);
        Task<LeaveAllocation> GetLeaveAllocationsByEmployeeAndType(string employeeid, int leavetypeid);
    }
}
