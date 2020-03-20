using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	public Transform player;
	public Vector3 posisiNormal;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player != null) {
			transform.position = Vector3.Lerp (transform.position, player.position + posisiNormal, 1f);
		}
	}



}
