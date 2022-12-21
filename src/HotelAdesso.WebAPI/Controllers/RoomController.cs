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
    public class RoomController : ControllerBase
    {
        #region Variables
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion
        #region Constructor
        public RoomController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion
        #region ROOM TYPE
        #region Get All Room Type
        [HttpGet("getRoomTypes")]
        [MapToApiVersion("1.0")]
        public IActionResult GetRoomTypes()
        {
            _unitOfWork.CreateTransaction();
            var result = _unitOfWork.RoomTypeRepository.List();
            return Ok(result);
        }
        #endregion
        #region Add Room Type
        [HttpPost("addRoomType")]
        [MapToApiVersion("1.0")]
        public IActionResult AddRoomType(RoomTypeDto model)
        {
            _unitOfWork.CreateTransaction();
            var newRoomType = _mapper.Map<RoomType>(model);
            var result = _unitOfWork.RoomTypeRepository.Add(newRoomType);
            if (result.IsSuccess)
            {
                _unitOfWork.Save();
                _unitOfWork.Commit();
                return Ok(result);
            }
            return BadRequest(result);
        }
        #endregion
        #region Delete Room Type
        [HttpDelete("deleteRoomType/{id}")]
        [MapToApiVersion("1.0")]
        public IActionResult DeleteRoomTypeById(Guid id)
        {
            _unitOfWork.CreateTransaction();
            var result = _unitOfWork.RoomTypeRepository.Delete(id);
            if (result.IsSuccess)
            {
                _unitOfWork.Save();
                _unitOfWork.Commit();
                return Ok(result);
            }
            return BadRequest(result);
        }
        #endregion
        #region Update Room Type
        [HttpPut("updateRoomType")]
        [MapToApiVersion("1.0")]
        public IActionResult UpdateRoomType(Guid id, RoomTypeDto model)
        {
            _unitOfWork.CreateTransaction();
            var updatedRoomType = _mapper.Map<RoomType>(model);
            var result = _unitOfWork.RoomTypeRepository.Update(updatedRoomType);
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
        #region ROOM STATUS
        #region Get All Room Status
        [HttpGet("getRoomStatus")]
        [MapToApiVersion("1.0")]
        public IActionResult GetRoomStatus()
        {
            _unitOfWork.CreateTransaction();
            var result = _unitOfWork.RoomStatusRepository.List();
            return Ok(result);
        }
        #endregion
        #region Add New Room Status
        [HttpPost("addRoomStatus")]
        [MapToApiVersion("1.0")]
        public IActionResult AddRoomStatus(RoomStatusDto model)
        {
            _unitOfWork.CreateTransaction();
            var newRoomStatus = _mapper.Map<RoomStatus>(model);
            var result = _unitOfWork.RoomStatusRepository.Add(newRoomStatus);
            if (result.IsSuccess)
            {
                _unitOfWork.Save();
                _unitOfWork.Commit();
                return Ok(result);
            }
            return BadRequest(result);
        }
        #endregion
        #region Delete Room Status
        [HttpDelete("deleteRoomStatus/{id}")]
        [MapToApiVersion("1.0")]
        public IActionResult DeleteRoomStatusById(Guid id)
        {
            _unitOfWork.CreateTransaction();
            var result = _unitOfWork.RoomStatusRepository.Delete(id);
            if (result.IsSuccess)
            {
                _unitOfWork.Save();
                _unitOfWork.Commit();
                return Ok(result);
            }
            return BadRequest(result);
        }
        #endregion
        #region Update Room Status
        [HttpPut("updateRoomStatus")]
        [MapToApiVersion("1.0")]
        public IActionResult UpdateRoomStatus(Guid id, RoomStatusDto model)
        {
            _unitOfWork.CreateTransaction();
            var updatedRoomStatus = _mapper.Map<RoomStatus>(model);
            var result = _unitOfWork.RoomStatusRepository.Update(updatedRoomStatus);
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
        #region ROOM
        #region Get All Room
        [HttpGet("getRoom")]
        [MapToApiVersion("1.0")]
        public IActionResult GetRoom()
        {
            _unitOfWork.CreateTransaction();
            var result = _unitOfWork.RoomRepository.GetAllRoom();
            return Ok(result);
        }
        #endregion
        #region Add New Room
        [HttpPost("addRoom")]
        [MapToApiVersion("1.0")]
        public IActionResult AddRoom(RoomDto model)
        {
            _unitOfWork.CreateTransaction();
            var newRoom = _mapper.Map<Room>(model);
            var result = _unitOfWork.RoomRepository.Add(newRoom);
            if (result.IsSuccess)
            {
                _unitOfWork.Save();
                _unitOfWork.Commit();
                return Ok(result);
            }
            return BadRequest(result);
        }
        #endregion
        #region Delete Room
        [HttpDelete("deleteRoom/{id}")]
        [MapToApiVersion("1.0")]
        public IActionResult DeleteRoomById(Guid id)
        {
            _unitOfWork.CreateTransaction();
            var result = _unitOfWork.RoomRepository.Delete(id);
            if (result.IsSuccess)
            {
                _unitOfWork.Save();
                _unitOfWork.Commit();
                return Ok(result);
            }
            return BadRequest(result);
        }
        #endregion
        #region Update Room
        [HttpPut("updateRoom")]
        [MapToApiVersion("1.0")]
        public IActionResult UpdateRoom(Guid id, RoomDto model)
        {
            _unitOfWork.CreateTransaction();
            var updatedRoom = _mapper.Map<Room>(model);
            var result = _unitOfWork.RoomRepository.Update(updatedRoom);
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
