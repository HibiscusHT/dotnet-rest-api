using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DataOrderAPI.Controllers
{
    // Set the base path for this controller
    [Route("api/service-order/data-order")]
    [ApiController]
    public class DataController : ControllerBase
    {
         [HttpDelete]
         [Route("deleteOrder")]
        public string[] DeleteOrder()
        {
            return  ["one","two"];
        }
    }
}