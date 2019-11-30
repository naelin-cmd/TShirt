using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TShirtAPI.Model;
using static TShirtAPI.Data.TShirtInfo;

namespace TShirtAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TshirtOrderController : ControllerBase
    {
        private readonly Information _context;
        public TshirtOrderController(Information context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<List<TShirt>> GetAll() =>
           _context.TShirt.ToList();
        [HttpGet("{id}")]
        public async Task<ActionResult<TShirt>> GetById(long id)
        {
            var product = await _context.TShirt.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, TShirt product)
        {
            if (id != product.ID)
            {
                return BadRequest();
            }
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<TShirt>> Create(TShirt product)
        {
            _context.TShirt.Add(product);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = product.ID }, product);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var product = await _context.TShirt.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            _context.TShirt.Remove(product);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}