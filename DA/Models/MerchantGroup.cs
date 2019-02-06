using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.Models
{
    [Table("MerchantGroupView")]
  public  class MerchantGroup
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string description { get; set; }
    }
}
