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
        #region Variables
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public HotelController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        } 
        #endregion
        #region Get All Hotels
        [HttpGet("getHotels")]
        [MapToApiVersion("1.0")]
        public IActionResult GetHotels()
        {
            _unitOfWork.CreateTransaction();
            var result = _unitOfWork.HotelRepository.List();
            return Ok(result);
        }
        #endregion
        #region Add New Hotel
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
        #endregion
        #region Delete Hotel
        [HttpDelete("deleteHotel/{id}")]
        [MapToApiVersion("1.0")]
        public IActionResult DeleteHotelById(Guid id)
        {
            _unitOfWork.CreateTransaction();
            var result = _unitOfWork.HotelRepository.Delete(id);
            if (result.IsSuccess)
            {
                _unitOfWork.Save();
                _unitOfWork.Commit();
                return Ok(result);
            }
            return BadRequest(result);
        }
        #endregion
        #region Update Hotel
        [HttpPut("updateHotel")]
        [MapToApiVersion("1.0")]
        public IActionResult UpdateHotel(Guid id, HotelDto model)
        {
            _unitOfWork.CreateTransaction();
            var updatedHotel = _mapper.Map<Hotel>(model);
            var result = _unitOfWork.HotelRepository.Update(updatedHotel);
            if (result.IsSuccess)
            {
                _unitOfWork.Save();
                _unitOfWork.Commit();
                return Ok(result);
            }
            return BadRequest(result);
        }
        #endregion
    }
}
