using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ps : MonoBehaviour {
    public GameObject particle;
	void Start () {
		
	}
	
	void Update () {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Vector3 touchPoint_screen = new Vector3(touch.position.x, touch.position.y, 30);
                Vector3 touchPoint_world = Camera.main.ScreenToWorldPoint(touchPoint_screen);
                particle.transform.position = touchPoint_world;
                particle.GetComponent<ParticleSystem>().Play();
            }

            else if (touch.phase == TouchPhase.Ended)
            {
                //particle.GetComponent<ParticleSystem>().Stop();
            }
        }
    }
}
