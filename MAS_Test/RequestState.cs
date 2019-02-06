using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAS_Test
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

        
    }
}