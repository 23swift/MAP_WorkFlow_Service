using NLog.LayoutRenderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Config;

namespace DA
{
    [LayoutRenderer("MAP")]
    public class MAPLayoutRenderer : LayoutRenderer
    {
        [RequiredParameter]
        public string UserName { get; set; }
        [RequiredParameter]
        public string RequestTrackingNo { get; set; }

        protected override void Append(StringBuilder builder, LogEventInfo logEvent)
        {
            //throw new NotImplementedException();
            builder.Append("Merchant Acquiring Process");
        }
    }
}
