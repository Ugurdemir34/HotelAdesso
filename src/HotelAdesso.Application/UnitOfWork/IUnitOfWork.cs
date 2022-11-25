using HotelAdesso.Application.Interfaces.Repositories;
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
        Task<IDbContextTransaction> BeginTransactionAsync();
        public IHotelRepository HotelRepository { get; }
        public IGuestRepository GuestRepository { get; }
    }
}
