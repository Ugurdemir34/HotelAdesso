using AutoMapper;
using HotelAdesso.Application.Dto;
using HotelAdesso.Application.UnitOfWork;
using HotelAdesso.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAdesso.WebAPI.Controllers
{

    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class HotelController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public HotelController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpPost("addHotel")]
        [MapToApiVersion("1.0")]
        public IActionResult AddHotel(HotelDto model)
        {
            _unitOfWork.CreateTransaction();
            var newHotel = _mapper.Map<Hotel>(model);
            var result = _unitOfWork.HotelRepository.Add(newHotel);
            if (result.IsSuccess)
            {
                _unitOfWork.Save();
                _unitOfWork.Commit();
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("versionTest")]
        [MapToApiVersion("2.0")]

        public IActionResult VersionTest(int id)
        {
            return Ok();
        }
    }
}
