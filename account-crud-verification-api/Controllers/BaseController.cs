using account_crud_verification_api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace account_crud_verification_api.Controllers
{
    [Controller]
    public abstract class BaseController : ControllerBase
    {
        // returns the current authenticated account (null if not logged in)
        public Account Account => (Account)HttpContext.Items["Account"];
    }
}
