﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace TrackerModels.Models
{
    public class StakeHolderMapping
    {
        [Key]
        public int MapID { get; set; }
        
        public int ACRID { get; set; }

        public int StakeholderID { get; set; }

       
    }
}
