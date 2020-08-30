using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAndEmployee
{
    class Information
    {
        public int Id { get; set; }
        public int SalaryAccount { get; set; }

        public Information(int id, int salaryAccount)
        {
            Id = id;
            SalaryAccount = salaryAccount;
        }
    }
}
