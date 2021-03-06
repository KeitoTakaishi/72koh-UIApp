﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using uOSC;

[RequireComponent(typeof(uOscClient))]
public class OscManager : MonoBehaviour {
    uOscClient client;
    GameObject[] buttons = new GameObject[72];

	void Start () {
        buttons = GameObject.FindGameObjectsWithTag("Button");
        client = this.GetComponent<uOscClient>();
        client.Send("/1/push0", 0.0);
    }
	
	void Update () {
        client.Send("/1/push0", 0.0);
        foreach (var _ in buttons){
            if (_.GetComponent<UserInterface>().ID == 1)
            {
                Debug.Log(_.name);
                client.Send("/1/push"+ _.name.Replace("Button", ""), 10.0);
            }
        }
    }
}
