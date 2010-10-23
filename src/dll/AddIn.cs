using System;
using System.Collections.Generic;
using Mono.CompilerServices.Extensibility;

namespace Mono.DuctileSharp
{
    public sealed class AddIn : IAddIn
    {
        private bool _detype = false;

        #region IAddIn Members

        string IAddIn.Name {get {return "DuctileSharp";}}

        string IAddIn.Description {get {return "Detype your C# code!";}}

        bool IAddIn.ParseCommandLineOption(string arg)
        {
            if ("/detype".Equals(arg, StringComparison.InvariantCultureIgnoreCase))
            {
                _detype = true;
                return true;
            }
            return false;
        }

        void IAddIn.ApplyTypeTransform(ITypeExpressionFactory typeExprFactory, IEnumerable<ITypeInfo> types)
        {
        }

        #endregion IAddIn Members

        public AddIn()
        {
            Console.WriteLine("AddIn..ctor");
        }

        public void DoSomething()
        {
            Console.WriteLine("AddIn.DoSomething: detype = {0}", _detype.ToString().ToLowerInvariant());
        }
    }
}

