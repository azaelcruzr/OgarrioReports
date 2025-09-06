using System.Web.Mvc;
using OgarrioReports.Models;
using System.Collections.Generic;

namespace OgarrioReports.Controllers
{
    public class ReportDailyController : Controller
    {
        // GET: /ReportDaily/
        public ActionResult Index()
        {
            var ctx = new ReportDaily_Context();
            List<ReportDailyDB> reports = ctx.GetDailyReports();
            return View(reports);
        }
    }
}
