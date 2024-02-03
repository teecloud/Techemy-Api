using System.ComponentModel.DataAnnotations;

namespace Techemy.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}