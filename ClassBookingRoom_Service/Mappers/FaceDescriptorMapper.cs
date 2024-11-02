using ClassBookingRoom_Repository.Models;
using ClassBookingRoom_Repository.RequestModels.FaceDescriptor;
using ClassBookingRoom_Repository.ResponseModels.FaceDescriptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Mappers
{
    public static class FaceDescriptorMapper
    {
        public static FaceDescriptor ToCreateFaceDescriptorDTO (this CreateFaceDescriptorRequestModel dto)
        {
            return new FaceDescriptor()
            {
                UserId = dto.UserId,
                ImageURL = dto.ImageURL,
                Descriptor = dto.Descriptor, 
            };
        }
        public static FaceDescriptorResponseModel ToFaceDescriptorDTO(this FaceDescriptor model)
        {
            return new FaceDescriptorResponseModel()
            {
                Id = model.Id,
                UserId = model.UserId,
                ImageURL = model.ImageURL,
                Descriptor = model.Descriptor,
                User = model.User?.ToUserDTO()
            };
        }
        public static FaceDescriptorShortResponse ToFaceDescriptorShortResponse(this FaceDescriptor model)
        {
            return new FaceDescriptorShortResponse()
            {
                Id = model.Id,
                UserId = model.UserId,
                ImageURL = model.ImageURL,
                Descriptor = model.Descriptor,
            };
        }
        public static FaceDescriptor ToUpdateFaceDescriptor(this UpdateFaceDescriptorRequestModel dto)
        {
            return new FaceDescriptor()
            {
                ImageURL = dto.ImageURL,
                Descriptor = dto.Descriptor,
            };
        }
    }
}
