// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

[DllImport("NativeLib.dll")]
static extern void HelloWorld();

HelloWorld();
Console.ReadLine();


