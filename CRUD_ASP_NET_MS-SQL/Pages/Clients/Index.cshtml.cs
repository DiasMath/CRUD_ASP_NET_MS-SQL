using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace CRUD_ASP_NET_MS_SQL.Pages.Clients;

public class IndexModel : PageModel
{
    public List<ClientInfo> listClients = new List<ClientInfo>();


    public void OnGet()
    {
        try
        {
            String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=MyBarberShop;Integrated Security=True";
        
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                String sql = "SELECT * FROM clients";
                
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClientInfo clientInfo = new ClientInfo();
                            clientInfo.id = "" + reader.GetInt32(0);
                            clientInfo.name = reader.GetString(1);
                            clientInfo.email = reader.GetString(2);
                            clientInfo.phone = reader.GetString(3);
                            clientInfo.address = reader.GetString(4);
                            clientInfo.appointment = reader.GetString(5);
                            clientInfo.service = reader.GetString(6);

                            listClients.Add(clientInfo);
                        }
                    }
                }

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.ToString());
        }

    }

    public class ClientInfo
    {
        public String id;
        public String name;
        public String email;
        public String phone;
        public String address;
        public String appointment;
        public String service;

    }
}
