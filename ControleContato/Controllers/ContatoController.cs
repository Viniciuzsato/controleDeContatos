﻿using ControleContato.Models;
using ControleContato.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ControleContato.Controllers
{
	public class ContatoController : Controller
	{
        private readonly IContatoRepositorio _contatoRepositorio;

        public ContatoController(IContatoRepositorio contatoRepoitorio)
        {
            _contatoRepositorio = contatoRepoitorio;
        }

		public IActionResult Index()
		{
            List<ContatoModel> contatos = _contatoRepositorio.BuscarTodos();
            return View(contatos);
		}

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");
        }
    }
}
