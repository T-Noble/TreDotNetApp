using Microsoft.AspNetCore.Mvc;

namespace TreDotNetApp.Controllers;

[ApiController]
[Route("[controller]")]
public class SoftSkillsController
{
    private readonly Container _softSkillsContainer;

    public SoftSkillsController(Database cosmosDatabase)
    {
        _softSkillsContainer = cosmosDatabase.GetContainer("SoftSkills");
    }
}