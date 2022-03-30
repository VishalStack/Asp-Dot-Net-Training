using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Runtime.Filters;
using DotvvmApplication3.Models;
using DotvvmApplication3.Services;

namespace DotvvmApplication3.ViewModels.CRUD
{
    public class EditViewModel : MasterPageViewModel
    {
        private readonly StudentService studentService;

        public StudentDetailModel Student { get; set; }

        [FromRoute("Id")]
        public int Id { get; private set; }

        public EditViewModel(StudentService studentService)
        {
            this.studentService = studentService;
        }

        public override async Task PreRender()
        {
            if (Id != 0)
            {
                Student = await studentService.GetStudentByIdAsync(Id);
            }
            await base.PreRender();
        }

        public async Task EditStudent()
        {
            await studentService.UpdateStudentAsync(Student);
            Context.RedirectToRoute("CRUD_Detail", new { Id = Id });
        }
    }
}
