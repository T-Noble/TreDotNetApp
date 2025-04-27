using Microsoft.AspNetCore.Mvc;

namespace TreDotNetApp.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjectsController
{
    //private readonly Container _projectsContainer;

    public ProjectsController(Database cosmosDatabase)
    {
        var _projectsContainer = cosmosDatabase.GetContainer("Projects");
    }
}