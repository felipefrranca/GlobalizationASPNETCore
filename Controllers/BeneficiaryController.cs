using GlobalizationASPNETCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GlobalizationASPNETCore.Controllers
{
    public class BeneficiaryController : Controller
    {
        // GET: BeneficiaryController
        public ActionResult Index()
        {
            return View(new List<Beneficiary>()
            {
                new Beneficiary()
                {
                    Name = "Teste 1",
                    Email = "teste.teste@teste.com.br"
                },
                new Beneficiary()
                {
                    Name = "Teste 2",
                    Email = "teste.teste@teste.com.br"
                },
                new Beneficiary()
                {
                    Name = "Teste 3",
                    Email = "teste.teste@teste.com.br"
                }
            });
        }

        // GET: BeneficiaryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BeneficiaryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BeneficiaryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BeneficiaryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BeneficiaryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BeneficiaryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BeneficiaryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
