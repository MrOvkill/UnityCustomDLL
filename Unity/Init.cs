using UnityEngine;
using System.Collections;
using System.Reflection;
using System;
using EpicKnife.Games;
using System.IO;

public class Init : MonoBehaviour
{
    private GameMode game;

	void Start ()
    {
		Assembly library = null;
		if(!File.Exists(Directory.GetCurrentDirectory() + "\\GameMode.dll"))
		{
			Debug.Log("No such file: " + Directory.GetCurrentDirectory() + "\\GameMode.dll");
		}
		try
		{
			library = Assembly.LoadFrom(Directory.GetCurrentDirectory() + "\\GameMode.dll");
		}
		catch(FileNotFoundException e)
		{
			Debug.Log("Could not find file: " + Directory.GetCurrentDirectory() + "\\GameMode.dll");
		}
		catch(FileLoadException e)
		{
			Debug.Log("Could not load file: " + Directory.GetCurrentDirectory() + "\\GameMode.dll");
		}
        Type loaded = library.GetType("GameMode.EntryPoint");
        game = (GameMode)Activator.CreateInstance(loaded);
        game.OnStart();
	}
	
    void Update ()
    {
        game.OnUpdate();
	}

	void OnGUI()
	{
		game.OnGUI();
	}
}
