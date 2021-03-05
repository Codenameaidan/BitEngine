using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAndReplaceOnContact : MonoBehaviour {

	// Use this for initialization
	public GameObject[] spawn;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "bit") {
			for (int x = 0; x < spawn.Length; x++) {
				Instantiate (spawn [x],new Vector3(this.transform.position.x, this.transform.position.y, 1.0f),new Quaternion (0, 0, 0, 0));
			}
			Destroy (this.gameObject);
		}
	}
}
