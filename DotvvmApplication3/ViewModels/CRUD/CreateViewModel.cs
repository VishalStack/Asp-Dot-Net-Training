using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotVVM.Framework.Runtime.Filters;
using DotvvmApplication3.Models;
using DotvvmApplication3.Services;

namespace DotvvmApplication3.ViewModels.CRUD
{
    public class CreateViewModel : MasterPageViewModel
    {
        private readonly StudentService studentService;

        public StudentDetailModel Student { get; set; } = new StudentDetailModel { EnrollmentDate = DateTime.UtcNow.Date };

        public CreateViewModel(StudentService studentService)
        {
            this.studentService = studentService;
        }

        public async Task AddStudent()
        {
            await studentService.InsertStudentAsync(Student);
            Context.RedirectToRoute("Default");
        }
    }
}
