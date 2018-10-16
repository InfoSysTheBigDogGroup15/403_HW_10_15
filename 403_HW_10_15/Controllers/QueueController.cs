using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace _403_HW_10_15.Controllers
{
    public class QueueController : Controller
    {
        static Queue<string> theQueue = new Queue<string>();
        string display = "";
        // GET: Queue
        public ActionResult Index()
        {
            ViewBag.theQueue = theQueue;
            return View("Index");
        }

        //add to queue
        public ActionResult addToQueue()
        {
            int size = theQueue.Count() + 1;
            string addToQ = "New Entry " + size.ToString();
            theQueue.Enqueue(addToQ);
            return View();
        }
        //remove everything from the queue
        public ActionResult addListToQueue()
        {
            //remove everything from the queue
            clearQueue();
            //add 2000 to queue
            for (int i = 2000; i > 0; i--)
            {
                addToQueue();
            }
            return View();
        }
        //Display contents of queue
        public ActionResult displayQueue()
        {
            //error
            if (!theQueue.Any())
            {
                display = "ERROR: There is nothing in the Queue, please add something.";
            }
            else
            {
                foreach (string entry in theQueue)
                {
                    display = display + " " + entry;
                }
            }
            ViewBag.display = display;
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
                display = "Last Item removed from queue.";
            }
            return View();
        }
        //Clear the Queue
        public ActionResult clearQueue()
        {
            theQueue.Clear();
            return View();
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
            return View("Index");
        }
    }
}
