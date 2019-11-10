using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Mvc;
using Data;
 
namespace WebLevio.Areas.adminstrator.Controllers
{
    public class MandatController : Controller
    {

        private Contexte2 ctx = new Contexte2();

        private String url = "http://localhost:18080/LevioMap-web/api/mandats/";
        // GET: adminstrator/Mandat
       

    //consommation web service

        [HttpGet]
        public ActionResult ListeMandat()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("listeMandat").Result;
            if (response.IsSuccessStatusCode)
            {
                ViewBag.result = response.Content.ReadAsAsync<IEnumerable<mandat>>().Result;
            }
            else
            {
                ViewBag.result = "Error";
            }

            return View();
        }


        [HttpGet]
        public ActionResult AddMandat()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EditAction(FormCollection collection)
        {
            try

            {

                var client = new RestClient(url);

                var request = new RestRequest("edit", Method.PUT);


                request.AddHeader("Content-type", "application/json");
                request.AddJsonBody(
                    new
                    {
                        idMandat = collection["idMandat"],
                        dateDebut = collection["dateDebut"],
                        dateFin = collection["dateFin"]
                    }); // 
                        // execute the request
                IRestResponse response = client.Execute(request);
                var content = response.Content;
            
                    return RedirectToAction("ListeMandat");
               


            }

            catch

            {
 
                return View();
            }
        }
        [HttpPost]
        public ActionResult AddMandat(FormCollection collection)
        {

            try

            {

                var client = new RestClient(url);

                var request = new RestRequest("assign", Method.POST);
                request.AddParameter("projetId", collection["projet_idProjet"], ParameterType.QueryString);
                request.AddParameter("resourceId", collection["ressource_idRessource"], ParameterType.QueryString);
                request.AddParameter("dateDebut", collection["dateDebut"], ParameterType.QueryString);
                request.AddParameter("dateFin", collection["dateFin"], ParameterType.QueryString);
                request.AddHeader("Accept", "application/json");
                // execute the request
                IRestResponse response = client.Execute(request);
                var content = response.Content;
                Console.WriteLine(request.ToString());
                Console.WriteLine(response.Content);
                return RedirectToAction("ListeMandat");
            }

            catch

            {
                return View();
            }
        }




        [HttpPost]
        public ActionResult DeleteMandat()
        {

            try

            {
                var routeValues = Url.RequestContext.RouteData.Values;
                var paramName = "mandateid";
                var id = routeValues.ContainsKey(paramName) ?
                    routeValues[paramName] :
                    Request.QueryString[paramName];
                Console.WriteLine(id.ToString());
                var client = new RestClient(url);

                var request = new RestRequest("delete", Method.POST);
                request.AddParameter("mandateid", id, ParameterType.QueryString);

                request.AddHeader("Accept", "application/json");
                Console.WriteLine(request.ToString());
                // execute the request
                IRestResponse response = client.Execute(request);
                var content = response.Content;

                Console.WriteLine(response.Content);
                return RedirectToAction("Index");
            }

            catch

            {
                return View();
            }
        }






       
        public ActionResult EditMandate(FormCollection collection,int id)
        {
            try

            {
                
                    var client = new RestClient(url);

                    var request = new RestRequest("mandats/edit", Method.PUT);


                    request.AddHeader("Content-type", "application/json");
                    request.AddJsonBody(
                        new
                        {
                            idMandat = collection["idMandat"],
                            dateDebut = collection["dateDebut"],
                            dateFin = collection["dateFin"]
                        }); // 
                            // execute the request
                    IRestResponse response = client.Execute(request);
                    var content = response.Content;
                mandat m = ctx.mandat.Where(x => x.idMandat.Equals(id)).First();

                if ( response.StatusCode.Equals("200"))
                    return RedirectToAction("ListeMandat");
           else
                    return View(m);
                

            }

            catch

            {
            
                mandat m = ctx.mandat.Where(x => x.idMandat.Equals(id)).First();
                return View(m);
            }
        }




        //methodes .Net


        public ActionResult Historique()
        {
            List<mandat> mandat = ctx.mandat.Where(x => x.dateFin < DateTime.Today).ToList();
            ViewBag.res = mandat;
            return View(mandat);
        }


        public ActionResult Archive()
        {
            List<mandat> mandat = ctx.mandat.Where(x => x.archive == true).ToList();


            ViewBag.res = mandat;
            return View(mandat);
        }



        public ActionResult getMandatsNotif()
        {

            List<mandat> ms = new List<Data.mandat>(); 
            //   List<mandat> mandat = ctx.mandat.Where (x=> System.Data.Entity.DbFunctions.DiffDays(x.dateFin,DateTime.Now)>=10).ToList();
            List<mandat> mandat = ctx.mandat.Where(x =>x.dateFin>DateTime.Now).ToList();
            foreach(var o in mandat)
            {
                if(calday(o.dateFin,DateTime.Now)<40)
                {
                    ms.Add(o);
                }
            }
            ViewBag.noti = ms.Count;
            ViewBag.res = ms;
            return View(ms);
        }

        public int nbrMandate()
        {

            List<mandat> ms = new List<Data.mandat>();
            //   List<mandat> mandat = ctx.mandat.Where (x=> System.Data.Entity.DbFunctions.DiffDays(x.dateFin,DateTime.Now)>=10).ToList();
            List<mandat> mandat = ctx.mandat.Where(x => x.dateFin > DateTime.Now).ToList();
            foreach (var o in mandat)
            {
                if (calday(o.dateFin, DateTime.Now) < 40)
                {
                    ms.Add(o);
                }
            }
            return ms.Count;
        }




        public double calday(DateTime d1,DateTime d2)
        {
            

            return (d1 - d2).TotalDays ;
        }

      
        
        
         
        public PartialViewResult Header()
        {
            int m = nbrMandate();
            ViewBag.n = m;
         return PartialView();
        }


    }
}