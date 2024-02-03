using System.Threading.Tasks;
using Techemy.Configuration.Dto;

namespace Techemy.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
