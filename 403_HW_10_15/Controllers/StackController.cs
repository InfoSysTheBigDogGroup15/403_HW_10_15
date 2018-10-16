<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403_HWTwo.Controllers
{
    public class StackController : Controller
    {
        static Stack<string> MyStack = new Stack<string>();
        
        // GET: Stack
        public ActionResult Index()
        {
            ViewBag.Title = "Stack";
            ViewBag.MyStack = MyStack;
            return View();
        }

        public ActionResult AddOne()
        {
            MyStack.Push("New Entry " + (MyStack.Count + 1));


            return RedirectToRoute("Index");
        }

        public ActionResult AddHuge()
        {
            MyStack.Clear();

            int i = 0;

            while (i < 2000) 
            {
                MyStack.Push("New Entry " + (MyStack.Count + 1));
                i++;
            }

            return RedirectToRoute("Index");
        }

        public ActionResult Display()
        {
            ViewBag.Title = "Stack";
            ViewBag.MyStack = MyStack;
            return View("Index");
        }

        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult Clear()
        {
            ViewBag.Title = "Stack";
            MyStack.Clear();
            ViewBag.MyStack = MyStack;
            return View("Index");
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Menu()
        {
            return RedirectToAction("Index", "Home");
        }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403_HWTwo.Controllers
{
    public class StackController : Controller
    {
        // GET: Stack
        public ActionResult Index()
        {
            return View();
        }
    }
>>>>>>> e072bf6e263e10154302c4d53ba4fb327fa1c1d1
}