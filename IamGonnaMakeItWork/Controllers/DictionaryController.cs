﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IamGonnaMakeItWork.Controllers
{
    public class DictionaryController : Controller
    {
        // GET: Dictionary
        static public Dictionary<int, string> DictList = new Dictionary<int, string>();

        public ActionResult Index()
        {
            //ViewBag.addDict = add2Dicionary();
            //ViewBag.addB = addBiglist();
            //// ViewBag.deleteDict = DeleteDictionary();
            //ViewBag.clearDict = ClearDictionary();
            //.TheDict = 8;
            ////ViewBag.Findadict = FindAdict();
            // PLLEEEEASSEEEE SHOWO UPPPPPPPP
            return View();
        }

        public ActionResult Add2Dictionary()
        {
            string Tstring = "added Key number " + (DictList.Count + 1);
            DictList.Add(DictList.Count, Tstring);
            Tstring = "added Key number " + DictList.Count;
            ViewBag.localButton = Tstring;
            return View("Index");
        }

        public ActionResult AddBiglist()
        {
            int bigBumber = 1000;
            string Bstring = bigBumber + "items were added added";
            for (int i = 0; i <= bigBumber; i++)
            {
                Add2Dictionary();

            };
            ViewBag.localButton = Bstring;
            return View("Index");
        }
        public ActionResult Display()
        {
            string Bstring = 1000 + "Dictionary....";
            if (DictList.Count > 0)
            {
                foreach (var item in DictList)
                {

                    Bstring += "Key: " + item.Key + " Value: " + item.Value;
                };
            }
            else
            {
                Bstring = "no DICTIONARY!!!";
            }
            ViewBag.localButton = Bstring;
            return View("Index");
        }

        public ActionResult DeleteDictionary()
        {
            string Item1 = "An item was deleted, but which one?";
            if (DictList.Count == 0)
            {
                Item1 = "you dont have any dicts....";
            }
            else
            {
                DictList.Remove(1);
            }
            ViewBag.localButton = Item1;
            return View("Index");
        }

        public ActionResult Clear()
        {
            string DictClear = "Your Dict is clear... sad you had some good items here ;(";

            DictList.Clear();
            ViewBag.localButton = DictClear;
            return View("Index");

        }
        public ActionResult Search()
        {
            string Hole;
            if (DictList.Count > 0)
            {

                Hole = "You found a Dictionary!>>" + DictList[0];
            }
            else
            {
                Hole = "you do not have any Dictionaries Count is.." + DictList.Count;
            }
            ViewBag.localButton = Hole;
            return View("Index");
        }
        public ActionResult Menu()
        {
            return RedirectToAction("Index", "Home");
        }

    }
}