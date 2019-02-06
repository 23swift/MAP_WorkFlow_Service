using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAS_WorkFlowService
{
    public static class RequestState
    {
        
        public static RequestConfigElement DRAFT
        {
            get
            {
                return RequestConfigHelper.GetStatus("DRAFT");
            }
        }
        public static RequestConfigElement AO_CHECKING
        {
            get
            {
                return RequestConfigHelper.GetStatus("AO_CHECKING");
            }
        }
        public static RequestConfigElement MAU_ENCODING
        {
            get
            {
                return RequestConfigHelper.GetStatus("MAU_ENCODING");
            }
        }
        public static RequestConfigElement MAU_CHECKING
        {
            get
            {
                return RequestConfigHelper.GetStatus("MAU_CHECKING");
            }
        }
        public static RequestConfigElement MAU_SCREENING
        {
            get
            {
                return RequestConfigHelper.GetStatus("MAU_SCREENING");
            }
        }
        public static RequestConfigElement RE_SUBMITTED
        {
            get
            {
                return RequestConfigHelper.GetStatus("RE_SUBMITTED");
            }
        }
        public static RequestConfigElement FOR_APPROVAL_WITH_REQUIREMENTS
        {
            get
            {
                return RequestConfigHelper.GetStatus("FOR_APPROVAL_WITH_REQUIREMENTS");
            }
        }
        public static RequestConfigElement APPROVED_WITH_REQUIREMENTS
        {
            get
            {
                return RequestConfigHelper.GetStatus("APPROVED_WITH_REQUIREMENTS");
            }
        }
        public static RequestConfigElement FOR_APPROVAL_WITH_EXCEPTIONS
        {
            get
            {
                return RequestConfigHelper.GetStatus("FOR_APPROVAL_WITH_EXCEPTIONS");
            }
        }
        public static RequestConfigElement FOR_APPROVAL1
        {
            get
            {
                return RequestConfigHelper.GetStatus("FOR_APPROVAL1");
            }
        }
        public static RequestConfigElement FOR_APPROVAL
        {
            get
            {
                return RequestConfigHelper.GetStatus("FOR_APPROVAL");
            }
        }
        public static RequestConfigElement FOR_APPROVAL2
        {
            get
            {
                return RequestConfigHelper.GetStatus("FOR_APPROVAL2");
            }
        }
        public static RequestConfigElement APPROVED1
        {
            get
            {
                return RequestConfigHelper.GetStatus("APPROVED1");
            }
        }
        public static RequestConfigElement APPROVED
        {
            get
            {
                return RequestConfigHelper.GetStatus("APPROVED");
            }
        }
        public static RequestConfigElement APPROVED2
        {
            get
            {
                return RequestConfigHelper.GetStatus("APPROVED2");
            }
        }
        public static RequestConfigElement FOR_CADENCIE_PROCESSING
        {
            get
            {
                return RequestConfigHelper.GetStatus("FOR_CADENCIE_PROCESSING");
            }
        }
        public static RequestConfigElement COMPLETED
        {
            get
            {
                return RequestConfigHelper.GetStatus("COMPLETED");
            }
        }
        public static RequestConfigElement CLOSED
        {
            get
            {
                return RequestConfigHelper.GetStatus("CLOSED");
            }
        }
        public static RequestConfigElement DELETED
        {
            get
            {
                return RequestConfigHelper.GetStatus("DELETED");
            }
        }
        public static RequestConfigElement RETURNED
        {
            get
            {
                return RequestConfigHelper.GetStatus("RETURNED");
            }
        }
        public static RequestConfigElement RETURNED_TO_MAU
        {
            get
            {
                return RequestConfigHelper.GetStatus("RETURNED_TO_MAU");
            }
        }
        public static RequestConfigElement DECLINED
        {
            get
            {
                return RequestConfigHelper.GetStatus("DECLINED");
            }
        }
        public static RequestConfigElement RETURNED_TO_AO
        {
            get
            {
                return RequestConfigHelper.GetStatus("RETURNED_TO_AO");
            }
        }

        public static RequestConfigElement FOR_POS_PROCESSING
        {
            get
            {
                return RequestConfigHelper.GetStatus("FOR_POS_PROCESSING");
            }
        }
        public static RequestConfigElement FOR_QC_REVIEW
        {
            get
            {
                return RequestConfigHelper.GetStatus("FOR_QC_REVIEW");
            }
        }
        public static RequestConfigElement PS_SERVICING
        {
            get
            {
                return RequestConfigHelper.GetStatus("PS_SERVICING");
            }
        }
        public static RequestConfigElement MDCS_PROCESSING
        {
            get
            {
                return RequestConfigHelper.GetStatus("MDCS_PROCESSING");
            }
        }
        public static RequestConfigElement RETURN_TO_MAKER
        {
            get
            {
                return RequestConfigHelper.GetStatus("RETURN_TO_MAKER");
            }
        }
        public static RequestConfigElement MQR_RETURN_TO_AO
        {
            get
            {
                return RequestConfigHelper.GetStatus("MQR_RETURN_TO_AO");
            }
        }
        public static RequestConfigElement MQR_FOR_APPROVAL
        {
            get
            {
                return RequestConfigHelper.GetStatus("MQR_FOR_APPROVAL");
            }
        }
        public static RequestConfigElement MQR_COMPLETE
        {
            get
            {
                return RequestConfigHelper.GetStatus("MQR_COMPLETE");
            }
        }
        public static RequestConfigElement MQR_SUBMITTED
        {
            get
            {
                return RequestConfigHelper.GetStatus("MQR_SUBMITTED");
            }
        }

        
    }

   public static class RequestStatusConstants
    {
        public const string DRAFT = "DRAFT";
        public const string AO_CHECKING = "AO_CHECKING";
        public const string MAU_SCREENING = "MAU_SCREENING";
        public const string RE_SUBMITTED = "RE_SUBMITTED";
        public const string APPROVED_WITH_EXCEPTIONS = "APPROVED_WITH_EXCEPTIONS";
        public const string APPROVED = "APPROVED";
        public const string RETURN_TO_MAKER = "RETURN_TO_MAKER";
        public const string MDCS_PROCESSING = "MDCS_PROCESSING";
        

    }
    public static class RequestTypeConstants
    {
        public const string NEW_AFFILIATION = "NEW_AFFILIATION";
        public const string BRANCH_AFFILIATION = "BRANCH_AFFILIATION";
        public const string TID_ISSUANCE_TAGGING = "TID_ISSUANCE_TAGGING";
        public const string POS = "POS";
        public const string FILE_MAINTENANCE = "FILE_MAINTENANCE";
        public const string ADDITIONAL_FACILITY = "ADDITIONAL_FACILITY";
      

    }
    // <add name = "NEW_AFFILIATION" displayName="NEW AFFILIATION" value="1" view="NewAffiliaton" />
    //<add name = "BRANCH_AFFILIATION" displayName="BRANCH AFFILIATION" value="2" view="BranchAffiliaton"/>
    //<add name = "TID_ISSUANCE_TAGGING" displayName="TID Issuance Tagging" value="3" view="NewAffiliaton"/>
    //<add name = "POS" displayName="POS Request" value="4" view="POS"/>
    //<add name = "FILE_MAINTENANCE" displayName="FILE MAINTENANCE" value="5" view="FileMaintenance" />
    //<add name = "ADDITIONAL_FACILITY" displayName="ADDITIONAL FACILITY" value="6" view="AdditionalFacility" />
    //<add name = "DRAFT" displayName="DRAFT" value="1" view="Draft" />
    //<add name = "AO_CHECKING" displayName="FOR AO CHECKING" value="2" view="AOChecking" />
    //<add name = "MAU_SCREENING" displayName="FOR MAU SCREENING" value="3" view="MAUScreening" />
    //<add name = "RE_SUBMITTED" displayName="RE-SUBMITTED" value="4" view="Draft" />
    //<add name = "FOR_APPROVAL_WITH_REQUIREMENTS" displayName="FOR APPROVAL WITH REQUIREMENTS" value="5" view="Draft" />
    //<add name = "APPROVED_WITH_REQUIREMENTS" displayName="APPROVED WITH REQUIREMENTS" value="6" view="Draft" />
    //<add name = "FOR_APPROVAL_WITH_EXCEPTIONS" displayName="FOR APPROVAL WITH EXCEPTIONS" value="7" view="Draft" />
    //<add name = "APPROVED_WITH_EXCEPTIONS" displayName="APPROVED WITH EXCEPTIONS" value="8" view="Draft" />
    //<add name = "FOR_APPROVAL1" displayName="FOR FIRST APPROVAL" value="9" view="Approval1" />
    //<add name = "FOR_APPROVAL2" displayName="FOR SECOND APPROVAL" value="10" view="Approval2" />
    //<add name = "APPROVED1" displayName="APPROVED" value="11" view="Draft" />
    //<add name = "APPROVED2" displayName="APPROVED" value="12" view="Draft" />
    //<add name = "FOR_CADENCIE_PROCESSING" displayName="FOR CADENCIE PROCESSING" value="13" view="Draft" />
    //<add name = "COMPLETED" displayName="COMPLETED" value="14" view="Draft" />
    //<add name = "CLOSED" displayName="CLOSED" value="15" view="Draft" />
    //<add name = "DELETED" displayName="DELETED" value="16" view="Draft" />
    //<add name = "RETURNED" displayName="RETURNED" value="17" view="Draft" />
    //<add name = "RETURNED_TO_MAU" displayName="RETURNED TO MAU" value="18" view="Draft" />
    //<add name = "DECLINED" displayName="DECLINED" value="19" view="Draft" />
    //<add name = "RETURNED_TO_AO" displayName="RETURNED TO AO" value="20" view="Draft" />
    //<add name = "FOR_POS_PROCESSING" displayName="FOR POS PROCESSING" value="21" view="Draft" />
    //<add name = "FOR_QC_REVIEW" displayName="FOR QUALITY CONTROL REVIEW" value="22" view="Draft" />
    //<add name = "PS_SERVICING" displayName="FOR POS SERVICING" value="23" />
    //<add name = "MDCS_PROCESSING" displayName="MDCS PROCESSING" value="24" view="MDCSProcessing" />
    //<add name = "RETURN_TO_MAKER" displayName="RETURN TO MAKER" value="25" view="Draft" />
    //<add name = "FOR_APPROVAL" displayName="FOR APPROVAL" value="26" view="Approval" />
    //<add name = "APPROVED" displayName="APPROVED" value="27" view="APPROVED"  />
}