using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IP___Social_Media_Integration___POC.Models;
using Newtonsoft.Json;

namespace IP___Social_Media_Integration___POC.Json
{
    public class jsonclass
    {
        public static List<IncidentResponse> incidentResponses;

       static jsonclass()
        {
            string json = System.IO.File.ReadAllText(@"Json/Incident.json");
            incidentResponses = JsonConvert.DeserializeObject<List<IncidentResponse>>(json);
        }
    }
}
