using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }
        [Display(Name="Введите имя")]
        [StringLength(20)]
        [Required(ErrorMessage ="длина имени не менее 20 символов")]
        public string Name { get; set; }
        public string SurName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
