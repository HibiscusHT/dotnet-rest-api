using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Swashbuckle.AspNetCore.Annotations; 


namespace MaterialWarehouseEntity {
        [Table("material_warehouse")]
        public class MWarehouse { 
              
             public int id {get; set;} 
            
             public int product_id {get; set;} 
           
             public string nama_material {get; set;}
        }
}