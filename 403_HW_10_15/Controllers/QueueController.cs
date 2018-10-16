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
        // GET: Queue
        public ActionResult Index()
        {
            //does this work?
            Contract.Ensures(Contract.Result<ActionResult>() != null);
            Queue<string> theQueue = new Queue<string>();
            //add to queue
            void addToQueue(Queue<string> q)
            {
                int size = q.Count() + 1;
                string addToQ = "New Entry " + size.ToString();
                q.Enqueue(addToQ);
            }
            //remove everything from the queue
            void addListToQueue(Queue<string> qBig)
            {
                //remove everything from the queue
                clearQueue(qBig);
                //add 2000 to queue
                for (int i = 2000; i > 0; i--)
                {
                    addToQueue(qBig);
                }
            }
            //Display contents of queue
            string displayQueue(Queue<string> qDisplay)
            {
                string display = "";
                //error
                if (!qDisplay.Any())
                {
                    display = "ERROR: There is nothing in the Queue, please add something.";
                }
                else
                {
                    foreach (string entry in qDisplay)
                    {
                        display = display + " " + entry;
                    }
                }
                return display;
            }
            //delete any item from the queue
            void deleteItem(Queue<string> qDelete)
            {
                string display = "";
                if (!qDelete.Any())
                {
                    display = "ERROR: There is nothing in the Queue, please add something.";
                }
                else
                {
                    qDelete.Dequeue();
                    display = "Last Item removed from queue.";
                }
            }
            //Clear the Queue
            void clearQueue(Queue<string> qClear)
            {
                qClear.Clear();
            }
            //search the Queue
            string searchQueue(Queue<string> qSearch)
            {
                string display = "";
                string searchString = "Entry";
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                if (qSearch.Contains(searchString))
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
                return display;
            }
            return View();
        }
    }
}