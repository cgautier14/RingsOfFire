using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	Rigidbody2D rb; 

	public float xspeed;
	public float yspeed;


	// Use this for initialization
	void Awake () {
	
		rb = GetComponent<Rigidbody2D> ();
	}

	void Start(){

	}
	
	// Update is called once per frame
	void Update () {

		rb.velocity = new Vector2 (xspeed, yspeed*-1);

	}

	void OnCollision(Collision2D col){

		if (col.gameObject.tag == "Player") {
			col.gameObject.GetComponent<Enemy>().Die();
		}

	}

	public void Die(){

		Destroy(gameObject);

	}
		


}
