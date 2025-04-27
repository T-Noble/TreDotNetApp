using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using TreDotNetApp.Models;


namespace TreDotNetApp.Controllers;

public class ProjectsController
{
    //private readonly Container _projectsContainer;

    public ProjectsController(Database cosmosDatabase)
    {
        var _projectsContainer = cosmosDatabase.GetContainer("Projects");
    }
}