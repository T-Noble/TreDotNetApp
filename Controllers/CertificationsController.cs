using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using TreDotNetApp.Models;


namespace TreDotNetApp.Controllers;

public class CertificationsController
{
    //private readonly Container _certificationsContainer;

    public CertificationsController(Database cosmosDatabase)
    {
        var _certificationsContainer = cosmosDatabase.GetContainer("Certifications");
    }
}