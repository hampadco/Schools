using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace scools.Controllers;

public class personelController : Controller
{
   private readonly Context db;
    public personelController(Context context)
    {
         db = context;
    }

   public IActionResult Personel(string txt ,int id)
   {
      if (txt != null)
      {
          ViewBag.Personel = db.tbl_Personels.Where(x=>x.Name.Contains(txt) || x.Family.Contains(txt)).ToList();
      }else{
          ViewBag.Personel = db.tbl_Personels.ToList();

      }

      if (id != 0)
      {
         var Personel = db.tbl_Personels.Find(id);
        return View(Personel);
      }else
      {
         return View();
      }
     
      
       
   }


   public IActionResult addPersonel(Tbl_Personel Personel)
  
   {
      if (Personel.Id!= 0)
      {
         //update
         db.tbl_Personels.Update(Personel);
         db.SaveChanges();
         return RedirectToAction("Personel");
         
      }else
      {
          db.tbl_Personels.Add(Personel);
            db.SaveChanges();
            return RedirectToAction("Personel");
      }

        
       
       
   }

   public IActionResult delete(int id)
   {
      var Personel = db.tbl_Personels.Find(id);
      db.tbl_Personels.Remove(Personel);
      db.SaveChanges();
      return RedirectToAction("Personel");
      
   }
   
   
   
}
