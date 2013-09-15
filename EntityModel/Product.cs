using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Product_Name { get; set; }

        public string Product_Company { get; set; }

        public DateTime SignDate { get; set; }

        public DateTime UpdateData { get; set; }

    }
}
