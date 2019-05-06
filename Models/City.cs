using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace World.Models
{
  public class City
  {
      // private string _code;
      private int _id;
      private string _name;
      private string _countryCode;
      private int _population;

    public City (int id)
    {
      //_code = code
       _id = id;
    }

    // public string GetCode()
    // {
    //   return _code;
    // }
    //
    // public void SetCode(string code)
    // {
    //   _code = code;
    // }

    // public int GetId()
    // {
    //   return _id;
    // }
    public string GetName()
    {
      return _name;
    }
    public string GetCountryCode()
    {
      return _countryCode;
    }
    public int GetPopulation()
    {
      return _population;
    }

    public static List<City> GetAll(string codes)
    {
      List<City> allItems = new List<City> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM city where countrycode = '"+ codes + "';";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        int itemId = rdr.GetInt32(0);
        City newItem = new City(itemId);
        newItem._name = rdr.GetString(1);
        newItem._countryCode = rdr.GetString(2);
        newItem._population = rdr.GetInt32(4);
        allItems.Add(newItem);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allItems;
    }


    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }

    // public static Item Find(int searchId)
    // {
    //   return _instances[searchId-1];
    // }

  }
}
