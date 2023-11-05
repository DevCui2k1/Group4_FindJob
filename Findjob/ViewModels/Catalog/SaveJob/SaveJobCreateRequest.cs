using FindJobSolution.Data.Entities;
using FindJobSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobSolution.ViewModels.Catalog.SaveJob
{
    public class SaveJobCreateRequest
    {
        public int JobInformationId { get; set; }
        public DateTime TimeSave { get; set; }

        public string UserIdentityName { get; set; }
    }
}
