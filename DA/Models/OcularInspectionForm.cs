using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.Models
{
   public class OcularInspectionForm:BaseEntity
    {

        public int Id { get; set; }
        public Boolean waived { get; set; }
        public string outletAddress { get; set; }

        public string outletContactPerson { get; set; }

        public string outletContactPosition { get; set; }

        public string outletTelephoneNo { get; set; }

        public string outletMobileNo { get; set; }

        public Nullable<int> outletTypeOfBusiness { get; set; }

        public string natureOfBusiness { get; set; }

        public string noOfYearsOperating { get; set; }

        public string businessHours { get; set; }

        public Nullable<int> noOfEmployeesFullTime { get; set; }

        public Nullable<int> noOfEmployeesContractual { get; set; }

        public Nullable<int> premiseStatus { get; set; }

        public string lengthOfStay { get; set; }

        public Nullable<int> location { get; set; }

        public string businessSignage { get; set; }

        public Nullable<int> premiseType { get; set; }

        public string interiorAppearance { get; set; }

        public string exteriorAppearance { get; set; }

        public string stocks { get; set; }

        public string equipment { get; set; }

        public string floorArea { get; set; }

        public Nullable<bool> withHighTraffic { get; set; }

        public string establishments { get; set; }

        public string motoMarketingChannel { get; set; }

        public Nullable<int> averageTransactions { get; set; }

        public string nameOfEvent { get; set; }

        public string venue { get; set; }

        public Nullable<int> typeOfEvent { get; set; }

        public Nullable<int> expectedNoOfBuyers { get; set; }

        public string products { get; set; }

        public string priceRange { get; set; }

        public Nullable<int> noOfParticipants { get; set; }

        public string averageRegistration { get; set; }

        public string inclusiveDateOfEvent { get; set; }

        public string nameOfLastEvent { get; set; }

        public string venueOfLastEvent { get; set; }

        public Nullable<System.DateTime> dateOfLastEvent { get; set; }

        public string totalSales { get; set; }

        public string nameOfLastAcquirer { get; set; }

        public string adverseFindings { get; set; }

        public string incompleteReport { get; set; }

        public string remarks { get; set; }

       

        public bool outskirt { get; set; }

        //public virtual Branch Branch { get; set; }
    }
}
