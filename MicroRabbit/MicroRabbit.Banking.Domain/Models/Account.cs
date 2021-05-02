using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MicroRabbit.Banking.Domain.Models
{
  public class Account
  {
    [Key]
    public int id { get; set; }
    [MaxLength(20)]
    public string accountType { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal accountBalance { get; set; }
  }
}
