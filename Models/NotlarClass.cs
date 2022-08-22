using System;
using System.ComponentModel.DataAnnotations;

namespace olcutBelirleme.Models
{
    public class NotlarClass
    {
        [Key]
        public int Notid { get; set; }
        public string Notpuani { get; set; }
    }
}
