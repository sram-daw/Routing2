﻿namespace Routing2.Models
{
	public class Pedido
	{
		public string Cliente { get; set; }
		public string Direccion {  get; set; }
		public string Ciudad { get; set;}
		public Producto Producto{ get; set; }
	}
}
