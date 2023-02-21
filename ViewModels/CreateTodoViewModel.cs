using System.ComponentModel.DataAnnotations;

namespace Todo_list.ViewModels
{
    public class CreateTodoViewModel
    {
        [Required]
        public string Title { get; set; }
    }
}
