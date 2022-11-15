using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApi.Models
{
    public class TestData
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; } = false;
    }
}
