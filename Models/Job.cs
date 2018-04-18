using System.Collections.Generic;
using System;

namespace JobBoard.Models
{
    public class JobOpening
    {
      private string Title;
      private string Description;
      private Contact Contact;

      private static List<JobOpening> _instances = new List<JobOpening> {};

      public JobOpening(string jobTitle, string jobDescription, Contact ContactName)
      {
        Title = jobTitle;
        Description = jobDescription;
        Contact = ContactName;
      }

      public void SetTitle(string newTitle)
      {
        Title = newTitle;
      }
      public string GetTitle()
      {
        return Title;
      }
      public void SetDescription(string newDescription)
      {
        Description = newDescription;
      }
      public string GetDescription()
      {
        return Description;
      }

      public void SetContact(Contact newContact)
      {
        Contact = newContact;
      }

      public Contact GetContact()
      {
        return Contact;
      }

      public static List<JobOpening> GetAll()
      {
          return _instances;
      }
      public void Save()
      {
          _instances.Add(this);
      }
      public static void ClearAll()
      {
        _instances.Clear();
      }
    }
}
