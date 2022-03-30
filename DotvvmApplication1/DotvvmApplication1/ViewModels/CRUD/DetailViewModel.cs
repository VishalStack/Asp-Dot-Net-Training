using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Runtime.Filters;
using DotvvmApplication1.Models;
using DotvvmApplication1.Services;

namespace DotvvmApplication1.ViewModels.CRUD
{
    public class DetailViewModel : MasterPageViewModel
    {
        private readonly StudentService studentService;
        
        public StudentDetailModel Student { get; set; }

        [FromRoute("Id")]
        public int Id { get; private set; }

        public DetailViewModel(StudentService studentService)
        {
            this.studentService = studentService;
        }

        public override async Task PreRender()
        {
            Student = await studentService.GetStudentByIdAsync(Id);
            await base.PreRender();
        }

        public async Task DeleteStudent()
        {
            await studentService.DeleteStudentAsync(Id);
            Context.RedirectToRoute("Default", replaceInHistory: true);
        }
    }
}
