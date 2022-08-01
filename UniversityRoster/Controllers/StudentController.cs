using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using UniversityRoster.Models;
using System.Collections.Generic;
using System.Linq;

namespace UniversityRoster.Controllers
{
  public class StudentsController : Controller
  {
    private readonly UniversityRosterContext _db;

    public StudentsController(UniversityRosterContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Students.UniversityRoster());
    }

   
  }
}