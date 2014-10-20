UnityCustomDLL
==============

A collection of scripts and instructions to make a build-once Unity3D project.
<br />
Quick Notes
===========
* You MUST use .net 2.0 ONLY in your custom code.

Instructions
============
1. Create a new project in Unity.
2. Put in the source files from "Unity"
3. Build the project for your OS
4. Create a new C# project in Visual Studio ( Or your favorite IDE )
5. Add the following DLL's as references:
* "${WHEREYOUBUILTYOURGAME}/${GAMENAME}_Data/Managed/Assembly-CSharp.dll"
* "${WHEREYOUBUILTYOURGAME}/${GAMENAME}_Data/Managed/UnityEngine.dll"
6. Create a new .cs file
7. Drop in the code from "Custom/EntryPoint.cs" into the .cs file you created.
8. Build it as a dll and drop the dll into the same directory as your built binary.
9. Rename the dll to "GameMode.dll" ( If it doesn't let you modify the extension, just "GameMode" ).
10. Double-click the built binary and cross your fingers.  If it worked you should see a blue screen and a GUI called "BAWX".
