using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic; 
using MaterialWarehouseRepos;
using MaterialWarehouseOrm;
using MaterialWarehouseEntity;
using VouchersRepos;
using VoucherOrm;
using VoucherEntity;
using VoucherConfigEntity;
using Swashbuckle.AspNetCore.Annotations;

namespace MaterialOrderAPI.Controllers
{
    // Set the base path for this controller
    [SwaggerTag("Requests about values")]
    [Route("api/service-order/material-order")] 
    [ApiController]
    public class MaterialController : ControllerBase
    {
 
         [HttpGet]
         [Route("getMaterial")]
        public string[] GetMaterials()
        {
            return  ["one","two"];
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        [Produces("application/json")]
         [Route("updateMaterial")]
        public async Task<IActionResult> UpdateMaterials([FromForm] MWarehouse body)
        {  
            /*  await using var dataSource = NpgsqlDataSource.Create(Global.ConnectionString);
           
           var result = new List<Product> {
              new Product {
                Id = 1, Name = "lorem", Price = 2000
              },
              new Product {
                Id = 2, Name = "ipsum", Price = 2500
              }
           };
           return BadRequest(new {Message = "failed"});
           return Ok(new {Message = "success",data = result});
            var cmd = dataSource.CreateCommand("SELECT * FROM material_warehouse");
           var reader = await cmd.ExecuteReaderAsync();
           var data = new List<Material>{};
            while (await reader.ReadAsync())
              {
              int? id = reader["id"] as int?;
              int? product_id = reader["product_id"] as int?;
              string nama_material = reader["nama_material"] as string;
              data.Add(new Material { Id = id.Value, Product_id = product_id.Value, Nama_material = nama_material });
              }   */
          var db = new MaterialWarehouseOrm.LocationDbContext();
          var mw = new MWarehouseRepos(db);
          var data = mw.AllForMember();
          return Ok(new {Message = "success", Request = body, Data = data});
        }

        [HttpGet]
        [Produces("application/json")]
         [Route("joinVoucher")]
        public async Task<IActionResult> JoinVoucher()
        {
              var db = new VoucherOrm.LocationDbContext();
             var mw = new VoucherRepos(db);
              var data = mw.AllForMember();
          return Ok(new {Message = "success", Data = data});
        }

         [HttpDelete]
         [Route("deleteMaterial")]
        public string[] DeleteMaterials()
        {
            return  ["one","two"];
        }
    }

}

