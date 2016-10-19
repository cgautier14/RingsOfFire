using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	// Use this for initialization

	public float rate;
	public GameObject[] enemies;

	void Start () {
	
		InvokeRepeating("SpawnEnemies", rate, rate);

	}
	
	// Update is called once per frame
	void SpawnEnemies () {

		Instantiate(enemies[(int)Random.Range(0,enemies.Length)],new Vector3(Random.Range(-9f,9f),4,0),Quaternion.identity);
		
	
	}
}
