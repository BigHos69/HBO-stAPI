﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoohAPI.Models.BaseModels
{
    /// <summary>
    /// Class that contains basic information about a vacancy.
    /// </summary>
    public class BaseVacancy
    {
        [Required]
        public int Id { get; set; } 
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        [Required]
        public IEnumerable<string> Education { get; set; }
        public string Location { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public Company Company { get; set; }
        [Required]
        public string Language { get; set; }
    }
}