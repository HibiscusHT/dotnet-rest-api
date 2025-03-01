using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Swashbuckle.AspNetCore.Annotations; 
using VoucherConfigEntity;


namespace VoucherEntity {
        [Table("data_voucher")]
        public class Voucher { 
              
             public int id {get; set;} 
            
             public int id_config {get; set;}  

             public VoucherConfig? ketentuan {get; set;}
        }
}