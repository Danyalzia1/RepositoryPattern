using LibraryManagementSysAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;
using LibraryManagementSysAPI.Services;
using System.Linq;
using LibraryManagementSysAPI.ExceptionLogs;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryManagementSysAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : class
    {
        protected IRepository<T> irepository;
        protected IService<T> services;
        protected ILogger logger;
        protected IMapper mapper;

        public BaseController(IService<T> repo, ILogger logger, IMapper mapper )
        {
            this.services = repo;
            this.logger = logger;
            this.mapper = mapper;
        }


        // GET: api/<BaseController>
        [HttpGet]
        public ActionResult <ICollection<T>> Get()
        {

            try
            {
                var data = services.Get().ToList();
                var getMap = mapper.Map<ICollection<T>>(data);
                return Ok(getMap);
            }
            catch(Exception err)
            {
                logger.log(err.ToString());
                return null;
            }
         
        }

        // GET api/<BaseController>/5
        [HttpGet("{id}")]
        public ActionResult <T> Get(int id)
        {
            try
            {
                var entity = services.Get().ToList();
                var getMap = mapper.Map<ICollection<T>>(entity);
                return Ok(getMap);
            }
            catch (Exception err)
            {
                logger.log(err.ToString());
                return null;
            }
        }

        // POST api/<BaseController>
        [HttpPost]
        public ActionResult <bool> Post([FromBody] T entity)
        {
            try
            {
                var dtp = services.Get().ToList();
                var postMap = mapper.Map<ICollection<T>>(dtp);
                return Ok(postMap);
            }
            catch (Exception err)
            {
                logger.log(err.ToString());
                return false;
            }
        }

        // PUT api/<BaseController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] T value)
        {
            try
            {
                var itu = services.Update(value);
                var putMap = mapper.Map<T>(itu);
                return true;
            }
            catch (Exception err)
            {


                logger.log(err.ToString());
                return false;
            }

        }

        // DELETE api/<BaseController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            try
            {
                var itd = services.Delete(id);
                var deleteMap = mapper.Map<T>(itd);
                return true;
            }
            catch (Exception err)
            {
                logger.log(err.ToString());
                return false;
            }

        }
    }


    
}


