using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RickardIpsum.Api.ViewModels;
using RickardIpsum.DAL.Models;
using RickardIpsum.DAL.Repositories;

namespace RickardIpsum.Api.Controllers
{
    [Route("api/[controller]")]
    public class IpsumController : Controller
    {
        IpsumRepository _ipsumRepository;
        IMapper _mapper;
        public IpsumController(
            IpsumRepository ipsumRepository,
            IMapper mapper
        ) {
            _ipsumRepository = ipsumRepository;
            _mapper = mapper;
        }

        // GET api/ipsum
        [HttpGet]
        public IActionResult Get()
        {
            var ipsums = _ipsumRepository.GetAllIpsums();
            return new ObjectResult(ipsums);
        }

        // GET api/ipsum/id
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return new ObjectResult(_ipsumRepository.GetIpsumById(id));
        }

        // GET api/ipsum/deleted
        [HttpGet()]
        [Route("deleted")]
        public IActionResult GetDeleted() {
            return new ObjectResult(_ipsumRepository.GetAllDeletedIpsums());
        }

        // PUT api/ipsum/id
        [HttpPut("{id}")]
        public IActionResult Put(IpsumPostModel model) {
            var ipsum = _mapper.Map<DbIpsum>(model);
            _ipsumRepository.UpdateIpsum(ipsum);
            return Ok();
        }

        // POST api/ipsum
        [HttpPost("{id}")]
        public IActionResult Post([FromBody] IpsumPostModel model)
        {
            var ipsum = _mapper.Map<DbIpsum>(model);
            _ipsumRepository.CreateIpsum(ipsum);
            return Ok();
        }

        // DELETE api/ipsum/id
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id) {
            _ipsumRepository.DeleteIpsum(id);
            return Ok();
        }
    }
}