using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MHRServices
{
    public class MHRService : IMHRService
    {
        public string processJSON(List<Dictionary<string, object>> jsonString)
        {
            return "success";
        }

    }
}
