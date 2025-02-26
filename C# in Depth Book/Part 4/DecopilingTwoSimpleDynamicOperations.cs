using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Runtime.CompilerServices;

namespace Part4
{
    class DynamicTypingDecompiled
    {
        private static class CallSites
        {
            public static CallSite<Func<CallSite, object, int, object>>
               method;
            public static CallSite<Func<CallSite, object, string>>
               conversion;
        }

        public static void Main()
        {
            object text = "hello world";
            if (CallSites.method == null)
            {
                CSharpArgumentInfo[] argumentInfo = new[]
                {
                     CSharpArgumentInfo.Create(
                      CSharpArgumentInfoFlags.None, null),
                     
                    CSharpArgumentInfo.Create(
                      CSharpArgumentInfoFlags.Constant |
                        CSharpArgumentInfoFlags.UseCompileTimeType,
                      null)
                };
            CallSiteBinder binder =
            Binder.InvokeMember(CSharpBinderFlags.None, "Substring",
            null, typeof(DynamicTypingDecompiled), argumentInfo);
                CallSites.method =
            CallSite<Func<CallSite, object, int, object>>.Create(binder);
            }
            if (CallSites.conversion == null)
            {
                CallSiteBinder binder =
                Binder.Convert(CSharpBinderFlags.None, typeof(string),
                typeof(DynamicTypingDecompiled));
                    CallSites.conversion =
               CallSite<Func<CallSite, object, string>>.Create(binder);
            }

            object result = CallSites.method.Target(
                CallSites.method, text, 6); 
        }
    }
}