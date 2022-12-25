using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace scools.Controllers;

public class StudentController : Controller
{
   private readonly Context db;
    public StudentController(Context context)
    {
         db = context;
    }

   public IActionResult Student(string txt ,int id)
   {
      if (txt != null)
      {
          ViewBag.Student = db.tbl_Students.Where(x=>x.Name.Contains(txt) || x.Family.Contains(txt)).ToList();
      }else{
          ViewBag.Student = db.tbl_Students.ToList();

      }

      if (id != 0)
      {
         var Student = db.tbl_Students.Find(id);
        return View(Student);
      }else
      {
         return View();
      }
     
      
       
   }


   public IActionResult addStudent(Tbl_Student Student)
  
   {
      if (Student.Id!= 0)
      {
         //update
         db.tbl_Students.Update(Student);
         db.SaveChanges();
         return RedirectToAction("Student");
         
      }else
      {
          db.tbl_Students.Add(Student);
            db.SaveChanges();
            return RedirectToAction("Student");
      }

        
       
       
   }

   public IActionResult delete(int id)
   {
      var Student = db.tbl_Students.Find(id);
      db.tbl_Students.Remove(Student);
      db.SaveChanges();
      return RedirectToAction("Student");
      
   }
   
   
   
}
