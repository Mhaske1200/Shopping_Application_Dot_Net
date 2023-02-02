namespace SAL;
using BLL;
using BOL;
public class CustomerService
{

  public Customer GetCustomerByEmailAndPassword(string email, string password)
  {
    CustomerManager theCustomerManager = CustomerManager.GetCustomerManager();
    Customer c = theCustomerManager.GetCustomerByEmailAndPassword(email, password);

    return c;

  }

  public bool AddCustomer(Customer c)
  {
    CustomerManager theCustomerManager = CustomerManager.GetCustomerManager();
    return theCustomerManager.AddCustomer(c);
  }


}
