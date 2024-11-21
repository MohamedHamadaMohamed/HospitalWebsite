using Hospital.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hospital.Models;

namespace Hospital.Controllers
{
    public class PatientController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        public IActionResult Index()
        {
            var patients = _context.Patients.Include(e=>e.doctor).ToList();
            return View(patients);   
        }
        public IActionResult CreateNewPatient(string name , DateOnly date , TimeOnly time, int doctorId)
        {

            _context.Patients.Add(new Patient() {Name = name , date = date,time = time,  doctorId= doctorId });
            _context.SaveChanges();
            return View();
        }
    }
}
