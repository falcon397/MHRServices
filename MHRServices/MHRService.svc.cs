using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using System.IO; //For stream.

namespace MHRServices
{
    public class MHRService : IMHRService
    {
        public string processJSON(IDictionary<string, object> jsonString)
        {
                return "You posted: ";
        }

    }
}
