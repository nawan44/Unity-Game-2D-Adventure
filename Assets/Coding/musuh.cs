using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musuh : MonoBehaviour {
	public float speed = 5f;
	Rigidbody2D enemy;

	bool IsDead = false;
	Animator anim;
	BoxCollider2D box;
	// Use this for initialization
	void Start () {
		enemy = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator> ();
		box = GetComponent<BoxCollider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		enemy.velocity = new Vector2 (speed, enemy.velocity.y);
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Batas") {
			transform.Rotate (0, 180, 0);
			speed *= -1;
		} 
		else if (col.gameObject.tag == "Peluru") {
			Destroy (gameObject);
		}

	 
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player" ) {
			IsDead = true;
			anim.SetBool("mati", IsDead);
			box.enabled = false;
			enemy.gravityScale = 1;
			Destroy (gameObject, 4f);
		}


	}
}
