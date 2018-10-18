using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IamGonnaMakeItWork.Controllers
{
    public class StackController : Controller
    {
        static Stack<string> MyStack = new Stack<string>();
        string msg = "Success";
        // GET: Stack
        public ActionResult Index()
        {
            //ViewBag.MyStack = MyStack;
            return View();
        }

        public ActionResult AddOne()
        {
            int size = MyStack.Count() + 1;
            string addStack= "New Entry " + size.ToString();
            MyStack.Push(addStack);
            ViewBag.MyStack = msg;
            return View("Index");
        }

        public ActionResult AddHuge()
        {
            MyStack.Clear();

            for (int i = 2000; i > 0; i--)
            {
                AddOne();
            }
            ViewBag.MyStack = "HUGE!";
            return View("Index");
        }

        public ActionResult Display()
        {
            if (!MyStack.Any())
            {
                msg = "ERROR: There is nothing in the Stack, please add something.";
            }
            else
            {
                msg = "";
                foreach (string entry in MyStack)
                {

                    msg += entry + " ";
                }
            }
            ViewBag.MyStack = msg;
            return View("Index");
        }

        public ActionResult Delete()
        {
            if (!MyStack.Any())
            {
                msg = "ERROR: There is nothing in the Stack, please add something.";
            }
            else
            {
                MyStack.Pop();
                msg = "Last Item removed from stack.";
            }
            ViewBag.theQueue = msg;
            return View("Index");
        }

        public ActionResult Clear()
        {
            MyStack.Clear();
            ViewBag.MyStack = "Cleared";
            return View("Index");
        }

        public ActionResult Search()
        {
            string searchString = "Entry";
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            if (MyStack.Contains(searchString))
            {
                msg = searchString + " was found in the stack!";
            }
            else
            {
                msg = searchString + " was not found in the stack!";
            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            ViewBag.StopWatch = ts;
            ViewBag.theQueue = msg;
            return View("Index");
        }

        public ActionResult Menu()
        {
            MyStack.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}