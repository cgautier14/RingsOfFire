using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {


	Rigidbody2D rb;

	void Awake(){
	
		rb = GetComponent<Rigidbody2D> ();
	}
		

	void Start(){

		SetCountText ();
	}

	// Update is called once per frame
	void Update () {
	
		rb.velocity = new Vector2 (0,5);
	}

	void OnTriggerEnter2D(Collider2D col){
	
		if (col.gameObject.tag == "Enemy") {
		
			col.gameObject.GetComponent<Enemy>().Die();
			Destroy(gameObject);

		}
			
	}


}
