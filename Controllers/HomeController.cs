using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace scools.Controllers;

public class HomeController : Controller
{
   private readonly Context db;
    public HomeController(Context context)
    {
         db = context;
    }

   public IActionResult teacher(string txt ,int id)
   {
      if (txt != null)
      {
          ViewBag.teacher = db.tbl_Teachers.Where(x=>x.Name.Contains(txt) || x.Family.Contains(txt)).ToList();
      }else{
          ViewBag.teacher = db.tbl_Teachers.ToList();

      }

      if (id != 0)
      {
         var teacher = db.tbl_Teachers.Find(id);
        return View(teacher);
      }else
      {
         return View();
      }
     
      
       
   }


   public IActionResult addteacher(Tbl_Teacher teacher)
  
   {
      if (teacher.Id!= 0)
      {
         //update
         db.tbl_Teachers.Update(teacher);
         db.SaveChanges();
         return RedirectToAction("teacher");
         
      }else
      {
          db.tbl_Teachers.Add(teacher);
            db.SaveChanges();
            return RedirectToAction("teacher");
      }

        
       
       
   }

   public IActionResult delete(int id)
   {
      var teacher = db.tbl_Teachers.Find(id);
      db.tbl_Teachers.Remove(teacher);
      db.SaveChanges();
      return RedirectToAction("teacher");
      
   }
   
   
   
}
