using System.Collections.Generic;
using System;

namespace JobBoard.Models
{
  public class Contact
  {
    private string Name;
    private string Email;
    private int Phone;

    public Contact(string contactName, string contactEmail, int contactPhone)
    {
      Name = contactName;
      Email = contactEmail;
      Phone = contactPhone;
    }
    // public string GetName()
    // {
    //   return Name;
    // }
    //
    // public string GetEmail()
    // {
    //   return Email;
    // }
    //
    public string GetContactInfo()
    {
      return Name + ", " + Email + ", " + Phone;
    }

  }
}
