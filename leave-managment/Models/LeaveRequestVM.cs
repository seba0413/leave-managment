﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace leave_managment.Models
{
    public class LeaveRequestVM
    {
        public int Id { get; set; }
        public EmployeeVM RequestingEmployee { get; set; }
        [Display(Name ="Employee Name")]
        public string RequestingEmployeeId { get; set; }
        [Display(Name = "Start Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public LeaveTypeVM LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        [Display(Name = "Date Requested")]
        public DateTime DateRequested { get; set; }
        [Display(Name = "Date Actioned")]
        public DateTime DateActioned { get; set; }
        [Display(Name = "Approval State")]
        public bool? Approved { get; set; }
        public EmployeeVM ApprovedBy { get; set; }
        public string ApprovedById { get; set; }
    }

    public class AdminLeaveRequestViewVM
    {
        [Display(Name ="Total number of requests")] 
        public int TotalRequests { get; set; }
        [Display(Name ="Approved requests")]
        public int ApprovedRequests { get; set; }
        [Display(Name = "Pending requests")]
        public int PendingRequests { get; set; }
        [Display(Name = "Rejected requests")]
        public int RejectedRequests { get; set; }
        public List<LeaveRequestVM> LeaveRequests { get; set; }
    }

    public class CreateLeaveRequestVM
    {
        [Display(Name = "Start Date")]
        [Required]
        public string StartDate { get; set; }
        [Display(Name = "End Date")]
        [Required]
        public string EndDate { get; set; }
        public IEnumerable<SelectListItem> LeaveTypes { get; set; }
        [Display(Name ="Leave Type")]
        public int LeaveTypeId { get; set; }
    }

    public class EmployeeLeaveRequestVM
    {
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
        public List<LeaveRequestVM> LeaveRequests { get; set; }
    }
}
