using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatePlayer : MonoBehaviour {

	private BasePlayerClass newPlayer;
	public string thisPlayerName = "";
	public string thisPlayerGender;
	public string thisClassName;
	public string currentClassAttribute;

	private string genderFemale = "Female";
	private string genderNonbinary = "Nonbinary";
	private string genderMale = "Male";

	public Text strengthText;
	public Text intelligenceText;
	public Text vitalityText;
	public Text classAtbText;

	private bool canAddMorePointsStr;
	private bool canAddMorePointsInt;
	private bool canAddMorePointsVit;
	private bool canAddMorePointsAtb;

	public Text warriorBio;
	public Text mageBio;
	public Text rangerBio;
	public Text whatIsCurrentClassBio;

	public Text classAtbTextUI;
	public Sprite rageImage;
	public Sprite manaImage;
	public Sprite focusImage;
	public Image whatIsCurrentImage;

	private string classAtbRage = "Rage";
	private string classAtbMana = "Mana";
	private string classAtbFocus = "Focus";

	private int pointsToSpend = 20;
	public Text pointsText;

	private bool warrior;
	private bool mage;
	private bool ranger;



	// Use this for initialization
	void Start () {
		newPlayer = new BasePlayerClass ();
		SetWarriorClass ();
	}

	public void CreateNewPlayer(){

		//Name and Gender
		newPlayer.PlayerName = thisPlayerName;
		newPlayer.PlayerGender = thisPlayerGender;
		GameInfo.PlayerName = newPlayer.PlayerName;
		GameInfo.PlayerGender = newPlayer.PlayerGender;

		//Class and spec name
		newPlayer.ClassName = thisClassName;
		GameInfo.ClassName = newPlayer.ClassName;

		//Class stats
		GameInfo.PlayerClass = newPlayer.PlayerClass;
		GameInfo.PlayerSubClass = newPlayer.PlayerSubClass;

		//Current Class Attribute
		newPlayer.CurrentCA = currentClassAttribute;
		GameInfo.CurrentCA = newPlayer.CurrentCA;

		//General stats
		GameInfo.Strength = newPlayer.Strength;
		GameInfo.Intelligence = newPlayer.Intelligence;
		GameInfo.Vitality = newPlayer.Vitality;
		GameInfo.ClassAttribute = newPlayer.ClassAttribute;

		//UpdateUI ();
		SaveInfo.SaveAllInfo ();
	}

	public void SetGenderFemale(){
		thisPlayerGender = genderFemale;
	}

	public void SetGenderNonbinary(){
		thisPlayerGender = genderNonbinary;
	}

	public void SetGenderMale(){
		thisPlayerGender = genderMale;
	}
		
	//Warrior
	public void SetWarriorClass(){
		pointsToSpend = 20;
		newPlayer.PlayerClass = new WarriorClass ();
		newPlayer.Strength = newPlayer.PlayerClass.Strength;
		newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence;
		newPlayer.Vitality = newPlayer.PlayerClass.Vitality;
		newPlayer.ClassAttribute = newPlayer.PlayerClass.ClassAttribute;
		SaveInfo.SaveStatInfo ();

		thisClassName = "Warrior";
		currentClassAttribute = classAtbRage;
		classAtbTextUI.text = classAtbRage;
		whatIsCurrentImage.sprite = rageImage;
		whatIsCurrentClassBio.text = warriorBio.text;

		//Check current class
		warrior = true;
		mage = false;
		ranger = false;
		UpdateUI();
	}

	//Mage
	public void SetMageClass(){
		pointsToSpend = 20;
		newPlayer.PlayerClass = new MageClass ();
		newPlayer.Strength = newPlayer.PlayerClass.Strength;
		newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence;
		newPlayer.Vitality = newPlayer.PlayerClass.Vitality;
		newPlayer.ClassAttribute = newPlayer.PlayerClass.ClassAttribute;
		SaveInfo.SaveStatInfo ();

		thisClassName = "Mage";
		currentClassAttribute = classAtbMana;
		classAtbTextUI.text = classAtbMana;
		whatIsCurrentImage.sprite = manaImage;
		whatIsCurrentClassBio.text = mageBio.text;

		//Check current class
		warrior = false;
		mage = true;
		ranger = false;
		UpdateUI();
	}

	//Ranger
	public void SetRangerClass(){
		pointsToSpend = 20;
		newPlayer.PlayerClass = new RangerClass ();
		newPlayer.Strength = newPlayer.PlayerClass.Strength;
		newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence;
		newPlayer.Vitality = newPlayer.PlayerClass.Vitality;
		newPlayer.ClassAttribute = newPlayer.PlayerClass.ClassAttribute;
		SaveInfo.SaveStatInfo ();

		thisClassName = "Ranger";
		currentClassAttribute = classAtbFocus;
		classAtbTextUI.text = classAtbFocus;
		whatIsCurrentImage.sprite = focusImage;
		whatIsCurrentClassBio.text = rangerBio.text;

		//Check current class
		warrior = false;
		mage = false;
		ranger = true;
		UpdateUI();
	}
		
	//Reset stats on spec change
	public void ResetSpec(){
		newPlayer.Strength = newPlayer.PlayerClass.Strength;
		newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence;
		newPlayer.Vitality = newPlayer.PlayerClass.Vitality;
		newPlayer.ClassAttribute = newPlayer.PlayerClass.ClassAttribute;
	}

	//Barbarian Spec
	public void SetBarbarianSubclass(){
		ResetSpec ();
		if (warrior == true) {
			thisClassName = "Warrior, Barbarian";
			newPlayer.PlayerSubClass = new BarbarianSpec ();
			//Current stats get bonus for choosing spec
			newPlayer.Strength = newPlayer.PlayerClass.Strength + newPlayer.PlayerSubClass.Strength;
			newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence + newPlayer.PlayerSubClass.Intelligence;
			newPlayer.Vitality = newPlayer.PlayerClass.Vitality + newPlayer.PlayerSubClass.Vitality;
			//Debug.Log ("You are a Barbarian");
			UpdateUI ();
		} else {
			Debug.Log ("You can't choose this spec as this class!");
		}
	}

	//Knight Spec
	public void SetKnightSubclass(){
		ResetSpec ();
		if (warrior == true) {
			thisClassName = "Warrior, Knight";
			newPlayer.PlayerSubClass = new KnightSpec ();
			//Current stats get bonus for choosing spec
			newPlayer.Strength = newPlayer.PlayerClass.Strength + newPlayer.PlayerSubClass.Strength;
			newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence + newPlayer.PlayerSubClass.Intelligence;
			newPlayer.Vitality = newPlayer.PlayerClass.Vitality + newPlayer.PlayerSubClass.Vitality;
			//Debug.Log ("You are a Knight");
			UpdateUI ();
		} else {
			Debug.Log ("You can't choose this spec as this class!");
		}
	}

	//Fire Mage Spec
	public void SetFireMageSubclass(){
		ResetSpec ();
		if (mage == true) {
			thisClassName = "Mage, Fire";
			newPlayer.PlayerSubClass = new FireMageSpec ();
			//Current stats get bonus for choosing spec
			newPlayer.Strength = newPlayer.PlayerClass.Strength + newPlayer.PlayerSubClass.Strength;
			newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence + newPlayer.PlayerSubClass.Intelligence;
			newPlayer.Vitality = newPlayer.PlayerClass.Vitality + newPlayer.PlayerSubClass.Vitality;
			//Debug.Log ("You are a Fire Mage");
			UpdateUI ();
		} else {
			Debug.Log ("You can't choose this spec as this class!");
		}
	}

	//Frost Mage Spec
	public void SetFrostMageSubclass(){
		ResetSpec ();
		if (mage == true) {
			thisClassName = "Mage, Frost";
			newPlayer.PlayerSubClass = new FrostMageSpec ();
			//Current stats get bonus for choosing spec
			newPlayer.Strength = newPlayer.PlayerClass.Strength + newPlayer.PlayerSubClass.Strength;
			newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence + newPlayer.PlayerSubClass.Intelligence;
			newPlayer.Vitality = newPlayer.PlayerClass.Vitality + newPlayer.PlayerSubClass.Vitality;
			//Debug.Log ("You are a Frost Mage");
			UpdateUI ();
		} else {
			Debug.Log ("You can't choose this spec as this class!");
		}
	}

	//Hunter Spec
	public void SetHunterSubclass(){
		ResetSpec ();
		if (ranger == true) {
			thisClassName = "Ranger, Hunter";
			newPlayer.PlayerSubClass = new HunterSpec ();
			//Current stats get bonus for choosing spec
			newPlayer.Strength = newPlayer.PlayerClass.Strength + newPlayer.PlayerSubClass.Strength;
			newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence + newPlayer.PlayerSubClass.Intelligence;
			newPlayer.Vitality = newPlayer.PlayerClass.Vitality + newPlayer.PlayerSubClass.Vitality;
			//Debug.Log ("You are a Hunter");
			UpdateUI ();
		} else {
			Debug.Log ("You can't choose this spec as this class!");
		}
	}

	//Druid Spec
	public void SetDruidSubclass(){
		ResetSpec ();
		if (ranger == true) {
			thisClassName = "Ranger, Druid";
			newPlayer.PlayerSubClass = new DruidSpec ();
			//Current stats get bonus for choosing spec
			newPlayer.Strength = newPlayer.PlayerClass.Strength + newPlayer.PlayerSubClass.Strength;
			newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence + newPlayer.PlayerSubClass.Intelligence;
			newPlayer.Vitality = newPlayer.PlayerClass.Vitality + newPlayer.PlayerSubClass.Vitality;
			//Debug.Log ("You are a Druid");
			UpdateUI ();
		} else {
			Debug.Log ("You can't choose this spec as this class!");
		}
	}

	//Strength Button
	public void SetStr(int amount){
		if (newPlayer.PlayerClass != null) {
			if (amount > 0 && pointsToSpend > 0 && canAddMorePointsStr == true) {
				newPlayer.Strength += amount;
				pointsToSpend -= 1;
				UpdateUI ();
			} else if (amount < 0 && newPlayer.Strength > newPlayer.PlayerClass.Strength) {
				newPlayer.Strength += amount;
				pointsToSpend += 1;
				UpdateUI ();
			}

			//Check if cap is reached
			if (newPlayer.Strength == 10) {
				canAddMorePointsStr = false;
			} else {
				canAddMorePointsStr = true;
			}

		} else {
			Debug.Log ("No Class Chosen!");
		}
	}

	//Intelligence Button
	public void SetInt(int amount){
		if (newPlayer.PlayerClass != null) {
			if (amount > 0 && pointsToSpend > 0 && canAddMorePointsInt == true) {
				newPlayer.Intelligence += amount;
				pointsToSpend -= 1;
				UpdateUI ();
			} else if (amount < 0 && newPlayer.Intelligence > newPlayer.PlayerClass.Intelligence) {
				newPlayer.Intelligence += amount;
				pointsToSpend += 1;
				UpdateUI ();
			}

			//Check if cap is reached
			if (newPlayer.Intelligence == 10) {
				canAddMorePointsInt = false;
			} else {
				canAddMorePointsInt = true;
			}

		} else {
			Debug.Log ("No Class Chosen!");
		}
	}

	//Vitality Button
	public void SetVit(int amount){
		if (newPlayer.PlayerClass != null) {
			if (amount > 0 && pointsToSpend > 0 && canAddMorePointsVit == true) {
				newPlayer.Vitality += amount;
				pointsToSpend -= 1;
				UpdateUI ();
			} else if (amount < 0 && newPlayer.Vitality > newPlayer.PlayerClass.Vitality) {
				newPlayer.Vitality += amount;
				pointsToSpend += 1;
				UpdateUI ();
			}

			//Check if cap is reached
			if (newPlayer.Vitality == 10) {
				canAddMorePointsVit = false;
			} else {
				canAddMorePointsVit = true;
			}

		} else {
			Debug.Log ("No Class Chosen!");
		}
	}

	//Class Attribute Button
	public void SetClassAtb(int amount){
		if (newPlayer.PlayerClass != null) {
			if (amount > 0 && pointsToSpend > 0 && canAddMorePointsAtb == true) {
				newPlayer.ClassAttribute += amount;
				pointsToSpend -= 1;
				UpdateUI ();
			} else if (amount < 0 && newPlayer.ClassAttribute > newPlayer.PlayerClass.ClassAttribute) {
				newPlayer.ClassAttribute += amount;
				pointsToSpend += 1;
				UpdateUI ();
			}

			//Check if cap is reached
			if (newPlayer.ClassAttribute == 10) {
				canAddMorePointsAtb = false;
			} else {
				canAddMorePointsAtb = true;
			}

		} else {
			Debug.Log ("No Class Chosen!");
		}
	}

	public void LoadCharacter(){
		LoadInfo.LoadAllInfo ();
	}

	void UpdateUI(){
		strengthText.text = newPlayer.Strength.ToString ();
		intelligenceText.text = newPlayer.Intelligence.ToString ();
		vitalityText.text = newPlayer.Vitality.ToString ();
		classAtbText.text = newPlayer.ClassAttribute.ToString ();

		pointsText.text = pointsToSpend.ToString ();
	}
}
