using Hospital.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Hospital.Controllers
{
    public class HosiptalController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BookAppointment()
        {
            var doctors = _context.doctors.ToList();
            return View(doctors);
        }
        public IActionResult CompleteAppointment(int DoctorId)
        {
            ViewData["Doctorname"] = _context.doctors.FirstOrDefault(e => e.Id == DoctorId).Name;
             
            return View(DoctorId);
        }
    }
}
