using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace World.Models
{
  public class Country
  {
      private string _code;
      private string _name;
      private int _capital;
      private string _region;
      private float _lifeExpectancy;

    public Country (string code)
    {
      _code = code;
    }

    public string GetCode()
    {
      return _code;
    }

    // public void SetCode(string code)
    // {
    //   _code = code;
    // }
    public string GetName()
    {
      return _name;
    }

    public int GetCapital()
    {
      return _capital;
    }

    public string GetRegion()
    {
      return _region;
    }

    public float GetLifeExpectancy()
    {
      return _lifeExpectancy;
    }


    // public int GetId()
    // {
    //   return _id;
    // }

    public static List<Country> GetAll()
    {
      List<Country> allItems = new List<Country> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM country;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        string itemId = rdr.GetString(0);
        Country newItem = new Country(itemId);
        newItem._name = rdr.GetString(1);
        if(rdr.GetValue(13).GetType() == 1.GetType())
        {
          newItem._capital = rdr.GetInt32(13);
        }

         if(rdr.GetValue(7).GetType() == (newItem._lifeExpectancy).GetType())
         {
          //Console.WriteLine(rdr.GetValue(7));
         newItem._lifeExpectancy = rdr.GetFloat(7);
        }
        newItem._region = rdr.GetString(3);




        allItems.Add(newItem);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allItems;
    }

    public static List<Country> GetByPopulation()
    {
      List<Country> allItems = new List<Country> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM country order by population desc;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        string itemId = rdr.GetString(0);
        Country newItem = new Country(itemId);
        newItem._name = rdr.GetString(1);
        if(rdr.GetValue(13).GetType() == 1.GetType())
        {
          newItem._capital = rdr.GetInt32(13);
        }

         if(rdr.GetValue(7).GetType() == (newItem._lifeExpectancy).GetType())
         {
          //Console.WriteLine(rdr.GetValue(7));
         newItem._lifeExpectancy = rdr.GetFloat(7);
        }
        newItem._region = rdr.GetString(3);




        allItems.Add(newItem);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allItems;
    }

    // public static List<Country> GetCountry(int input)
    // {
    //   List<Country> allItems = new List<Country> {};
    //   MySqlConnection conn = DB.Connection();
    //   conn.Open();
    //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
    //   cmd.CommandText = @"SELECT * FROM country where id = " + input;
    //   MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
    //   while(rdr.Read())
    //   {
    //     int itemId = rdr.GetInt32(0);
    //     string itemDescription = rdr.GetString(1);
    //     Country newItem = new Country(itemId);
    //     allItems.Add(newItem);
    //   }
    //   conn.Close();
    //   if (conn != null)
    //   {
    //     conn.Dispose();
    //   }
    //   return allItems;
    // }



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
