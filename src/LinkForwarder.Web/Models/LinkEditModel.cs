﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace LinkForwarder.Web.Models
{
    public class LinkEditModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(256)]
        [DataType(DataType.Url)]
        [Display(Name = "Origin Url")]
        public string OriginUrl { get; set; }

        [Display(Name = "Note")]
        public string Note { get; set; }

        [Display(Name = "Aka")]
        [MaxLength(32)]
        [RegularExpression("(?!-)([a-z0-9-]+)")]
        public string AkaName { get; set; }

        [Required]
        [Display(Name = "Enable")]
        public bool IsEnabled { get; set; }
    }
}
