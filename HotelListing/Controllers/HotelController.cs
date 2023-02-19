using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using HotelListing.Models.Hotel;
using HotelListing.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HotelListing.Controllers
{
    [Route("api/hotels")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<HotelController> _logger;
        private readonly IMapper _mapper;
        
        public HotelController(IUnitOfWork unitOfWork, ILogger<HotelController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetHotels()
        {
            try
            {
                var countries = await _unitOfWork.Hotels.GetAll();
                var results = _mapper.Map<IList<HotelDTO>>(countries);
                return Ok(results);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, $"Something went wrong in the {nameof(GetHotels)}");
                return StatusCode(500, "Internal server error. Please try again later.");
            }
        }
        
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetHotel(int id)
        {
            try
            {
                var country = await _unitOfWork.Countries.Get(country => country.Id == id, new List<string> {"Country"});
                var result = _mapper.Map<HotelDTO>(country);
                return Ok(result);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, $"Something went wrong in the {nameof(GetHotel)}");
                return StatusCode(500, "Internal server error. Please try again later.");
            }
        }
    }
}