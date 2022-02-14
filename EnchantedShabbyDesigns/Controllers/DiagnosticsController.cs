using System.Reflection;
using DotNetCore.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Esd.Controllers;

[AllowAnonymous]
[ApiController]
[Route("diagnostics")]
public sealed class DiagnosticsController : ControllerBase
{
    [HttpGet("datetime")]
    public DateTime DateTime() => Assembly.GetExecutingAssembly().FileInfo().LastWriteTime;
}
