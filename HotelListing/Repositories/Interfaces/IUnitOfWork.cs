﻿using System;
using System.Threading.Tasks;
using HotelListing.Data;

namespace HotelListing.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Country> Countries { get; }
        IGenericRepository<Hotel> Hotels { get; }
        Task Save();
    }
}