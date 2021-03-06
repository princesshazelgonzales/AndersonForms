﻿using AndersonCRMModel;
using AndersonFormsModel;
using System.Collections.Generic;

namespace AndersonFormsWeb.Models
{
    public class RollInModel
    {
        public Employee Employee { get; set; }

        public List<NeededRequirement> NeededRequirements { get; set; }
        public List<RequestedItem> RequestedItems { get; set; }
        public List<Requirement> Requirements { get; set; }
    }
}
