using HotelAdesso.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Persistence.Context
{
    public class EFContextSeed
    {
        public static void Seed(EFContext context)
        {
            if (context.Database.IsSqlServer())
            {
                context.Database.Migrate();
            }
            if (!context.RoomStatus.Any())
            {
                context.RoomStatus.AddRange(GetPreConfiguredRoomStatus());
            }
            if (!context.RoomTypes.Any())
            {
                context.RoomTypes.AddRange(GetPreConfiguredRoomTypes());
            }
            if (!context.Hotels.Any())
            {
                context.Hotels.AddRange(GetPreConfiguredHotels());
            }
            if (!context.Rooms.Any())
            {
                context.Rooms.AddRange(GetPreConfiguredRooms());
            }
            if (!context.Guests.Any())
            {
                context.Guests.AddRange(GetPreConfiguredGuests());
            }
            context.SaveChanges();
        }
        static IEnumerable<RoomStatus> GetPreConfiguredRoomStatus()
        {
            return new List<RoomStatus>
            {
                new RoomStatus
                {
                    Id=Guid.Parse("4386c8e8-4cd3-4807-a25b-a55a9e642e88"),
                    Description="Available",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new RoomStatus
                {
                    Id=Guid.Parse("a7e9edd8-4aa4-40ac-98c3-d7a4331a2033"),
                    Description="Unavailable",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
            };
        }
        static IEnumerable<RoomType> GetPreConfiguredRoomTypes()
        {
            return new List<RoomType>
            {
                new RoomType
                {
                    Id=Guid.Parse("ee8cbc32-3b36-4464-9252-5f27d800f446"),
                    Description="Single",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    AdditionalPriceRatio = 10
                },
                new RoomType
                {
                    Id=Guid.Parse("92f23240-a524-480c-802c-0445d9fdd61d"),
                    Description="Double",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    AdditionalPriceRatio = 12
                },
                new RoomType
                {
                    Id=Guid.Parse("44bf650a-6a86-4057-8154-b904a21a7881"),
                    Description="Triple",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    AdditionalPriceRatio = 15
                },
                 new RoomType
                {
                    Id=Guid.Parse("40aa1ed5-ab8f-4cdc-a447-9cb69e8d1712"),
                    Description="Suite",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    AdditionalPriceRatio=18
                }, 
                new RoomType
                {
                    Id=Guid.Parse("2cd9fa07-68b8-4196-8719-35b846a2666a"),
                    Description="Presidential Suite",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    AdditionalPriceRatio = 20
                },
            };
        }
        static IEnumerable<Hotel> GetPreConfiguredHotels()
        {
            return new List<Hotel>
            {
                new Hotel
                {
                    Id=Guid.Parse("2dcab650-5115-41f2-87f3-cf94202df38c"),
                    Address="Hotel 1 Address 1",
                    Address2 = "Hotel 1 Address 2",
                    City = "İstanbul",
                    Code = "H-IST-1",
                    Name="HOTEL 1 ISTANBUL",
                    PhoneNumber="2897878",
                    State="Active",
                    WebSiteUrl="https://...",
                    ZipCode="34456",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new Hotel
                {
                    Id=Guid.Parse("3dc165fb-230c-4ebd-9887-39f0f38d19de"),
                    Address="Hotel 2 Address 1",
                    Address2 = "Hotel 2 Address 2",
                    City = "İstanbul",
                    Code = "H-IST-2",
                    Name="HOTEL 2 ISTANBUL",
                    PhoneNumber="2891023",
                    State="Active",
                    WebSiteUrl="https://...",
                    ZipCode="31455",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new Hotel
                {
                    Id=Guid.Parse("f5bd7ca4-648b-403b-b017-43d128b7ed88"),
                    Address="Hotel 3 Address 1",
                    Address2 = "Hotel 3 Address 2",
                    City = "İstanbul",
                    Code = "H-IST-3",
                    Name="HOTEL 3 ISTANBUL",
                    PhoneNumber="2891023",
                    State="Active",
                    WebSiteUrl="https://...",
                    ZipCode="21478",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },

            };
        }
        static IEnumerable<Room> GetPreConfiguredRooms()
        {
            return new List<Room>
            {
                new Room
                {
                    Id=Guid.Parse("a9a15452-cdd8-4bd7-8cbc-67f0397f66c4"),
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Description="Room 1",
                    Floor = 1,
                    HotelId = Guid.Parse("2dcab650-5115-41f2-87f3-cf94202df38c"),
                    Price=100,
                    RoomStatusId = Guid.Parse("4386c8e8-4cd3-4807-a25b-a55a9e642e88"),
                    RoomTypeId = Guid.Parse("ee8cbc32-3b36-4464-9252-5f27d800f446"),                                  
                },
                new Room
                {
                    Id=Guid.Parse("c216ac9a-2592-4360-9852-cfd228ead14e"),
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Description="Room 2",
                    Floor = 1,
                    HotelId = Guid.Parse("2dcab650-5115-41f2-87f3-cf94202df38c"),
                    Price=100,
                    RoomStatusId = Guid.Parse("4386c8e8-4cd3-4807-a25b-a55a9e642e88"),
                    RoomTypeId = Guid.Parse("ee8cbc32-3b36-4464-9252-5f27d800f446"),
                },
                new Room
                {
                    Id=Guid.Parse("734c8f13-ac62-43e7-9def-f365ebc1101f"),
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Description="Room 3",
                    Floor = 2,
                    HotelId = Guid.Parse("2dcab650-5115-41f2-87f3-cf94202df38c"),
                    Price=200,
                    RoomStatusId = Guid.Parse("4386c8e8-4cd3-4807-a25b-a55a9e642e88"),
                    RoomTypeId = Guid.Parse("92f23240-a524-480c-802c-0445d9fdd61d"),
                },
                new Room
                {
                    Id=Guid.Parse("f91c1377-98ca-451d-81f0-3cdbf8aa3c9c"),
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Description="Room 4",
                    Floor = 2,
                    HotelId = Guid.Parse("2dcab650-5115-41f2-87f3-cf94202df38c"),
                    Price=200,
                    RoomStatusId = Guid.Parse("4386c8e8-4cd3-4807-a25b-a55a9e642e88"),
                    RoomTypeId = Guid.Parse("92f23240-a524-480c-802c-0445d9fdd61d"),
                },
                new Room
                {
                    Id=Guid.Parse("7c247400-9abf-4d88-95df-a615671a4e32"),
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Description="Room 5",
                    Floor = 3,
                    HotelId = Guid.Parse("2dcab650-5115-41f2-87f3-cf94202df38c"),
                    Price=500,
                    RoomStatusId = Guid.Parse("4386c8e8-4cd3-4807-a25b-a55a9e642e88"),
                    RoomTypeId = Guid.Parse("2cd9fa07-68b8-4196-8719-35b846a2666a"),
                },
                 new Room
                {
                    Id=Guid.Parse("7db07412-a204-4251-8095-eb7d7a800224"),
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Description="Room 6",
                    Floor = 3,
                    HotelId = Guid.Parse("2dcab650-5115-41f2-87f3-cf94202df38c"),
                    Price=500,
                    RoomStatusId = Guid.Parse("4386c8e8-4cd3-4807-a25b-a55a9e642e88"),
                    RoomTypeId = Guid.Parse("2cd9fa07-68b8-4196-8719-35b846a2666a"),
                }
            };
        }
        static IEnumerable<Guest> GetPreConfiguredGuests()
        {
            return new List<Guest>
            {
                new Guest
                {
                    Id=Guid.Parse("dccb9325-876a-4c0e-9846-820e558bcbb4"),
                    FirstName = "Uğur",
                    LastName = "Demir",
                    Address="Guest 1 Address 1",
                    Address2="Guest 1 Address 2",
                    City = "İstanbul",
                    Email="ugurdemir551@gmail.com",
                    Gender="Male",
                    ZipCode="34396",
                    PhoneNumber="05340682415",
                    MinBudget=100,
                    MaxBudget=600,
                    CreatedDate=DateTime.Now,
                    ModifiedDate = DateTime.Now,
                },
                new Guest
                {
                    Id=Guid.Parse("e94ba80c-3901-41f6-8e7a-85bdb0c1da47"),
                    FirstName = "Ayşe",
                    LastName = "Fatma",
                    Address="Guest 2 Address 1",
                    Address2="Guest 2 Address 2",
                    City = "İstanbul",
                    Email="aysefatma@gmail.com",
                    Gender="Female",
                    ZipCode="34396",
                    PhoneNumber="05454124578",
                    MinBudget=100,
                    MaxBudget=300,
                    CreatedDate=DateTime.Now,
                    ModifiedDate = DateTime.Now,
                },
                new Guest
                {
                    Id=Guid.Parse("cbe8755d-dce5-4455-b3fe-7e444a4f0bed"),
                    FirstName = "Kemal",
                    LastName = "Cemal",
                    Address="Guest 3 Address 1",
                    Address2="Guest 3 Address 2",
                    City = "İstanbul",
                    Email="kemalcemal@gmail.com",
                    Gender="Male",
                    ZipCode="45875",
                    PhoneNumber="05478541253",
                    MinBudget=50,
                    MaxBudget=150,
                    CreatedDate=DateTime.Now,
                    ModifiedDate = DateTime.Now,
                },
                new Guest
                {
                    Id=Guid.Parse("28a21d99-f744-482c-b2e8-8880e6cebec8"),
                    FirstName = "Ceren",
                    LastName = "Ran",
                    Address="Guest 4 Address 1",
                    Address2="Guest 4 Address 2",
                    City = "İstanbul",
                    Email="cerennar@gmail.com",
                    Gender="Female",
                    ZipCode="41523",
                    PhoneNumber="05364521025",
                    MinBudget=100,
                    MaxBudget=5000,
                    CreatedDate=DateTime.Now,
                    ModifiedDate = DateTime.Now,
                },
            };
        }
    }
}
