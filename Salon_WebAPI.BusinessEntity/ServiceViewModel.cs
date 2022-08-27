using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_WebAPI.BusinessEntity
{
    public class ServiceViewModel
    {
        public int Id { get; set; }
        public string SericeName { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Description { get; set; }
        public Nullable<int> ServiceCategoryId { get; set; }
    }
}
