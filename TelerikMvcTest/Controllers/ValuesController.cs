﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TelerikMvcTest.Controllers
{
    /// <summary>
    /// ValuesController
    /// </summary>
    public class ValuesController : ApiController
    {
        // GET api/values
        /// <summary>
        /// 获取 Value 列表
        /// </summary>
        /// <returns>Values 的枚举</returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        /// <summary>
        /// Get
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        /// <summary>
        /// Post
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        /// <summary>
        /// Put
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}