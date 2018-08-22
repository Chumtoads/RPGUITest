using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfo : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad (this.gameObject);
	}

	public static string PlayerName { get; set;}
	public static string PlayerGender { get; set;}
	public static string ClassName { get; set;}
	public static string CurrentCA { get; set;}
	public static BaseClass PlayerClass { get; set;}
	public static BaseClass PlayerSubClass { get; set;}

	public static int Strength { get; set;}
	public static int Intelligence { get; set;}
	public static int Vitality { get; set;}
	public static int ClassAttribute { get; set;}

}
