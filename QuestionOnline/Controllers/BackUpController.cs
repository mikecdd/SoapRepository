﻿
using QADAL.EntityFrameWorkCore.Models;
using QAServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestionOnline.Controllers
{
    public class BackUpController : Controller
    {
        ImproveReportServer ir = new ImproveReportServer();

        public ImproveReport AddReport(string typeid,string title,string content,string filename) 
        {
            //验证数据

            var model = new ImproveReport() 
            {
                regdate=DateTime.Now,
                regman=Common.CommonClass.GetUserName(),
                regmanid=Common.CommonClass.GetPartyIdCount(),
                reportcontent=content,
                title=title,
                typeid=Convert.ToInt32(typeid)
            };
            return ir.Add(model);
        }



        public ActionResult Index()
        {
            return View();
        }

    }
}
