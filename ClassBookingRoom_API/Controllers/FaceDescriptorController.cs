using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Service.IServices;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClassBookingRoom_Repository.RequestModels.FaceDescriptor;
using ClassBookingRoom_Repository.ResponseModels.FaceDescriptor;
namespace ClassBookingRoom_API.Controllers
{


    [Route("api/face-descriptor")]
    [ApiController]
    public class FaceDescriptorController : ControllerBase
    {
        private readonly IFaceDescriptorService _faceDescriptorService;

        public FaceDescriptorController(IFaceDescriptorService faceDescriptorService)
        {
            _faceDescriptorService = faceDescriptorService;
        }

        [HttpGet]
        public async Task<ActionResult<List<FaceDescriptorResponseModel>>> GetAll()
        {
            var faceDescriptors = await _faceDescriptorService.GetAll();
            return Ok(faceDescriptors);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FaceDescriptorResponseModel>> GetById(int id)
        {
            var faceDescriptor = await _faceDescriptorService.GetById(id);
            if (faceDescriptor == null)
            {
                return NotFound();
            }
            return Ok(faceDescriptor);
        }

        [HttpPost]
        public async Task<ActionResult> Add([FromQuery] CreateFaceDescriptorRequestModel faceDescriptor)
        {
            try { await _faceDescriptorService.AddAsync(faceDescriptor);
                return Ok("Added successfully"); }
            catch (Exception ex) { return BadRequest(ex.Message); }
           
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromQuery] UpdateFaceDescriptorRequestModel faceDescriptor)
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
            try {
                var faceDescriptor = await _faceDescriptorService.GetById(id);
                if (faceDescriptor == null)
                {
                    return NotFound();
                }

                await _faceDescriptorService.DeleteAsync(id);
                return Ok("Delete Successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }

}
