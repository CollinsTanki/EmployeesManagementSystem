﻿namespace EmployeesManagementSystem.Models
{
    public class Bank:UserActivity
    {
        public  int Id { get; set; }
        public  int Code { get; set; }
        public  string Name { get; set; }
        public  string AccountNo { get; set; }
    }
}
