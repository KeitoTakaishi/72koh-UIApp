using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Layout : MonoBehaviour {
    static GameObject[] _buffer = new GameObject[72];
    static GameObject[,] _buttons = new GameObject[12, 6];
    static Text[,] _text = new Text[12, 6];
    public Font _font;
    public Sprite _sprite;
    public GameObject[] shikiri = new GameObject[3];
    private int shikiriId = 0;
    int index = 0;
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
                _buttons[i, j].transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                _buttons[i, j].GetComponent<RectTransform>().sizeDelta = new Vector3(175, 80);
                _buttons[i, j].GetComponent<Image>().type = Image.Type.Tiled;
                _buttons[i, j].GetComponent<Image>().fillCenter = false;
                _buttons[i, j].GetComponent<Image>().sprite = _sprite;
                //_buttons[i, j].GetComponent<Button>().colors = Color.yellow;
                var colors = _buttons[i, j].GetComponent<Button>().colors;
                colors.pressedColor = new Color(1.0f, 0.75f, 0.15f, 0.8f);
                _buttons[i, j].GetComponent<Button>().colors = colors;


                _text[i, j] = _buttons[i, j].transform.GetChild(0).GetComponent<Text>();
                //_text[i, j].transform.localScale = new Vector3(1.5f, 0.8f, 1.0f);
                _text[i, j].transform.localScale = new Vector3(2.0f, 2.0f, 1.0f);
                _text[i, j].fontSize = 20;
                _text[i, j].font = _font;
            }
            //しきりの配置
            if(i < 11 && (i+1)% 3 == 0){
                Debug.Log("------------------------------------");
                var p = new Vector3(_buttons[i, 2].transform.position.x, 1900 - i * 160 - 80, _buttons[i, 2].transform.position.z);
                shikiri[shikiriId].transform.position = p;
                ++shikiriId;
            }
        }
	}
	
	void Update () {
		
	}
}
