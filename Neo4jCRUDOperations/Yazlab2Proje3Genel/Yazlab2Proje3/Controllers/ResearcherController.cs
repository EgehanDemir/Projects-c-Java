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
    public class ResearcherController:ControllerBase
    {
       private readonly IGraphClient _client;

       public ResearcherController(IGraphClient client)
       {
          _client = client; 
       } 

        [HttpGet]
       public async Task<IActionResult> Get(){
             var researchers = await _client.Cypher.Match("(n: Researcher)")
                                                   .Return(n => n.As<Researcher>()).ResultsAsync;

            return Ok(researchers);
       }

       [HttpGet("{name}")]
       public async Task<IActionResult> GetByName(string name){
             var researchers = await _client.Cypher.Match("(r : Researcher)")
                                                   .Where((Researcher r) => r.name == name)
                                                   .Return(r => r.As<Researcher>()).ResultsAsync;

            return Ok(researchers.LastOrDefault());
       }

       [HttpPost]
       public async Task<IActionResult> Create([FromBody]Researcher rscher){
           await _client.Cypher.Create("(r:Researcher $rscher)")
                               .WithParam("rscher", rscher)
                               .ExecuteWithoutResultsAsync();

            return Ok();
       }

       [HttpPut("{name}")]
       public async Task<IActionResult> Update(string name, [FromBody]Researcher rscher){
            await _client.Cypher.Match("(r:Researcher)")
                                .Where((Researcher r) => r.name == name)
                                .Set("r = $rscher")
                                .WithParam("rscher", rscher)
                                .ExecuteWithoutResultsAsync();
           return Ok();
       }

       [HttpDelete("{name}")]
       public async Task<IActionResult> Delete(string name){
            await  _client.Cypher.Match("(r:Researcher)")
                                 .Where((Researcher r) => r.name == name)
                                 .Delete("r")
                                 .ExecuteWithoutResultsAsync();
            return Ok();

       }

    }
}