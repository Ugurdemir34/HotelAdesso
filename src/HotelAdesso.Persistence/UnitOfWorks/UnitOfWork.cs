using HotelAdesso.Application.Interfaces.Repositories;
using HotelAdesso.Application.UnitOfWork;
using HotelAdesso.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EFContext _context;
        private bool _disposed;
        private IDbContextTransaction _transaction;
        public IHotelRepository HotelRepository { get; }
        public IGuestRepository GuestRepository { get; }
        public UnitOfWork(EFContext context, IHotelRepository hotelRepository, IGuestRepository guestRepository)
        {
            _context = context;
            HotelRepository = hotelRepository;
            GuestRepository = guestRepository;
        }
        public async ValueTask Dispose() { }
        public int SaveChanges() => _context.SaveChanges();

        public void CreateTransaction()
        {
            _transaction = _context.Database.BeginTransaction();
        }

        public void RollBack()
        {
            _transaction.Rollback();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Commit()
        {
            _transaction.Commit();
        }

        public ValueTask DisposeAsync()
        {
            return Dispose();
        }
    }
}
