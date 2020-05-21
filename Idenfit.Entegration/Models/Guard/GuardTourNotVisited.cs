﻿using System;

namespace Idenfit.Entegration.Models.Guard
{
    public class GuardTourNotVisited
    {
        public Guid Id { get; set; }

        public Guid BranchId { get; set; }

        public string TaskName { get; set; }

        public string TaskType { get; set; }

        public long Tolerance { get; set; }

        public DateTime Date { get; set; }

        public float Latitude { get; set; }

        public float Longitude { get; set; }
        public string Employee { get; set; }

        public long? Tag { get; set; }
    }
}
