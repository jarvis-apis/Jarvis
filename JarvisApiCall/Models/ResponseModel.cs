using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JarvisApiCall.Models
{
    public class ResponseModel
    {
        public string status { get; set; }
        public string status_code { get; set; }
        public string id { get; set; }
        public string message { get; set; }
    }
}
