using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace IamGonnaMakeItWork.Controllers
{
    public class QueueController : Controller
    {
        static Queue<string> theQueue = new Queue<string>();
        string display = "Success";
        // GET: Queue
        public ActionResult Index()
        {
            //ViewBag.theQueue = theQueue;
            return View();
        }

        //add to queue
        public ActionResult addToQueue()
        {
            int size = theQueue.Count() + 1;
            string addToQ = "New Entry " + size.ToString();
            theQueue.Enqueue(addToQ);
            ViewBag.theQueue = display;
            return View("Index");
        }

        //add a list of 2000 to the queue
        public ActionResult addListToQueue()
        {
            //remove everything from the queue
            clearQueue();
            //add 2000 to queue
            for (int i = 2000; i > 0; i--)
            {
                addToQueue();
            }
            ViewBag.theQueue = "HUGE!";
            return View("Index");
        }

        //Display contents of queue
        public ActionResult displayQueue()
        {
            //error message
            if (!theQueue.Any())
            {
                display = "ERROR: There is nothing in the Queue, please add something.";
            }
            else
            {
                display = "";
                foreach (string entry in theQueue)
                {

                    display += entry + " ";
                }
            }
            ViewBag.theQueue = display;
            return View("Index");
        }
        //delete any item from the queue
        public ActionResult deleteItem()
        {
            if (!theQueue.Any())
            {
                display = "ERROR: There is nothing in the Queue, please add something.";
            }
            else
            {
                theQueue.Dequeue();
                display = "First Item removed from queue.";
            }
            ViewBag.theQueue = display;
            return View("Index");
        }
        //Clear the Queue
        public ActionResult clearQueue()
        {
            theQueue.Clear();
            ViewBag.theQueue = "Cleared";
            return View("Index");
        }
        //search the Queue
        public ActionResult searchQueue()
        {
            string searchString = "Entry";
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            if (theQueue.Contains(searchString))
            {
                display = searchString + " was found in the queue!";
            }
            else
            {
                display = searchString + " was not found in the queue!";
            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            ViewBag.StopWatch = ts;
            ViewBag.theQueue = display;
            return View("Index");
        }
        public ActionResult Menu()
        {
            theQueue.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
