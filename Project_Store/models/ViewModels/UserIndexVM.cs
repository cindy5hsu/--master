using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_Store.models.ViewModels
{
    public class UserIndexVM
    {
        public int Id { get; set; }
        public string Account { get; set; }
        // public string Password { get; set; }

        public string Name { get; set; }
    }
    public class UserVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "帳號必填AAA")]
        public string Account { get; set; }


        [Required(ErrorMessage = "密碼必填EEE")]
        //[EmailAddress(ErrorMessage ="Email格式有誤")]
        public string Password { get; set; }


        [Required(ErrorMessage = "姓名必填TTTT")]
        [StringLength(5, ErrorMessage = "姓名長度只能五個字")]
        public string Name { get; set; }

        public string FName { get; set; }

        public string DateOfBirth { get; set; }
        public string Major { get; set; }

        public string Gender { get; set; }
        public string gMail { get; set; }
        public string Depertment { get; set; }
        public string PhoneNo { get; set; }

        public byte Image { get; set; }
    }
}
