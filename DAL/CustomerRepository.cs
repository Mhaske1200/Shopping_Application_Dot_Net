namespace DAL;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using BOL;
public static class CustomerRepository
{

  public static List<Customer> allCustomers = JsonSerializer.Deserialize<List<Customer>>(File.ReadAllText("../customers.json"));


  public static List<Customer> GetAllCustomers()
  {
     return allCustomers;
  }

  public static Customer GetCustomerByEmailAndPassword(string email, string password)
  {
    var theCustomer = (from cust in allCustomers
                       where cust.Email == email && cust.Password == password
                       select cust).FirstOrDefault();

    return theCustomer as Customer;

  }

  public static bool AddCustomer(Customer c)
  {
    allCustomers.Add(c);
    string jsonString = JsonSerializer.Serialize(allCustomers);
    File.WriteAllText("../customers.json", jsonString);
    return true;
  }

}
