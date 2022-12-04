using AutoMapper;
using HotelAdesso.Application.Dto;
using HotelAdesso.Application.UnitOfWork;
using HotelAdesso.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelAdesso.WebAPI.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class GuestController : ControllerBase
    {
        #region Variables
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public GuestController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion
        #region Get All Guest
        [HttpGet("getGuests")]
        [MapToApiVersion("1.0")]
        public IActionResult GetGuests()
        {
            _unitOfWork.CreateTransaction();
            var result = _unitOfWork.GuestRepository.List();
            return Ok(result);
        }
        #endregion
        #region Add Guest
        [HttpPost("addGuest")]
        [MapToApiVersion("1.0")]
        public IActionResult AddGuest(GuestDto model)
        {
            _unitOfWork.CreateTransaction();
            var newGuest = _mapper.Map<Guest>(model);
            var result = _unitOfWork.GuestRepository.Add(newGuest);
            if (result.IsSuccess)
            {
                _unitOfWork.Save();
                _unitOfWork.Commit();
                return Ok(result);
            }
            return BadRequest(result);
        }
        #endregion
        #region Delete Guest
        [HttpDelete("deleteGuest/{id}")]
        [MapToApiVersion("1.0")]
        public IActionResult DeleteGuestById(Guid id)
        {
            _unitOfWork.CreateTransaction();
            var result = _unitOfWork.GuestRepository.Delete(id);
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
        [HttpPut("updateGuest")]
        [MapToApiVersion("1.0")]
        public IActionResult UpdateHotel(Guid id, GuestDto model)
        {
            _unitOfWork.CreateTransaction();
            var updatedGuest = _mapper.Map<Guest>(model);
            var result = _unitOfWork.GuestRepository.Update(updatedGuest);
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
