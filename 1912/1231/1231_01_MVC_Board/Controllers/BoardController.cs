using _1231_01_MVC_Board.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1231_01_MVC_Board.Controllers
{
    public class BoardController : Controller
    {
        // GET: Board
        public ActionResult Index()
        {
            BoardManager manager = new BoardManager();
            return View(manager.GetAllList());
        }

        // GET: Board/Details/5
        public ActionResult Details(int id)
        {
            BoardManager manager = new BoardManager();
            return View(manager.GetBoardByID(id, true));
        }

        // GET: Board/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Board/Create
        [HttpPost]
        public ActionResult Create(Board post)
        {
            try
            {
                BoardManager manager = new BoardManager();
                if (manager.BoardInsert(post))
                    return RedirectToAction("Index");
                else
                    return View(post);
            }
            catch
            {
                return View();
            }
        }

        // GET: Board/Edit/5
        public ActionResult Edit(int id)
        {
            BoardManager manager = new BoardManager();
            return View(manager.GetBoardByID(id, false));
        }

        // POST: Board/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Board post)
        {
            try
            {
                BoardManager manager = new BoardManager();
                if (manager.BoardUpdate(id ,post))
                    return RedirectToAction("Index");
                else
                    return View(post);
            }
            catch
            {
                return View();
            }
        }

        // GET: Board/Delete/5
        public ActionResult Delete(int id)
        {
            BoardManager manager = new BoardManager();
            return View(manager.GetBoardByID(id, false));
        }

        // POST: Board/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Board post)
        {
            try
            {
                BoardManager manager = new BoardManager();
                if (manager.BoardDelete(id, post))
                    return RedirectToAction("Index");
                else
                    return View(post);
            }
            catch
            {
                return View();
            }
        }
    }
}
