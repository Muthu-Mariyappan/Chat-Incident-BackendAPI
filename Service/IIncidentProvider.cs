using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IP___Social_Media_Integration___POC.Models;

namespace IP___Social_Media_Integration___POC.Service
{
    public interface IIncidentProvider
    {
       public IncidentResponse GetIncident(string id);
       public List<IncidentResponse> GetAllIncident();
       public string CreateIncident(IncidentRequest incident);

    }
}
