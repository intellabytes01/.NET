using Portal.PortalBL.ImportExcel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portal.Controllers
{
    public class ImportFileController : Controller
    {
        // GET: ImportFile
        [HttpPost]
        public ActionResult UploadFile(string name, string type=null)
        {
            string result = "";
            try
            {
                IImportBL importBL = new ImportEngine();
                result = importBL.ImportData(null, type, name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}