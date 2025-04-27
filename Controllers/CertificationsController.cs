using Microsoft.AspNetCore.Mvc;

namespace TreDotNetApp.Controllers;

[ApiController]
[Route("[controller]")]
public class CertificationsController
{
    //private readonly Container _certificationsContainer;

    public CertificationsController(Database cosmosDatabase)
    {
        var _certificationsContainer = cosmosDatabase.GetContainer("Certifications");
    }
}