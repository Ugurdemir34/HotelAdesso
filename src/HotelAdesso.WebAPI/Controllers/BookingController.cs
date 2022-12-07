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
    [ApiVersion("2.0")]
    public class BookingController : ControllerBase
    {
        #region Variables
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public BookingController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion
        #region Get All Booking
        [HttpGet("getBooking")]
        [MapToApiVersion("2.0")]
        public IActionResult GetBookings()
        {
            _unitOfWork.CreateTransaction();
            var result = _unitOfWork.BookingRepository.getAllBooking();
            return Ok(result);
        }
        #endregion
        #region Add Booking
        [HttpPost("addBooking")]
        [MapToApiVersion("2.0")]
        public IActionResult AddBooking(BookingDto model)
        {
            _unitOfWork.CreateTransaction();
            var newBooking = _mapper.Map<Booking>(model);
            var result = _unitOfWork.BookingRepository.Add(newBooking);
            if (result.IsSuccess)
            {
                _unitOfWork.Save();
                _unitOfWork.Commit();
                return Ok(result);
            }
            return BadRequest(result);
        }
        #endregion
        #region Delete Booking
        [HttpDelete("deleteBooking/{id}")]
        [MapToApiVersion("2.0")]
        public IActionResult DeleteBookingById(Guid id)
        {
            _unitOfWork.CreateTransaction();
            var result = _unitOfWork.BookingRepository.Delete(id);
            if (result.IsSuccess)
            {
                _unitOfWork.Save();
                _unitOfWork.Commit();
                return Ok(result);
            }
            return BadRequest(result);
        }
        #endregion
        #region Update Booking
        [HttpPut("updateBooking")]
        [MapToApiVersion("2.0")]
        public IActionResult UpdateHotel(Guid id, BookingDto model)
        {
            _unitOfWork.CreateTransaction();
            var updatedGuest = _mapper.Map<Booking>(model);
            var result = _unitOfWork.BookingRepository.Update(updatedGuest);
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
