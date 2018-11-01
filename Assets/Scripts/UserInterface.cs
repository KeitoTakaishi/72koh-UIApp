using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace uOSC
{

	[RequireComponent(typeof(uOscClient))]
	public class UserInterface : MonoBehaviour
	{
		private int id = 0;

		void Start()
		{

		}

		void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				//var client = GetComponent < uOscClient >();
				//client.Send("/uOSC/test", Input.mousePosition.x);
			}
			var client = GetComponent < uOscClient >();
			//client.Send("/uOSC/test",0);
		}


		public void OnClick()
		{
			//Debug.Log("Button click!");
			var client = GetComponent < uOscClient >();
			client.Send("/uOSC/test", this.gameObject.name);
		}
	}

}