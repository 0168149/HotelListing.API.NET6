﻿using HotelListing.API.Contracts;
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Repository
{
    public class GenericRepository<T> : IGenricRepository<T> where T : class
    {
        private readonly HotelListingDbContext _context;

        public GenericRepository(HotelListingDbContext context)
        {
            this._context = context;
        }

        public async Task<T> AddAsynsc(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsynsc(int id)
        {
            var entity = await GetAsyn(id);
             _context.Set<T>().Remove(entity);
         await   _context.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await GetAsyn(id);
            return entity != null;
        }

        public async Task<List<T>> GetAllAsynsc()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsyn(int? id)
        {
           if(id is null)
            {
                return null;
            }
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsynsc(T entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}