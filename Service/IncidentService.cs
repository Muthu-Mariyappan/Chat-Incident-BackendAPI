using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IP___Social_Media_Integration___POC.Models;

namespace IP___Social_Media_Integration___POC.Service
{
    public class IncidentService : IIncidentProvider
    {
        public string CreateIncident(IncidentRequest incident)
        {
            throw new NotImplementedException();
        }

        /*
public string CreateIncident(IncidentRequest incident)
{
   var guid = string.Format("{0}{1:N}","INC",Guid.NewGuid());
   var datetimeUTC = DateTime.UtcNow.ToString();
   IncidentResponse response = new IncidentResponse
   {
       IncidentId = guid,
       IncidentType = incident.IncidentType,
       Description = incident.Description,
       Location = incident.Location,
       GeoCoordinates = incident.GeoCoordinates,
       DateTime = datetimeUTC,
       incStatus = Status.Created
   };
   string json = System.IO.File.ReadAllText(@"Json/Incident.json");
   var result = JsonConvert.DeserializeObject<List<IncidentResponse>>(json);
   result.Add(response);
   System.IO.File.WriteAllText(@"Json/Incident.json", JsonConvert.SerializeObject(result));
   return response.IncidentId;
}
*/

        public List<IncidentResponse> GetAllIncident()
        {
            string json = System.IO.File.ReadAllText(@"Json/Incident.json");
            var result = JsonConvert.DeserializeObject<List<IncidentResponse>>(json);
            return result;
        }

        public IncidentResponse GetIncident(string id)
        {
            //Field worker id 
            string json = System.IO.File.ReadAllText(@"Json/Incident.json");
            var result = JsonConvert.DeserializeObject<List<IncidentResponse>>(json);
            var incident = result.FirstOrDefault(a => a.IncidentId == id);
            return incident;
        }
    }
}
