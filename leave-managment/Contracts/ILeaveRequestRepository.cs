using leave_managment.Data;
using System.Collections.Generic;

namespace leave_managment.Contracts
{
    public interface ILeaveRequestRepository : IRepositoryBase<LeaveRequest>
    {
        ICollection<LeaveRequest> GetLeaveRequestsByEmployee(string employeeId);
    }
}
