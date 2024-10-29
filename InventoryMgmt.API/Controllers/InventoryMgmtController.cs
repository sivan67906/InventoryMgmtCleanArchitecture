using InventoryMgmt.Application.Services;
using InventoryMgmt.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InventoryMgmt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryMgmtController(IInventoryMgmtServices inventoryMgmtServices) : ControllerBase
    {
        private readonly IInventoryMgmtServices _inventoryMgmtServices = inventoryMgmtServices;

        // GET: api/<InventoryMgmtController>
        [HttpGet]
        public async Task<List<Inventory>> Get() => await _inventoryMgmtServices.GetAllInventories();

        // GET api/<InventoryMgmtController>/5
        [HttpGet("{id}")]
        public async Task<Inventory> Get(int id) => await _inventoryMgmtServices.GetInventoryById(id);

        // POST api/<InventoryMgmtController>
        [HttpPost]
        public async Task<Inventory> Post([FromBody] Inventory inventory) => await _inventoryMgmtServices.CreateInventory(inventory);

        // PUT api/<InventoryMgmtController>/5
        [HttpPut("{id}")]
        public async Task<int> Put(int id, [FromBody] Inventory inventory) => await _inventoryMgmtServices.UpdateInventory(id, inventory);

        // DELETE api/<InventoryMgmtController>/5
        [HttpDelete("{id}")]
        public async Task<int> Delete(int id) => await _inventoryMgmtServices.DeleteInventory(id);
    }
}
