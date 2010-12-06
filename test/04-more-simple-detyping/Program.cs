using System;

namespace MoreSimpleDetyping
{
  internal static class Program
  {
    private sealed class Foo
    {
      internal Foo()
      {
      }
    }

    private static void Display(string value, int x, int y, Foo foo, dynamic bar)
    {
      Console.WriteLine("value = {0} : {1}", value, value.GetType().FullName);
    }

    private static void Main(string[] args)
    {
      Display("BEGIN", 0, 0, null, null);
      for (int i = 0; i < 5; ++i)
      {
        Display(i, 0, 0, null, null);
      }
      Display("END", 0, 0, null, null);
    }
  }
}

