using System.ComponentModel.DataAnnotations;

namespace Jiesen.Dispatcher.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}