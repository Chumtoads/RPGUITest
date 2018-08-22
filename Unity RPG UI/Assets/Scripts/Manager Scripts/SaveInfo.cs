using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInfo {
	
	public static void SaveAllInfo(){
		PlayerPrefs.SetString ("PLAYERNAME", GameInfo.PlayerName);
		PlayerPrefs.SetString ("PLAYERGENDER", GameInfo.PlayerGender);
		PlayerPrefs.SetString ("PLAYERCLASS", GameInfo.ClassName);
		PlayerPrefs.SetString ("CURRENTCLASSATB", GameInfo.CurrentCA);

		PlayerPrefs.SetInt ("STRENGTH", GameInfo.Strength);
		PlayerPrefs.SetInt ("INTELLIGENCE", GameInfo.Intelligence);
		PlayerPrefs.SetInt ("VITALITY", GameInfo.Vitality);
		PlayerPrefs.SetInt ("CLASSATTRIBUTE", GameInfo.ClassAttribute);
	}

	//Check only stats
	public static void SaveStatInfo(){
		PlayerPrefs.SetInt ("STRENGTH", GameInfo.Strength);
		PlayerPrefs.SetInt ("INTELLIGENCE", GameInfo.Intelligence);
		PlayerPrefs.SetInt ("VITALITY", GameInfo.Vitality);
		PlayerPrefs.SetInt ("CLASSATTRIBUTE", GameInfo.ClassAttribute);
	}
}
