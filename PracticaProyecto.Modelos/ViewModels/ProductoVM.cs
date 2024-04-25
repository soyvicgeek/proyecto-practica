﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace PracticaProyecto.Modelos.ViewModels
{
    public class ProductoVM
    {
        public Producto Producto { get; set; }
        public IEnumerable<SelectListItem> CategoriaLista { get; set; }
        public IEnumerable<SelectListItem> MarcaLista { get; set; }
    }
}