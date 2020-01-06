using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IP___Social_Media_Integration___POC.Models;
using IP___Social_Media_Integration___POC.Json;

namespace IP___Social_Media_Integration___POC.Service
{
    public class IncidentService : IIncidentProvider
    {
        public List<IncidentResponse> GetAllIncident()
        {
            return jsonclass.incidentResponses;
        }

        public List<IncidentResponse> GetIncidentByFieldWorkerId(string id)
        {
            var incident = jsonclass.incidentResponses.FindAll(a => a.FWid == id);
            return incident;
        }
        public IncidentResponse GetIncidentById(string id)
        {
            var incident = jsonclass.incidentResponses.FirstOrDefault(a=>a.IncidentId==id);
            return incident;
        }

        public string UpdateIncident(IncidentRequest incident)
        {
            jsonclass.incidentResponses.FirstOrDefault(a => a.IncidentId == incident.IncidentId).incStatus = incident.incStatus;
            return "";
        }
    }
}
