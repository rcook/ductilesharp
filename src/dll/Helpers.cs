using System;
using System.Reflection;

namespace Mono.DuctileSharp
{
  internal static class Helpers
  {
    private static Version _assemblyVersion;

    internal static Version AssemblyVersion
    {
      get
      {
        if (null == _assemblyVersion)
        {
          Assembly assembly = Assembly.GetExecutingAssembly();
          _assemblyVersion = assembly.GetName().Version;
        }
        return _assemblyVersion;
      }
    }
  }
}

