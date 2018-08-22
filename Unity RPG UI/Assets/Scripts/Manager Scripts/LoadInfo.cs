using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInfo  {
	
	public static void LoadAllInfo(){
		GameInfo.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
		GameInfo.PlayerGender = PlayerPrefs.GetString ("PLAYERGENDER");
		GameInfo.ClassName = PlayerPrefs.GetString ("PLAYERCLASS");
		GameInfo.CurrentCA = PlayerPrefs.GetString ("CURRENTCLASSATB");

		GameInfo.Strength = PlayerPrefs.GetInt ("STRENGTH");
		GameInfo.Intelligence = PlayerPrefs.GetInt ("INTELLIGENCE");
		GameInfo.Vitality = PlayerPrefs.GetInt ("VITALITY");
		GameInfo.ClassAttribute = PlayerPrefs.GetInt ("CLASSATTRIBUTE");

		Debug.Log ("Player Name: " + GameInfo.PlayerName);
		Debug.Log ("Player Gender is: " + GameInfo.PlayerGender);
		Debug.Log ("Player Class: " + GameInfo.ClassName);
		Debug.Log ("Current Class Attribute is: " + GameInfo.CurrentCA + ", With: " + GameInfo.ClassAttribute + " points.");
		Debug.Log ("Strength: " + GameInfo.Strength);
		Debug.Log ("Intelligence " + GameInfo.Intelligence);
		Debug.Log ("Vitality: " + GameInfo.Vitality);
	}
}
