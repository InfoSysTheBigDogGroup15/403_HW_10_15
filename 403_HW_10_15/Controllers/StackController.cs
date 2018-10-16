using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403_HW_10_15.Controllers
{
    public class StackController : Controller
    {
        static Stack<string> MyStack = new Stack<string>();
        string msg = "Success";
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

            ViewBag.MyStack = msg;
            return View("Index");
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
            ViewBag.MyStack = msg;
            return View("Index");
        }

        public ActionResult Display()
        {
            ViewBag.Title = "Stack";
            ViewBag.MyStack = MyStack;
            return View("Index");

        }

        public ActionResult Delete()
        {
            
            {
                if (MyStack.Count == 0)
                {
                    ViewBag.MyStack = "Stack is Empty";
                    return View("Index");
                }
                else
                {
                    MyStack.Pop();
                    ViewBag.MyStack = msg;
                    return View("Index");
                }
            }
            
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
            string stringToFind = "FIXME";
            if (MyStack.Contains(stringToFind))
            {
                ViewBag.MyStack = msg;
                return View("Index");
            }
            else
            {
                ViewBag.MyStack = msg;
                return View("Index");
            }
        }

       
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//namespace _403_HW_10_15.Controllers
//{
//    public class StackController : Controller
//    {
//        // GET: Stack
//public ActionResult Index()
//{
//    Stack<string> myStack = new Stack<string>();
//    // Add a value
//    string addAValueStack()
//    {
//String value = (myStack.Count + 1).ToString();
//myStack.Push(value);
//        return value + " was added to the stack";
//    }
//    //Add huge list of items
//    string addAHugeListStack()
//    {
//        myStack.Clear();
//        const int HUGE_VALUE = 2000;
//        for (int i = 0; i < HUGE_VALUE; ++i)
//        {
//            String myString = i.ToString();
//            myString = "New Entry " + myString;
//            myStack.Push(myString);

//        }
//        return HUGE_VALUE + " items added to stack";
//    }
//    //Display
//    string displayStack()
//    {
//        string allThingsToDisplay = "Stack contains: ";
//        for (int i = 0; i < myStack.Count; ++i)
//        {
//            allThingsToDisplay = allThingsToDisplay + myStack.ElementAt(myStack.Count - i) + " ";
//        }
//        return allThingsToDisplay;
//    }
//    //Delete an item
//    string deleteAnItem()
//    {
//        if (myStack.Count == 0)
//        {
//            return "No item can be deleted";
//        }
//        else
//        {
//            myStack.Pop();
//            return "Most recent item was deleted";
//        }
//    }
//    //Clear
//    string clearTheStack()
//    {
//        myStack.Clear();
//        string numInStack = myStack.Count.ToString();
//        return "Stack contains " + numInStack + "items";        //I did it this way to check that is actually worked
//    }
//    //Search
//    string searchStack()
//    {
//        string stringToFind = "FIXME";
//        //cin >> stringToFind
//        if (myStack.Contains(stringToFind))
//        {
//            return "item found";
//        }
//        else
//        {
//            return "item not found";
//        }
//    }
//    return View();
//}
//    }
//}