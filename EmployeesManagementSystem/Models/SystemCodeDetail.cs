﻿using System.ComponentModel.DataAnnotations;

namespace EmployeesManagementSystem.Models
{
    public class SystemCodeDetail:UserActivity
    {
        [Key]
        public  int Id { get; set; }
        public  int SysteCodeId { get; set; }
        public SystemCode SystemCode { get; set; }
        public  string Code  { get; set; }
        public  string Description  { get; set; }
        public  int OrderNo { get; set; }
    }
}
