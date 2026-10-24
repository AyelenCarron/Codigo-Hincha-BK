using CodigoHincha.DAL.interfaces;
using Microsoft.AspNetCore.Mvc; 

namespace CodigoHincha.API.Controllers;

[ApiController]
[Route("api/images")]
public class [Name]Controller :ControllerBase
{
    private readonly IUnitOfWork dataBase;
    public ImagesController(IUnitOfWork dataBase)
    {
        this.dataBase = dataBase;
    }

    [HttpPost]

    public Task<IActionResult> Create()
}
