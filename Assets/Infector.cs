using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "bit" && col.gameObject.GetComponent<Infector>() == null) {
			Destroy (col.gameObject);
			Instantiate (this.gameObject,new Vector3(this.transform.position.x, this.transform.position.y, 1.0f),new Quaternion (0, 0, 0, 0));
			//Destroy (this.gameObject);
		}
	}
}
