using HotelAdesso.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Application.UnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        void CreateTransaction();
        void RollBack();
        void Save();
        void Commit();
        public IHotelRepository HotelRepository { get; }
        public IGuestRepository GuestRepository { get; }
        public IBookingRepository BookingRepository { get; }
        public IBookedRoomRepository BookedRoomRepository { get; }
        public IRoomRepository RoomRepository { get; }
        public IRoomTypeRepository RoomTypeRepository { get; }
        public IRoomStatusRepository RoomStatusRepository { get; }
    }
}
