using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IP___Social_Media_Integration___POC.Models
{
    public class IncidentResponse
    {
        public string SOP { get; set; }
        public string FWid { get; set; }
        public string IncidentId { get; set; }
        public IncidentType IncidentType { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string GeoCoordinates { get; set; }
        public string DateTime { get; set; }
        public Status incStatus { get; set; }

        public IncidentResponse()
        {
        }
    }
    public enum IncidentType
    {
        General,
        Police,
        Medical,
        Fire
    }
    public enum Status
    {
        Created,
        InProgress,
        Completed
    }
}
