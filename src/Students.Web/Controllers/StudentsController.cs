using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Students.Domain.Exceptions;
using Students.Domain.Interfaces.Repository;
using Students.Domain.Models;
using Students.Web.ViewModels;
using X.PagedList;

namespace Students.Web.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentsController(
            IStudentRepository studentRepository,
            IMapper mapper
        )
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index(int? page = 1)
        {
            if (page != null && page < 1)
            {
                page = 1;
            }

            int limit = 20;

            IPagedList<Student> students = await _studentRepository.ListStudentsAsync(page.Value, limit);

            return View(students.Select(_mapper.Map<ListStudentVM>));
        }

        public IActionResult Create()
        {
            CreateStudentVM vm = new();

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Post(CreateStudentVM vm)
        {
            if (!ModelState.IsValid)
            {
                TempData["error"] = "Please correct the errors.";
                return View("Create", vm);
            }

            Student student = _mapper.Map<Student>(vm);

            await _studentRepository.AddStudentAsync(student);

            TempData["success"] = "Student added successfully.";

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null || id == 0)
            {
                TempData["error"] = "Id not found.";
                return View("Index");
            }

            Student found = await _studentRepository.GetStudentsByIdAsync(id.Value);

            if (found is null)
            {
                TempData["error"] = "Id not found.";
                return View("Index");
            }

            UpdateOrDeleteStudentVM vm = _mapper.Map<UpdateOrDeleteStudentVM>(found);

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, UpdateOrDeleteStudentVM vm)
        {
            if (!ModelState.IsValid)
            {
                TempData["error"] = "Please correct the errors.";
                return View("Edit", vm);
            }

            try
            {
                Student student = _mapper.Map<Student>(vm);

                await _studentRepository.UpdateStudentAsync(id.Value, student);

                TempData["success"] = "Student updated successfully.";

                return RedirectToAction(nameof(Index));
            }
            catch (StudentNotFoundException)
            {
                TempData["error"] = "Id not found.";
                return View("Index");
            }
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null || id == 0)
            {
                TempData["error"] = "Id not found.";
                return View("Index");
            }

            Student found = await _studentRepository.GetStudentsByIdAsync(id.Value);

            if (found is null)
            {
                TempData["error"] = "Id not found.";
                return View("Index");
            }

            UpdateOrDeleteStudentVM vm = _mapper.Map<UpdateOrDeleteStudentVM>(found);

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Remove(int? id)
        {
            if (id is null || id == 0)
            {
                TempData["error"] = "Id not found.";
                return View("Index");
            }

            try
            {
                await _studentRepository.DeleteStudentAsync(id.Value);

                TempData["success"] = "Student deleted successfully.";

                return RedirectToAction(nameof(Index));
            }
            catch (StudentNotFoundException)
            {
                TempData["error"] = "Id not found.";
                return View("Index");
            }
        }
    }
}
