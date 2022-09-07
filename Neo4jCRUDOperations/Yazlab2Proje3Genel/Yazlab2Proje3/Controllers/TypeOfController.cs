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
    public class TypeOfController:ControllerBase
    {
        private readonly IGraphClient _client;

        public TypeOfController(IGraphClient client)
        {
            _client = client; 
        }

         [HttpGet]
       public async Task<IActionResult> Get(){
             var turler = await _client.Cypher.Match("(n: Type)")
                                                   .Return(n => n.As<Yazlab2Proje3.Models.Type>()).ResultsAsync;

            return Ok(turler);
       }

       [HttpGet("{tur}")]
       public async Task<IActionResult> GetByName(string tur){
             var turler = await _client.Cypher.Match("(r : Type)")
                                                   .Where((Yazlab2Proje3.Models.Type r) => r.tur == tur)
                                                   .Return(r => r.As<Yazlab2Proje3.Models.Type>()).ResultsAsync;

            return Ok(turler.LastOrDefault());
       }

       [HttpPost]
       public async Task<IActionResult> Create([FromBody]Yazlab2Proje3.Models.Type rsch){
           await _client.Cypher.Create("(r:Type $rsch)")
                               .WithParam("rsch", rsch)
                               .ExecuteWithoutResultsAsync();

            return Ok();
       }

       [HttpPut("{tur}")]
       public async Task<IActionResult> Update(string tur, [FromBody]Yazlab2Proje3.Models.Type rsch){
            await _client.Cypher.Match("(r:Type)")
                                .Where((Yazlab2Proje3.Models.Type r) => r.tur == tur)
                                .Set("r = $rsch")
                                .WithParam("rsch", rsch)
                                .ExecuteWithoutResultsAsync();
           return Ok();
       }

       [HttpDelete("{tur}")]
       public async Task<IActionResult> Delete(string tur){
            await  _client.Cypher.Match("(r:Type)")
                                 .Where((Yazlab2Proje3.Models.Type r) => r.tur == tur)
                                 .Delete("r")
                                 .ExecuteWithoutResultsAsync();
            return Ok();

       }
    }
}