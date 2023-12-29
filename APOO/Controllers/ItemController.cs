using APOO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APOO.Controllers
{
    public class ItemController : Controller
    {
        private readonly ItemService _itemService;

        public ItemController()
        {
            _itemService = new ItemService();
        }

        // GET: Item
        public ActionResult Index()
        {
            List<ItemTema> itens = _itemService.ObterTodos(); // Método fictício para obter todos os itens

            return View(itens);
        }

        // GET: Item/Details/5
        public ActionResult Details(int id)
        {
            // Lógica para obter detalhes de um item por ID
            // Exemplo: var item = _itemService.ObterPorId(id);
            return View();
        }

        // GET: Item/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Item/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ItemTema item)
        {
            if (ModelState.IsValid)
            {
                _itemService.Gravar(item);
                // Redirecionar para a página de detalhes ou outra página após criar o item
                return RedirectToAction("Index");
            }

            return View(item);
        }

        // GET: Item/Edit/5
        public ActionResult Edit(int id)
        {
            // Lógica para obter detalhes de um item por ID para edição
            // Exemplo: var item = _itemService.ObterPorId(id);
            return View();
        }

        // POST: Item/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ItemTema item)
        {
            if (ModelState.IsValid)
            {
                _itemService.Gravar(item);
                // Redirecionar para a página de detalhes ou outra página após editar o item
                return RedirectToAction("Index");
            }

            return View(item);
        }

        // GET: Item/Delete/5
        public ActionResult Delete(int id)
        {
            // Lógica para obter detalhes de um item por ID para exclusão
            // Exemplo: var item = _itemService.ObterPorId(id);
            return View();
        }

        // POST: Item/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            // Lógica para deletar o item por ID
            // Exemplo: _itemService.Deletar(id);
            return RedirectToAction("Index");
        }
    }
}