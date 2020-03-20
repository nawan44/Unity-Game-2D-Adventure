using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandGerak : MonoBehaviour {
	public float speed = 5f;
	Rigidbody2D land;


	BoxCollider2D box;
	// Use this for initialization
	void Start () {
		land = GetComponent<Rigidbody2D>();
		box = GetComponent<BoxCollider2D> ();
	}

	// Update is called once per frame
	void Update () {
		land.velocity = new Vector2 (speed, land.velocity.y);
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Batas") {
			transform.Rotate (0, 180, 0);
			speed *= -1;
		} 

	}

}
