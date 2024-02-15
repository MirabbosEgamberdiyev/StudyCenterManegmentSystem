﻿

using Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.CRM;

public class TalabaTolov : BaseEntity
{
    [Required]
    public int TalabaId { get; set; }
    [ForeignKey("TalabaId")]
    public Talaba? Talaba { get; set; }
    [Required]
    public int  GuruhId { get; set; }
    [ForeignKey("GuruhId")]
    public Guruh? Guruh { get; set; }  
    public DateTime QachonTolagan { get; set; }
    [Required]
    public decimal QanchaTolagan { get; set; }
    public TolovTuri TolovTuri { get; set; }

}
