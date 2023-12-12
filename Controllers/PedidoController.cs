using Microsoft.AspNetCore.Mvc;
using Routing2.Models;

namespace Routing2.Controllers
{
	public class PedidoController : Controller
	{
		[Route("Pedido/CrearPedido")]
		public IActionResult CrearPedido([Bind("Cliente,Direccion,Ciudad")]Pedido pedido)
		{
			return View();
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
