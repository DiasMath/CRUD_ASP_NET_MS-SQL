using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD_ASP_NET_MS_SQL.Pages.Clients;

public class IndexModel : PageModel
{
    public List<ClientInfo> listClients = new List<ClientInfo>();


    public void OnGet()
    {
    }

    public class ClientInfo
    {
        public String id;
        public String name;
        public String email;
        public String phone;
        public String adress;
        public String appointment;
        public String service;

    }
}
