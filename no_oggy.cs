using System;
using System.Collections.Generic;

class NoOggyChecker
{
  static void RemoveOggy(List<string> names)
  {
    //-----------------Crashing Code--------------------//
    /*
    foreach (var name in names)
    {
        if(name.StartsWith("oggy")) {
            Console.WriteLine($"Need to remove {name}!");
            names.Remove(name); //Crashing line - iterator cannot be used to manipulate list
        }
    }
    */
    //-------------------------------------------------//
    
    //----------------Working Code------------------------//
    for(int i= 0; i < names.Count ; i++)                     //iterator is only used as index to list
    {
        if (names[i].StartsWith("oggy"))
        {
            Console.WriteLine($"Need to remove {names[i]}!");
            names.Remove(names[i]);
            i--;                                            //to avoid miscalculations, removed item needs to be reduced in index
        }
    }
    //-------------------------------------------------//
  }
  static bool OggyIsRemoved(List<string> names)
  {
    return names.Find(x => x.Contains("oggy")) == null;
  }
  static int Main()
  {
    var names = new List<string>
      { "nobita", "bheem", "oggy", "oggy cockroach", "ninja" };
    RemoveOggy(names);
    if(OggyIsRemoved(names)) {
      Console.WriteLine("Passed!");
      return 0;
    } else {
      Console.WriteLine("Failed!!");
      return 1;
    }
  }
}
