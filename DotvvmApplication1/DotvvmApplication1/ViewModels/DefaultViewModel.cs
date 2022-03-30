using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotvvmApplication1.Models;
using DotvvmApplication1.Services;

namespace DotvvmApplication1.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {

        private readonly StudentService studentService;

        [Bind(Direction.ServerToClient)]
        public List<StudentListModel> Students { get; set; }

		public DefaultViewModel(StudentService studentService)
        {
            this.studentService = studentService;
        }
        public override async Task PreRender()
        {
            Students =  await studentService.GetAllStudentsAsync();
            await base.PreRender();
        }

    }
}
