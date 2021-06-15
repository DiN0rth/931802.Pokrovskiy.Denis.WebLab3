using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebLab3.Models;

namespace WebLab3.Controllers
{
    public class MockupsController : Controller
    {
        [HttpGet]
        public IActionResult Questions()
        {
            QuestionsModel Model = QuestionsModel.Instance;
            Model.Reset();
            Model.Begin();
            return View(Model);
        }

        [HttpPost]
        public IActionResult Questions(QuestionsModel Model, string action)
        {
            Model = QuestionsModel.Instance;

            if (Request.Form["useranswer"] != "")
            {
                Model.useranswer = Int32.Parse(Request.Form["useranswer"]);
                Model.Accept();

                if (action == "Next")
                {
                    QuestionsModel Modelq = QuestionsModel.Instance;
                    Modelq.Begin();
                    return View(Modelq);
                }
                return RedirectToAction("Result");
            }
            else
            {
                QuestionsModel Modelq = QuestionsModel.Instance;
                return View(Modelq);
            }

        }
        public IActionResult Result()
        {
            QuestionsModel Model = QuestionsModel.Instance;
            if (Model.Answers == null)
                ViewBag.Result = "";
            else 
                ViewBag.Result = Model.Answers;
            ViewData["Total"] = "" + Model.count;
            ViewData["Correct"] = "" + Model.ranswers;
            return View();
        }
    }
}
