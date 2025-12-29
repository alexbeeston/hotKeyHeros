using Microsoft.AspNetCore.Mvc;
using Data.Models;
using Data;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CollectionsController : ControllerBase
{
    public CollectionsController()
    {
        DbContext = new LocalDbFactory().CreateDbContext(Array.Empty<string>());
    }

    [HttpGet]
    public IEnumerable<DataCollectionEntity> Get()
    {
        return DbContext.Collections;
    }

    private LocalDbContext DbContext { get; set; }
}
