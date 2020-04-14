using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set;}

        [Display(Name="Введіть ім'я")]
        [StringLength(15)]
        [Required(ErrorMessage ="Ім'я не більше 15 символів")]
        public string name { get; set; }

        [Display(Name = "Введіть прізвище")]
        [StringLength(15)]
        [Required(ErrorMessage = "Прізвище не більше 15 символів")]
        public string surname { get; set; }

        [Display(Name = "Введіть адрес")]
        [StringLength(25)]
        [Required(ErrorMessage = "Адрес не більше 25 символів")]
        public string adress { get; set; }

        [Display(Name = "Введіть свій телефон")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Телефон не більше 10 символів")]
        public string phone { get; set; }

        [Display(Name = "Введіть пошту")]
        [StringLength(40)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Пошта не більше 20 символів")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}