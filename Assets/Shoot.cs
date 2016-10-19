using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	GameObject a;

	Rigidbody2D rb;
	public float speed;
	public GameObject bullet;

	void Awake(){
	
	
		rb = GetComponent<Rigidbody2D> ();
		a = transform.Find ("a").gameObject;
	}

	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
	
		rb.AddForce (new Vector2 (Input.GetAxis ("Horizontal") * speed, 0));
		rb.AddForce (new Vector2 (0, Input.GetAxis ("Vertical") * speed));

		if (Input.GetKeyDown (KeyCode.Space)) {
		
			Shooting();
		}
	}
		
		

	void Shooting(){

		Instantiate (bullet, a.transform.position, Quaternion.identity);
	}
}
