using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInterface : MonoBehaviour
{
    private int _id = 0;
    public int ID{
        get { return _id;}
        set { _id = value; } 
    }

	void Start()
	{

	}

	void Update()
	{
        if (Time.frameCount % 3 == 0)
        {
            ID = 0;
        }
	}


	public void OnClick()
	{
        ID = 1;
	}
}

