﻿using FindJobSolution.Data.Entities;
using FindJobSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJobSolution.ViewModels.Catalog.ApplyJob
{
    public class ApplyJobCreateRequest
    {
        //public int JobSeekerId { get; set; }
        public int JobInformationId { get; set; }
        public DateTime TimeApply { get; set; }

        public string UserIdentityName { get; set; }
    }
}
