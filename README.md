## Overview

This repository contains a simple example of C++ and C# interoperability using P/Invoke.

The solution includes a native C++ project that builds a DLL and a C# console application that imports and calls a `HelloWorld` function from that native library. The returned value is then printed to the console.

## Notes

- The C++ project must be configured with **Configuration Type = Dynamic Library (.dll)** so that it generates `NativeLib.dll`.
- The generated `NativeLib.dll` must be copied into the C# output folder:
  `bin\x64\Debug\net8.0\`
- All projects in the solution were configured to use **x64**.
- This example was created based on the video [**“Project Setup and Hello World - P/INVOKE WITH C# AND C++”**](https://www.youtube.com/watch?v=NKIdxJAbr0Q), which demonstrates a simple Hello World application using P/Invoke with a C++ DLL and C#. :contentReference[oaicite:0]{index=0}
