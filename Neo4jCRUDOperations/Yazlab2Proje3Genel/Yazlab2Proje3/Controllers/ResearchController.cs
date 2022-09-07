using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Yazlab2Proje3.Identity;
using Yazlab2Proje3.Models;
using Neo4jClient;
using Newtonsoft.Json;
using System.Net;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Yazlab2Proje3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResearchController:ControllerBase
    {
        private readonly IGraphClient _client;

        public ResearchController(IGraphClient client)
       {
          _client = client; 
       }

       [HttpGet]
       public async Task<IActionResult> Get(){
             var researches = await _client.Cypher.Match("(n: Research)")
                                                   .Return(n => n.As<Research>()).ResultsAsync;

            return Ok(researches);
       }

       [HttpGet("{yayinadi}")]
       public async Task<IActionResult> GetByName(string yayinadi){
             var researches = await _client.Cypher.Match("(r : Research)")
                                                   .Where((Research r) => r.yayinadi == yayinadi)
                                                   .Return(r => r.As<Research>()).ResultsAsync;

            return Ok(researches.LastOrDefault());
       }

       [HttpPost]
       public async Task<IActionResult> Create([FromBody]Research rsch){
           await _client.Cypher.Create("(r:Research $rsch)")
                               .WithParam("rsch", rsch)
                               .ExecuteWithoutResultsAsync();

            return Ok();
       }

       [HttpPut("{yayinadi}")]
       public async Task<IActionResult> Update(string yayinadi, [FromBody]Research rsch){
            await _client.Cypher.Match("(r:Research)")
                                .Where((Research r) => r.yayinadi == yayinadi)
                                .Set("r = $rsch")
                                .WithParam("rsch", rsch)
                                .ExecuteWithoutResultsAsync();
           return Ok();
       }

       [HttpDelete("{yayinadi}")]
       public async Task<IActionResult> Delete(string yayinadi){
            await  _client.Cypher.Match("(r:Research)")
                                 .Where((Research r) => r.yayinadi == yayinadi)
                                 .Delete("r")
                                 .ExecuteWithoutResultsAsync();
            return Ok();

       }
    }
}