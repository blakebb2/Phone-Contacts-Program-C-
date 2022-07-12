
using System;
using System.Collections.Generic;
//using static System.Text.Json.JsonSerializer;

// current possible improvements: formatting the pirnt statements, how to start and end loops, error if wrong format typed, search function?, type add to add contact or just print list.any other add ons



public class HelloWorld
{
    
    public static void Main(string[] args)
    {
    Console.WriteLine ("Hello Mono World");

    // create contacts dictionary
    IDictionary<string, string> userData = new Dictionary<string, string>();

    Console.WriteLine("Do you want to add a contact? (y/n)");
    string confirm = Console.ReadLine();
    
    
    
    string contactName = "";
    string contactNum = "";
    
    while (confirm.Contains('y')) {
    Console.WriteLine("Enter contact name:");
    contactName = Console.ReadLine();
    Console.WriteLine("Enter number:");
    contactNum = Console.ReadLine();
    //add name and num in to dictionary
    userData.Add(contactName, contactNum);
    
    Console.WriteLine("Do you want to: \n1: add another contact \n2: view current dictionary \n 3: search current dictionary? (1/2/3)");
    confirm = Console.ReadLine();
    if (confirm.Contains("1")) {
        confirm = "y";
    }
    
    
    if (confirm.Contains("2")) {
      foreach (KeyValuePair<string, string> item in userData)
        {
            Console.Write("Contact: " + item.Key +"    Number: " + item.Value);
      Console. WriteLine("\n");
      Console. WriteLine();
        }
    }
    
    
    if (confirm.Contains("3")) {
        Console.WriteLine("Search contacts:");
        contactName = Console.ReadLine();
        // if letters or numbers in contact, return those containing
        foreach (KeyValuePair<string, string> item in userData)
        { // length of search
        int stringlength = (item.Key).Length - 1;
        if ((item.Key).Substring(0,(stringlength)).Contains(contactName))
        {
            Console.Write("Contact: " + item.Key +"    Number: " + item.Value);
        }
        }
    }
    
    }
    foreach (KeyValuePair<string, string> item in userData)
   {
      Console.Write("Contact: " + item.Key +"    Number: " + item.Value);
      Console. WriteLine("\n");
      Console. WriteLine();
   }
}
}












    /*
        if (contactNum.Equals(contactNum))
    {
        ErrorMesssage("Make sure");
    }

    if (userData.Equals(contactName))
    {
        ErrorMesssage($"Contact: {contactName} already exist!");
    }
    else
    {
        //get count of key/value items
    Console.WriteLine(userData.Count);
    }
    
    }
    }


    if (userName.Equals(password, StringComparison.OrdinalIgnoreCase))
    {
        ErrorMesssage("Username and Password cannot be the same");
    }
    if (userData.ContainsKey(userName))
    {
        ErrorMesssage($"Username: {userName} already exist!");
    }
    else
    {
        //get count of key/value items
        Console.WriteLine(userData.Count);
    }
    userData.Add(userName, password);
    }
}

    //input for user to add username and password 
    string contactName = "";
    string contactNum = "";

    SystemMessage("Enter Contact Name :");
    contactName = Console.ReadLine();

    SystemMessage("Enter their Number :");
    contactNum = Console.ReadLine();

    //add name and num in to dictionary
    userData.Add(contactName, contactNum);

    //check that username is not the same aas the password for better security
    if (contactNum.Equals(contactNum))
    {
        ErrorMesssage("Make sure");
    }

    if (userData.Equals(contactName))
    {
        ErrorMesssage($"Contact: {contactName} already exist!");
    }
    else
    {
        //get count of key/value items
        Console.WriteLine(userData.Count);
    }
    }
}

private static void Register() {
private static Dictionary<string, string> userData = new Dictionary<string, string>();

    //input for user to add username and password 
    string contactName = "";
    string contactNum = "";

    SystemMessage("Enter Contact Name :");
    contactName = Console.ReadLine();

    SystemMessage("Enter their Number :");
    contactNum = Console.ReadLine();

    //add name and num in to dictionary
    userData.Add(contactName, contactNum);

    //check that username is not the same aas the password for better security
    if (contactNum.Equals(contactNum))
    {
        ErrorMesssage("Make sure");
    }

    if (userData.Equals(contactName))
    {
        ErrorMesssage($"Contact: {contactName} already exist!");
    }
    else
    {
        //get count of key/value items
        Console.WriteLine(userData.Count);
    }
}
*/
