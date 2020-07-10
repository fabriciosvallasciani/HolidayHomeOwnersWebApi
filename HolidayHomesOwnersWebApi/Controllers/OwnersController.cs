using AutoMapper;
using Models;
using Repositories.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HolidayHomesOwnersWebApi.Controllers
{
    [AllowAnonymous]
    [Route("api/owners/")]
    [ApiController]
    public class OwnersController: ControllerBase
    {
        private readonly IHolidayHomesOwnersRepository _repository;
        private readonly IMapper _mapper;

        public OwnersController(IHolidayHomesOwnersRepository repository,
            IMapper mapper)
        {
            _repository = repository ?? 
                throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<OwnerDto>>> GetAll()
        {
            var ownersEntities = await _repository.GetAll();

            if (ownersEntities == null)
            {
                return NoContent();
            }

            var results = _mapper.Map<List<OwnerDto>>(ownersEntities);           

            return Ok(results);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<OwnerDto>> Get(uint id)
        {
            var ownerEntity = await _repository.Get(id);

            if (ownerEntity == null)
            {
                return NotFound();
            }

            var result = _mapper.Map<OwnerDto>(ownerEntity);

            return Ok(result);
        }
    }
}
