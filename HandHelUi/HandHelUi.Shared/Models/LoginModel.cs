using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandHelUi.Shared.Models
{
    internal class LoginModel
    {
        [Required]
        public string Pass_exp { get; set; }
        [Required]
        public string emp_code { get; set; }
        public string Token { get; set; }
        public string CompanyName { get; set; }
    }
}
