using System;
using System.Globalization;
using System.Reflection;
using System.Threading;
using T3DNetFramework.Interop;

namespace BaseGame
{
   class Program
   {
      static void Main(string[] args)
      {
         CultureInfo customCulture =
            (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
         customCulture.NumberFormat.NumberDecimalSeparator = ".";

         Thread.CurrentThread.CurrentCulture = customCulture;

         Initializer.InitializeTypeDictionaries(Assembly.GetExecutingAssembly().GetTypes());

         Torque3D.Libraries libraries = new Torque3D.Libraries
         {
            Windows32bit = "BaseGame_DEBUG.dll",
            Windows64bit = "BaseGame_DEBUG.dll"
         };

         Torque3D.Initialize(args, libraries);
      }
   }
}
