using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tembakan : MonoBehaviour {
	public static bool bisanembak = false;
	public GameObject senjata;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Return) && bisanembak == true) {
			Instantiate (senjata,transform.position,transform.rotation);
		}
	}

}
