using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MicroRabbit.Banking.Application.Models
{
  public class AccountTransfer
  {
    public int FromAccount { get; set; }
    public int ToAccount { get; set; }

    [Column(TypeName = "decimal(18,2)")] 
    public decimal TransferAmount { get; set; }
  }
}
