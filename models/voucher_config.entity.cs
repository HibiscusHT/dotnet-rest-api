using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Swashbuckle.AspNetCore.Annotations; 


namespace VoucherConfigEntity {
        [Table("voucher_config")]
        public class VoucherConfig { 
              
             public int id {get; set;} 
            
             public string sku {get; set;}  
        }
}