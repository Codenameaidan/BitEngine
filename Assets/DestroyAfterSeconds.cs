using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterSeconds : MonoBehaviour {

	// Use this for initialization
	public float seconds;
	void Start () {
		StartCoroutine (kill());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator kill(){
		yield return new WaitForSeconds (seconds);
		Destroy (this.gameObject);

	}
}
