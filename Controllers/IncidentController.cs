using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IP___Social_Media_Integration___POC.Models;
using IP___Social_Media_Integration___POC.Service;

namespace IP___Social_Media_Integration___POC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentController : ControllerBase
    {
        [HttpGet]
        public List<IncidentResponse> GetAllIncident()
        {
            var response = new IncidentService().GetAllIncident();
            return response;
        }

        [HttpGet]
        [Route("{id}")]
        public IncidentResponse GetIncidentById(string id)
        {
           // field worker for gopi
            var response = new IncidentService().GetIncident(id);
            return response;
        }
        /*
        [HttpPut]
        public string CreateIncident(IncidentRequest incident)
        {
            var response = new IncidentService().UpdateIncident(incident);
            return response;
        }
        */
    }
}