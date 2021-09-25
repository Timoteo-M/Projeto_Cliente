using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadastro_de_Pessoas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro_de_Pessoas.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Index()
        {
            PessoaModel pModel = new PessoaModel();
            return View(pModel.Listar());
        }

        // GET: Pessoa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pessoa/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pessoa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PessoaModel pModel)
        {
            //pModel.Salvar();

            //return RedirectToAction("Index");

            if (ModelState.IsValid)
            {
                pModel.Salvar();
                return RedirectToAction("Index");
            }
            else
            {
                return View(pModel);
            }
        }

        // GET: Pessoa/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            PessoaModel pModel = new PessoaModel();
            pModel.Editar(id);
            return View(pModel);
        }

        // POST: Pessoa/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PessoaModel pModel)
        {
            pModel.Atualizar();
            return RedirectToAction("Index");
        }

        // GET: Pessoa/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            PessoaModel pModel = new PessoaModel();
            pModel.Excluir(id);
            return RedirectToAction("Index");
        }

        // POST: Pessoa/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}