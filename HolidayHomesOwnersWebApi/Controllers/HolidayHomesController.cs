using AutoMapper;
using Models;
using Repositories.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace HolidayHomesOwnersWebApi.Controllers
{
    [Authorize]
    [Route("api/holidayhomesowners/{ownerId}/homes/")]
    [ApiController]
    public class HolidayHomesController: ControllerBase
    {
        private readonly IHolidayHomesOwnersRepository _ownersRepository;
        private readonly IMapper _mapper;

        public HolidayHomesController(IHolidayHomesOwnersRepository ownersRepository,
            IMapper mapper)
        {
            _ownersRepository = ownersRepository ??
                throw new ArgumentNullException(nameof(ownersRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetHolidayHomes(int ownerId)
        {
            bool ownerExists = await _ownersRepository.Exists(ownerId);
            if (!ownerExists)
            {
                return NotFound();
            }

            var homesEntities = await _ownersRepository.GetHomes(ownerId);
            if (homesEntities == null)
            {
                return NoContent();
            }

            var results = _mapper.Map<List<HolidayHomeDto>>(homesEntities);          

            return Ok(results);
        }
                        
        [HttpGet("{id}", Name = "GetHolidayHome")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetHolidayHome(int ownerId, int id)
        {
            var ownerExists = await _ownersRepository.Exists(ownerId);
            if (!ownerExists)
            {
                return NotFound();
            }

            var homeEntity = await _ownersRepository.Get(ownerId, id);
            if (homeEntity == null)
            {
                return NotFound();
            }

            var result = _mapper.Map<HolidayHomeDto>(homeEntity);

            return Ok(result);
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> PostHolidayHome(int ownerId, [FromBody]HolidayHomeForCreationDto homePosted)
        {
            var ownerExists = await _ownersRepository.Exists(ownerId);

            if (!ownerExists)
            {
                return NotFound();
            }

            var homeEntityToPersist = _mapper.Map<Entities.HolidayHome>(homePosted);

            await _ownersRepository.Add(ownerId, homeEntityToPersist);
            await _ownersRepository.Save();

            var newHome = _mapper.Map<HolidayHomeDto>(homeEntityToPersist);

            return CreatedAtRoute(nameof(GetHolidayHome),
                new { ownerId, id = newHome.Id },
                newHome);            
        }

        [HttpPut("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> PutHolidayHome(int ownerId, int id, [FromBody]HolidayHomeForUpdateDto homeUpdated)
        {
            var ownerExists = await _ownersRepository.Exists(ownerId);
                
            if (!ownerExists)
            {
                return NotFound();
            }

            var homeEntity = await _ownersRepository.Get(ownerId, id);
            if (homeEntity == null)
            {
                return NotFound();
            }

            _mapper.Map(homeUpdated, homeEntity);

            _ownersRepository.Update(ownerId, homeEntity);
            await _ownersRepository.Save();
            
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteHolidayHome(int ownerId, int id)
        {
            var ownerExists = await _ownersRepository.Exists(ownerId);
            if (!ownerExists)
            {
                return NotFound();
            }

            var homeEntity = await _ownersRepository.Get(ownerId, id);
            if (homeEntity == null)
            {
                return NotFound();
            }

            _ownersRepository.Remove(homeEntity);
            await _ownersRepository.Save();
            
            return NoContent();            
        }
    }
}
