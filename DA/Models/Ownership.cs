using System.ComponentModel.DataAnnotations.Schema;

namespace DA.Models
{
    [Table("OwnershipTypeView")]
    public class Ownership 
    {
        
        public int Id { get; set; }
        public string Code { get; set; }
        public string description { get; set; }

    }
}