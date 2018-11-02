﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Layout : MonoBehaviour {
    static GameObject[] _buffer = new GameObject[72];
    static GameObject[,] _buttons = new GameObject[12, 6];
    static Text[,] _text = new Text[12, 6];

	void Start () {
        _buffer = GameObject.FindGameObjectsWithTag("Button");
        foreach(var _ in GameObject.FindGameObjectsWithTag("Button")){
            var id = int.Parse(_.name.Replace("Button", ""));
            _buffer[id-1] = _;
        }
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                _buttons[i, j] = _buffer[i * 6 + j];
                _buttons[i, j].transform.position = new Vector3(_buttons[i, j].transform.position.x, 1900 - i * 160, _buttons[i, j].transform.position.z);
                _buttons[i, j].transform.localScale = new Vector3(1.0f, 2.5f, 1.0f);
                _text[i, j] = _buttons[i, j].transform.GetChild(0).GetComponent<Text>();
                _text[i, j].transform.localScale = new Vector3(1.5f, 0.8f, 1.0f);
                _text[i, j].fontSize = 20;
            }
        }
	}
	
	void Update () {
		
	}
}