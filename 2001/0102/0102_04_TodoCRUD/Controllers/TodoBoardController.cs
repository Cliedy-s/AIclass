using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _0102_04_TodoCRUD.DAL;
using _0102_04_TodoCRUD.Models;

namespace _0102_04_TodoCRUD.Controllers
{
    public class TodoBoardController : Controller
    {
        private TodoBoardContext db = new TodoBoardContext();

        // GET: TodoBoard
        public ActionResult Index()
        {
            return View(db.TodoBoard.ToList());
        }

        // GET: TodoBoard/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TodoBoard todoBoard = db.TodoBoard.Find(id);
            if (todoBoard == null)
            {
                return HttpNotFound();
            }
            return View(todoBoard);
        }

        // GET: TodoBoard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TodoBoard/Create
        // 초과 게시 공격으로부터 보호하려면 바인딩하려는 특정 속성을 사용하도록 설정하십시오. 
        // 자세한 내용은 https://go.microsoft.com/fwlink/?LinkId=317598을(를) 참조하십시오.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Contents,WriteTime,ReadCount,IsDone")] TodoBoard todoBoard)
        {
            if (ModelState.IsValid)
            {
                db.TodoBoard.Add(todoBoard);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(todoBoard);
        }

        // GET: TodoBoard/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TodoBoard todoBoard = db.TodoBoard.Find(id);
            if (todoBoard == null)
            {
                return HttpNotFound();
            }
            return View(todoBoard);
        }

        // POST: TodoBoard/Edit/5
        // 초과 게시 공격으로부터 보호하려면 바인딩하려는 특정 속성을 사용하도록 설정하십시오. 
        // 자세한 내용은 https://go.microsoft.com/fwlink/?LinkId=317598을(를) 참조하십시오.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Contents,WriteTime,ReadCount,IsDone")] TodoBoard todoBoard)
        {
            if (ModelState.IsValid)
            {
                db.Entry(todoBoard).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(todoBoard);
        }

        // GET: TodoBoard/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TodoBoard todoBoard = db.TodoBoard.Find(id);
            if (todoBoard == null)
            {
                return HttpNotFound();
            }
            return View(todoBoard);
        }

        // POST: TodoBoard/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TodoBoard todoBoard = db.TodoBoard.Find(id);
            db.TodoBoard.Remove(todoBoard);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
