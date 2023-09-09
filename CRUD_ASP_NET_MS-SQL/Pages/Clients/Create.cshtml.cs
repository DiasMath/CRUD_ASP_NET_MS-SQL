using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static CRUD_ASP_NET_MS_SQL.Pages.Clients.IndexModel;

namespace CRUD_ASP_NET_MS_SQL.Pages.Clients;

public class CreateModel : PageModel
{
    public ClientInfo clientInfo = new ClientInfo();
    public String errorMessage = "";
    public String successMessage = "";

    public void OnGet()
    {
    }

    public void OnPost()
    {
        clientInfo.name = Request.Form["name"];
        clientInfo.email = Request.Form["email"];
        clientInfo.phone = Request.Form["phone"];
        clientInfo.address = Request.Form["address"];
        clientInfo.appointment = Request.Form["appointment"];
        clientInfo.service = Request.Form["service"];

        if(clientInfo.name.Length == 0 || clientInfo.email.Length == 0 ||
           clientInfo.phone.Length == 0 || clientInfo.address.Length == 0||
           clientInfo.appointment.Length == 0 || clientInfo.service.Length == 0)
        {
            errorMessage = "Preencha todos os campos!";
            return;
        }

        clientInfo.name = ""; clientInfo.email = ""; clientInfo.phone = "";
        clientInfo.address = ""; clientInfo.appointment = ""; clientInfo.service = "";

        successMessage = "Novo cliente adicionado!";
    }
}
