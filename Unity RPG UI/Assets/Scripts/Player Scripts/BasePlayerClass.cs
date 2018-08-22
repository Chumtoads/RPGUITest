using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayerClass {

	private string playerName;
	private string playerGender;

	private string className;
	private string currentCA;

	private BaseClass playerClass;
	private BaseClass playerSubClass;

	private int strength;
	private int intelligence;
	private int vitality;
	private int classAttribute;

	//Constructors

	public string PlayerName{
		get{ return playerName;}
		set{ playerName = value;}
	}

	public string PlayerGender{
		get{ return playerGender;}
		set{ playerGender = value;}
	}

	public string ClassName{
		get{ return className;}
		set{ className = value;}
	}

	public string CurrentCA{
		get{ return currentCA;}
		set{ currentCA = value;}
	}

	public BaseClass PlayerClass{
		get { return playerClass;}
		set { playerClass = value;}
	}

	public BaseClass PlayerSubClass{
		get { return playerSubClass;}
		set { playerSubClass = value;}
	}

	public int Strength{
		get{ return strength;}
		set{ strength = value;}
	}

	public int Intelligence{
		get { return intelligence;}
		set { intelligence = value;}
	}

	public int Vitality{
		get { return vitality;}
		set { vitality = value;}
	}

	public int ClassAttribute{
		get { return classAttribute;}
		set { classAttribute = value;}
	}
}
