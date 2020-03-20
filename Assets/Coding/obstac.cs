using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsta : MonoBehaviour {
	public float speed = 5f;

	bool IsDead = false;
	Animator anim;
	BoxCollider2D box;
	// Use this for initialization
	void Start () {
		

		box = GetComponent<BoxCollider2D> ();
	}

	// Update is called once per frame

		
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Batas") {
			transform.Rotate (0, 180, 0);
			speed *= -1;
		}


	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player") {
			IsDead = true;
			anim.SetBool("mati", IsDead);
			box.enabled = false;

			Destroy (gameObject, 4f);
		}
	}
}
