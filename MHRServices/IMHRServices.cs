using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using System.IO;  //For Stream.

namespace MHRServices
{
    [ServiceContract]
    public interface IMHRService
    {
        //To Do: Make an actual object for each kind of json you might get
        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "/save")]
        string processJSON(Stream jsonString);
    }
}

