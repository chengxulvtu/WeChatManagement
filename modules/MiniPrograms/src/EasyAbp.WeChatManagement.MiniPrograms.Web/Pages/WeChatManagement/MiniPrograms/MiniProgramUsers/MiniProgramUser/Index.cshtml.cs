using System.Threading.Tasks;

namespace EasyAbp.WeChatManagement.MiniPrograms.Web.Pages.WeChatManagement.MiniPrograms.MiniProgramUsers.MiniProgramUser
{
    public class IndexModel : MiniProgramsPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
