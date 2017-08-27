using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OgeFirst.DTO
{
    public class SubmissionDTO
    {
        public int Id { get; set; }

        [Required]
        public double? StudentAnswer { get; set; }
    }
}