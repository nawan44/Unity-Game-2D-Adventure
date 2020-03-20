using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peluru : MonoBehaviour {
	Rigidbody2D senjata;
	public float speed;
	// Use this for initialization
	void Start () {
		senjata = GetComponent<Rigidbody2D> ();
		transform.rotation = Quaternion.Euler (0, 0, -90);

		senjata.velocity = new Vector2 (speed, senjata.velocity.y);
		Destroy (gameObject, 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
