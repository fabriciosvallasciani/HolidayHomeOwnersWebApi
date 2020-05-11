﻿using Repositories.Contexts;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repositories.Services
{
    public class HolidayHomesOwnersRepository : IHolidayHomesOwnersRepository
    {
        private readonly HolidayHomesOwnersContext _context;
        public HolidayHomesOwnersRepository(HolidayHomesOwnersContext context)
        {
            _context = context ?? 
                throw new ArgumentNullException(nameof(context));
        }

        public async Task Add(int ownerId, HolidayHome newHome)
        {
            var owner = await Get(ownerId);
            owner.HolidayHomes.Add(newHome);
        }

        public async Task<bool> Exists(int ownerId)
        {
            return await _context.HolidayHomesOwners
                        .AnyAsync(owner => owner.Id == ownerId);
        }

        public async Task<HolidayHomesOwner> Get(int ownerId)
        {
            return await _context.HolidayHomesOwners
                        .Include(owner => owner.HolidayHomes)
                        .Where(owner => owner.Id == ownerId)
                        .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<HolidayHomesOwner>> GetAll()
        {
            return await _context.HolidayHomesOwners
                .OrderBy(owner => owner.LastName)
                .ToListAsync();
        }

        public async Task<HolidayHome> Get(int ownerId, int homeId)
        {
            return await _context.HolidayHomes
                .Where(home => home.OwnerId == ownerId && home.Id == homeId)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<HolidayHome>> GetHomes(int ownerId)
        {
            return await _context.HolidayHomes
                .Where(home => home.OwnerId == ownerId)
                .ToListAsync();
        }

        public async Task<bool> Save()
        {
            return await _context.SaveChangesAsync() >= 0;
        }

        public void Update(int ownerId, HolidayHome homeEntity){ }

        public void Remove(HolidayHome homeFromStore)
        {
            _context.Remove(homeFromStore);
        }
    }
}
