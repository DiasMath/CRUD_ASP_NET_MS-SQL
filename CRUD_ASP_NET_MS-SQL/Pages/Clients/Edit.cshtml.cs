using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static CRUD_ASP_NET_MS_SQL.Pages.Clients.IndexModel;

namespace CRUD_ASP_NET_MS_SQL.Pages.Clients;

public class EditModel : PageModel
{
    public ClientInfo clientInfo = new ClientInfo();
    public String errorMessage = "";
    public String successMessage = "";

    public void OnGet()
    {
        String id = Request.Query["id"];

        try
        {


        }
        catch (Exception ex)
        {
            errorMessage = ex.Message;
        }


    }
}
