﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Asn_23.Models
{
    [MetadataType(typeof(ServiceMetaData))]
    public partial class Service { }
    
    public class ServiceMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int ServiceId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Service Type")]
        [MaxLength(5, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string Type { get; set; }
    }
}