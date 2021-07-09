using Microsoft.AspNetCore.Mvc;

using Historias.Imoveis;
using System.Threading.Tasks;

using WebApp.Factories;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ImovelController : Controller
    {
        private readonly ICriarImovel _criarImovel;
        private readonly IAlterarImovel _alterarImovel;
        private readonly IExcluirImovel _excluirImovel;
        private readonly IConsultasImovel _consultasImovel;

        public ImovelController(ICriarImovel criarImovel, 
                                IAlterarImovel alterarImovel, 
                                IExcluirImovel excluirImovel, 
                                IConsultasImovel consultasImovel)
        {
            _criarImovel = criarImovel;
            _alterarImovel = alterarImovel;
            _excluirImovel = excluirImovel;
            _consultasImovel = consultasImovel;
        }

        public async Task<IActionResult> Index()
        {
            var listaImoveis = await _consultasImovel.ListaTodos();
            var listaAutoresViewModel = ImovelFactory.MapearListaImovelViewModel(listaImoveis);

            return View(listaAutoresViewModel);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar(ImovelViewModel imovelViewModel)
        {
            if (ModelState.IsValid)
            {
                var imovel = ImovelFactory.MapearImovel(imovelViewModel);

                await _criarImovel.Executar(imovel);

                return RedirectToAction("Index");
            }

            return View(imovelViewModel);
        }

        public async Task<IActionResult> Alterar(int id)
        {
            var imovel = await _consultasImovel.BuscarPeloId(id);

            if (imovel == null)
            {
                return RedirectToAction("Index");
            }            

            var imovelViewModel = ImovelFactory.MapearImovelViewModelAlterar(imovel);

            return View(imovelViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Alterar(ImovelViewModel autorViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(autorViewModel);
            }

            var imovel = ImovelFactory.MapearImovel(autorViewModel);

            await _alterarImovel.Execultar(imovel);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detalhar(int id)
        {
            var Imovel = await _consultasImovel.BuscarPeloId(id);

            if (Imovel == null)
            {
                return RedirectToAction("Index");
            }

            var autorViewModel = ImovelFactory.MapearImovelViewModel(Imovel);

            return View(autorViewModel);
        }

        public async Task<IActionResult> Excluir(int id)
        {
            var imovel = await _consultasImovel.BuscarPeloId(id);

            if (imovel == null)
            {
                return RedirectToAction("Index");
            }


            await _excluirImovel.Executar(imovel);

            return RedirectToAction("Index");
        }

        #region API Calls
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var listaImoveis = await _consultasImovel.ListaTodos();
            var listaAutoresViewModel = ImovelFactory.MapearListaImovelViewModel(listaImoveis);
            return Json(new { data = listaAutoresViewModel });
        }        
        #endregion
    }
}
