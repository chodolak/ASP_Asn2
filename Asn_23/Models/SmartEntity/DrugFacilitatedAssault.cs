﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asn_23.Models
{
    public partial class DrugFacilitatedAssault
    {
        public virtual int DrugFacilitatedAssaultId { get; set; }

        [MaxLength(3)]
        public virtual string YesNoNA { get; set; }

        public virtual ICollection<Smart> Smart { get; set; }
    }
}