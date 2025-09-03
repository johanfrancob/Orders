using Microsoft.AspNetCore.Mvc;
using Orders.Shared.Entities;
using Orders.Backend.UnitsofWork.Interfaces;

namespace Orders.Backend.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CategoriesController : GenericController<Category>
    {
        public CategoriesController(IGenericUnitOfWork<Category> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
