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
        #region BOOKING
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
        public IActionResult UpdateBooking(Guid id, BookingDto model)
        {
            _unitOfWork.CreateTransaction();
            var updatedBooking = _mapper.Map<Booking>(model);
            var result = _unitOfWork.BookingRepository.Update(updatedBooking);
            if (result.IsSuccess)
            {
                _unitOfWork.Save();
                _unitOfWork.Commit();
                return Ok(result);
            }
            return BadRequest(result);
        }
        #endregion
        #endregion
        #region BOOKEDROOMS
        #region Get All BookedRooms
        [HttpGet("getBookedRooms")]
        [MapToApiVersion("2.0")]
        public IActionResult GetBookedRooms()
        {
            _unitOfWork.CreateTransaction();
            var result = _unitOfWork.BookedRoomRepository.getAllBookedRooms();
            return Ok(result);
        }
        #endregion
        #region Add BookedRoom
        [HttpPost("addBookedRoom")]
        [MapToApiVersion("2.0")]
        public IActionResult AddBookedRoom(BookedRoomDto model)
        {
            _unitOfWork.CreateTransaction();
            var newBookedRoom = _mapper.Map<BookedRoom>(model);
            var result = _unitOfWork.BookedRoomRepository.Add(newBookedRoom);
            if (result.IsSuccess)
            {
                _unitOfWork.Save();
                _unitOfWork.Commit();
                return Ok(result);
            }
            return BadRequest(result);
        }
        #endregion
        #region Delete BookedRoom
        [HttpDelete("deleteBookedRoom/{id}")]
        [MapToApiVersion("2.0")]
        public IActionResult DeleteBookedRoomById(Guid id)
        {
            _unitOfWork.CreateTransaction();
            var result = _unitOfWork.BookedRoomRepository.Delete(id);
            if (result.IsSuccess)
            {
                _unitOfWork.Save();
                _unitOfWork.Commit();
                return Ok(result);
            }
            return BadRequest(result);
        }
        #endregion
        #region Update BookedRoom
        [HttpPut("updateBookedRoom")]
        [MapToApiVersion("2.0")]
        public IActionResult UpdateBookedRoom(Guid id, BookedRoomDto model)
        {
            _unitOfWork.CreateTransaction();
            var updatedBookedRoom = _mapper.Map<BookedRoom>(model);
            var result = _unitOfWork.BookedRoomRepository.Update(updatedBookedRoom);
            if (result.IsSuccess)
            {
                _unitOfWork.Save();
                _unitOfWork.Commit();
                return Ok(result);
            }
            return BadRequest(result);
        }
        #endregion
        #endregion

    }
}
