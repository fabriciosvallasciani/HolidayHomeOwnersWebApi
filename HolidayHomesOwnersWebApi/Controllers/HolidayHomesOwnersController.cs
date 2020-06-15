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
    [Authorize]
    [Route("api/holidayhomesowners")]
    [ApiController]
    public class HolidayHomesOwnersController: ControllerBase
    {
        private readonly IHolidayHomesOwnersRepository _ownersRepository;
        private readonly IMapper _mapper;

        public HolidayHomesOwnersController(IHolidayHomesOwnersRepository ownersRepository,
            IMapper mapper)
        {
            _ownersRepository = ownersRepository ?? 
                throw new ArgumentNullException(nameof(ownersRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetHolidayHomes()
        {
            var ownersEntities = await _ownersRepository.GetAll();

            if (ownersEntities == null)
            {
                return NoContent();
            }

            var results = _mapper.Map<List<HolidayHomesOwnerDto>>(ownersEntities);           

            return Ok(results);
        }
    }
}
