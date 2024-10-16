using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace ClassBookingRoom_API.Controllers
{


    [Route("api/face_descriptor")]
    [ApiController]
    public class FaceDescriptorController : ControllerBase
    {
        private readonly IFaceDescriptorService _faceDescriptorService;

        public FaceDescriptorController(IFaceDescriptorService faceDescriptorService)
        {
            _faceDescriptorService = faceDescriptorService;
        }

        [HttpGet]
        public async Task<ActionResult<List<FaceDescriptor>>> GetAll()
        {
            var faceDescriptors = await _faceDescriptorService.GetAll();
            return Ok(faceDescriptors);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FaceDescriptor>> GetById(int id)
        {
            var faceDescriptor = await _faceDescriptorService.GetById(id);
            if (faceDescriptor == null)
            {
                return NotFound();
            }
            return Ok(faceDescriptor);
        }

        [HttpPost]
        public async Task<ActionResult> Add([FromBody] FaceDescriptor faceDescriptor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _faceDescriptorService.AddAsync(faceDescriptor);
            return CreatedAtAction(nameof(GetById), new { id = faceDescriptor.Id }, faceDescriptor);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] FaceDescriptor faceDescriptor)
        {
            if (id != faceDescriptor.Id)
            {
                return BadRequest("ID mismatch");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingFaceDescriptor = await _faceDescriptorService.GetById(id);
            if (existingFaceDescriptor == null)
            {
                return NotFound();
            }

            await _faceDescriptorService.UpdateAsync(faceDescriptor);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var faceDescriptor = await _faceDescriptorService.GetById(id);
            if (faceDescriptor == null)
            {
                return NotFound();
            }

            await _faceDescriptorService.DeleteAsync(id);
            return NoContent();
        }
    }

}
