using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour {

	private CreatePlayer SD;

	public string nameOfPlayer;
	public string standardName = "Nameless Hero";
	public InputField playerNameField;

	// Use this for initialization
	void Start () {
		SD = GameObject.Find ("CreatePlayer").GetComponent<CreatePlayer> ();
		SetName ();
	}

	public void SetName(){
		if (playerNameField.text == "") {
			SD.thisPlayerName = standardName;
		} else {
			nameOfPlayer = playerNameField.text;
			SD.thisPlayerName = nameOfPlayer;
		}
	}
}
