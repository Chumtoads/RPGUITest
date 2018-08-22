using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClass {

	private int strength;
	private int intelligence;
	private int vitality;
	private int classAttribute;

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
