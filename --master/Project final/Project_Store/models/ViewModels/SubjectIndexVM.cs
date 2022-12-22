using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Store.models.ViewModels
{
    public class SubjectIndexVM
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public string ProductName { get; set; }
        public string Major_Subject { get; set; }
        public int Price_Per_Hour { get; set; }

    }

    public class SubjectVM
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string Major_Subject { get; set; }

        public int Price_Per_Hour { get; set; }


        public int ListPrice { get; set; }

        public string FName { get; set; }

        public string DateOfBirth { get; set; }
        public string Major { get; set; }

        public string Gender { get; set; }
        public string gMail { get; set; }
        public string Depertment { get; set; }
        public string PhoneNo { get; set; }

        public byte Photo { get; set; }
    }
}
