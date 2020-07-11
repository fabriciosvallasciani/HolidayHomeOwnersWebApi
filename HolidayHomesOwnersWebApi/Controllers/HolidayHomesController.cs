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
    [Route("api/owners/{ownerId}/homes/")]
    [ApiController]
    public class HolidayHomesController: ControllerBase
    {
        private readonly IHolidayHomesOwnersRepository _repository;
        private readonly IMapper _mapper;

        public HolidayHomesController(IHolidayHomesOwnersRepository repository,
            IMapper mapper)
        {
            _repository = repository ??
                throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<HolidayHomeDto>>> Get(uint ownerId)
        {
            bool ownerExists = await _repository.Exists(ownerId);
            if (!ownerExists)
            {
                return NotFound();
            }

            var homesEntities = await _repository.GetHomes(ownerId);
            if (homesEntities == null)
            {
                return NoContent();
            }

            var results = _mapper.Map<List<HolidayHomeDto>>(homesEntities);          

            return Ok(results);
        }

        [HttpGet("{id}", Name ="Get")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<HolidayHomeDto>> Get(uint ownerId, uint id)
        {
            var ownerExists = await _repository.Exists(ownerId);
            if (!ownerExists)
            {
                return NotFound();
            }

            var homeEntity = await _repository.Get(ownerId, id);
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
        public async Task<ActionResult<HolidayHomeDto>> Post(uint ownerId, [FromBody]HolidayHomeForCreationDto homePosted)
        {
            var ownerExists = await _repository.Exists(ownerId);

            if (!ownerExists)
            {
                return NotFound();
            }

            var homeEntityToPersist = _mapper.Map<Entities.HolidayHome>(homePosted);

            await _repository.Add(ownerId, homeEntityToPersist);
            await _repository.Save();

            var newHome = _mapper.Map<HolidayHomeDto>(homeEntityToPersist);

            return CreatedAtRoute(nameof(Get),
                new { ownerId, id = newHome.Id },
                newHome);            
        }

        [HttpPut("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Put(uint ownerId, uint id, [FromBody]HolidayHomeForUpdateDto homeUpdated)
        {
            var ownerExists = await _repository.Exists(ownerId);
                
            if (!ownerExists)
            {
                return NotFound();
            }

            var homeEntity = await _repository.Get(ownerId, id);
            if (homeEntity == null)
            {
                return NotFound();
            }

            _mapper.Map(homeUpdated, homeEntity);

            _repository.Update(ownerId, homeEntity);
            await _repository.Save();
            
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete(uint ownerId, uint id)
        {
            var ownerExists = await _repository.Exists(ownerId);
            if (!ownerExists)
            {
                return NotFound();
            }

            var homeEntity = await _repository.Get(ownerId, id);
            if (homeEntity == null)
            {
                return NotFound();
            }

            _repository.Remove(homeEntity);
            await _repository.Save();
            
            return NoContent();            
        }
    }
}
