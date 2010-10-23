using System;

namespace SimpleDetyping
{
  internal static class Program
  {
    private static void Display(string value)
    {
      Console.WriteLine("value = {0} : {1}", value, value.GetType().FullName);
    }

    private static void Main(string[] args)
    {
      Display("BEGIN");
      for (int i = 0; i < 5; ++i)
      {
        Display(i);
      }
      Display("END");
    }
  }
}

