using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCreater : MonoBehaviour
{
	private int num = 72;
	GameObject[] buttons = new GameObject[72]; 
	void Start () {
		for (int i = 0; i < num; i++)
		{
			buttons[i] = Resources.Load("Button") as GameObject;
			buttons[i].name = "i + 1";
			
		}
	}
	
	void Update () {
		
	}
}
