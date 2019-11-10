using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace WebLevio.Areas.adminstrator.Controllers
{
    public class ReclamationController : Controller
    {
        private String url = "http://localhost:18080/LevioFinal-web/rest/comm/";
        // GET: adminstrator/Reclamation
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ListeReclamations()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("http://localhost:18080/LevioFinal-web/rest/comm/afficher").Result;
            if (response.IsSuccessStatusCode)
            {
                ViewBag.result = response.Content.ReadAsAsync<IEnumerable<reclamation>>().Result;
            }
            else
            {
                ViewBag.result = "Error";
            }

            return View();
        }

        [HttpGet]
        public ActionResult Addrec()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Addrec(reclamation rec)
        {
            HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("");
            client.PostAsJsonAsync("http://localhost:18080/PIGLprojet-web/rest/comm/add", rec).ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode());
            return RedirectToAction("Index");
        }


        [HttpGet]
        // POST: Product/Delete/5
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {


                //HTTP DELETE
                var deleteTask = client.DeleteAsync("http://localhost:18080/PIGLprojet-web/rest/comm/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
        }


    }
}