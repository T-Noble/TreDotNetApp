using Microsoft.AspNetCore.Mvc;

namespace TreDotNetApp.Controllers;

[ApiController]
[Route("[controller]")]
public class TechnicalSkillsController
{
    private readonly Container _technicalSkillsContainer;

    //Getting Technical Skills container
    public TechnicalSkillsController(Database cosmosDatabase)
    {
        _technicalSkillsContainer = cosmosDatabase.GetContainer("TechnicalSkills");
    }

    //Adding Technical Skills to Azure Technical Skills container
    [HttpPost("batch")]
    public async Task<IActionResult> AddTechnicalSkillsBatch([FromBody] List<TechnicalSkill> skills)
    {
        var results = new List<ItemResponse<TechnicalSkill>>();

        foreach (var skill in skills)
        {
            // Set unique ID and partition key
            skill.id = Guid.NewGuid().ToString();
            var response = await _container.CreateItemAsync(skill, new PartitionKey(skill.id));
            results.Add(response);
        }

        return Ok(new { inserted = results.Count });
    }

    //Remove Technical Skill entry from Azure Technical Skills container
    // [HttpPost("")]
    // public async Task<IActionResult> DeleteTechnicalSkill([FromBody] <TechnicalSkill> skill)
    // {
    //     //
    // }
}