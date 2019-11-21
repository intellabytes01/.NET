using Portal.PortalBL.DropDown;
using Portal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portal.Controllers
{
    public class DropDownController : Controller
    {
        [HttpGet]
        public JsonResult GetDropdown(string type, int? id = null, string ids = null,string search=null)
        {
            List<DropDownViewModal> dropDownList = new List<DropDownViewModal>();
            IDropDownBL dropdownBL = new DropDownEngine();
            try
            {
                dropDownList = dropdownBL.GetList(type, id,ids,search);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Json(dropDownList, JsonRequestBehavior.AllowGet);
        }
    }
}