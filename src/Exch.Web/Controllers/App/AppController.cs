using Asp.Versioning;
using Exch.Controllers;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace Exch.Web.Controllers.App;

[Controller]
[RemoteService(Name = "Exch")]
[Area("Exch")]
[ControllerName("Exch")]
[Route("api/app/[controller]")]
public class AppController : ExchController
{
}
