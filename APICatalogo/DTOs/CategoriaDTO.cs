﻿using Microsoft.AspNetCore.Mvc.Formatters;

namespace APICatalogo.DTOs
{
    public class CategoriaDTO
    {
        public int CategoriaId { get; set; }
        public string? Nome { get; set; }
        public string?  ImagemUrl { get; set; }
        public ICollection<ProdutoDTO> Produtos { get; set; }

    }
}
