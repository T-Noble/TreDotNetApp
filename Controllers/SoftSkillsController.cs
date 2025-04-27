using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using TreDotNetApp.Models;

namespace TreDotNetApp.Controllers;

public class SoftSkillsController
{
    private readonly Container _softSkillsContainer;

    public SoftSkillsController(Database cosmosDatabase)
    {
        _softSkillsContainer = cosmosDatabase.GetContainer("SoftSkills");
    }
}