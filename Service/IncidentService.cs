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
        public List<IncidentResponse> GetAllIncident()
        {
            string json = System.IO.File.ReadAllText(@"Json/Incident.json");
            var result = JsonConvert.DeserializeObject<List<IncidentResponse>>(json);
            return result;
        }

        public List<IncidentResponse> GetIncidentByFieldWorkerId(string id)
        {
            string json = System.IO.File.ReadAllText(@"Json/Incident.json");
            var result = JsonConvert.DeserializeObject<List<IncidentResponse>>(json);
            var incident = result.FindAll(a => a.FWid == id);
            return incident;
        }
        public IncidentResponse GetIncidentById(string id)
        {
            string json = System.IO.File.ReadAllText(@"Json/Incident.json");
            var result = JsonConvert.DeserializeObject<List<IncidentResponse>>(json);
            var incident = result.FirstOrDefault(a=>a.IncidentId==id);
            return incident;
        }

        public string UpdateIncident(IncidentRequest incident)
        {
            string json = System.IO.File.ReadAllText(@"Json/Incident.json");
            var result = JsonConvert.DeserializeObject<List<IncidentResponse>>(json);
            result.Where(a => a.IncidentId == incident.IncidentId).ToList().ForEach(s => s.incStatus = incident.incStatus);
            System.IO.File.WriteAllText(@"Json/Incident.Json", JsonConvert.SerializeObject(result));
            return "";
        }
    }
}
