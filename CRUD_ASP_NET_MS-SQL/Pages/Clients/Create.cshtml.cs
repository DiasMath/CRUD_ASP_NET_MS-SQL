using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
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

        // salvar o cliente no DB
        try
        {
            String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=MyBarberShop;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                String sql = "INSERT INTO clients " +
                             "(name, email, phone, address, appointment, service) VALUES" +
                             "(@name, @email, @phone, @address, @appointment, @service);";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@name", clientInfo.name);
                    command.Parameters.AddWithValue("@email", clientInfo.email);
                    command.Parameters.AddWithValue("@phone", clientInfo.phone);
                    command.Parameters.AddWithValue("@address", clientInfo.address);
                    command.Parameters.AddWithValue("@appointment", clientInfo.appointment);
                    command.Parameters.AddWithValue("@service", clientInfo.service);

                    command.ExecuteNonQuery();
                }
            }
        }
        catch(Exception ex)
        {
            errorMessage = ex.Message;
            return;
        }


        clientInfo.name = ""; clientInfo.email = ""; clientInfo.phone = "";
        clientInfo.address = ""; clientInfo.appointment = ""; clientInfo.service = "";

        successMessage = "Novo cliente adicionado!";

        Response.Redirect("/Clients/Index");
    }
}
