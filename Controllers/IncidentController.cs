﻿using System;
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
        public IncidentResponse GetIncidentByID(string id)
        {
            var response = new IncidentService().GetIncidentById(id);
            return response;
        }

        [HttpGet]
        [Route("fwid/{id}")]
        public List<IncidentResponse> GetFeildWorkerIncidents(string id)
        {
            var response = new IncidentService().GetIncidentByFieldWorkerId(id);
            return response;
        }
        [HttpPut]
        public string UpdateIncident(IncidentRequest incident)
        {
            var res=new IncidentService().UpdateIncident(incident);
            return "true";
        }
    }
}