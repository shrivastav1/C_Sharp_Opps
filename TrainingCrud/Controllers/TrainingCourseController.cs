using Microsoft.AspNetCore.Mvc;
using TrainingCrud.Models;
using TrainingCrud.Repositories;

namespace TrainingCrud.Controllers
{
    public class TrainingManagementController : Controller
    {
        private readonly TrainingCourseRepository _repository;

        public TrainingManagementController(TrainingCourseRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var trainingCourses = await _repository.GetAllAsync();
            return View(trainingCourses);
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TrainingCourse trainingCourse)
        {
            if (ModelState.IsValid)
            {
                await _repository.AddAsync(trainingCourse);
                return RedirectToAction(nameof(Index));
            }
            return View(trainingCourse);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var trainingCourse = await _repository.GetByIdAsync(id);
            if (trainingCourse == null)
            {
                return NotFound();
            }
            return View(trainingCourse);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TrainingCourse trainingCourse)
        {
            if(id != trainingCourse.Id)
            {
                return  NotFound();
            }
            if (ModelState.IsValid)
            {
                await _repository.UpdateAsync(trainingCourse);
                return RedirectToAction(nameof(Index));
            }
            return View(trainingCourse);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var trainingCourse = await _repository.GetByIdAsync(id);
            if (trainingCourse == null)
            {
                return NotFound();
            }
            return View(trainingCourse);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _repository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}