using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Qubit : MonoBehaviour {

	// Use this for initialization
	public float min;
	public float max;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//int x = Random.Range (min, max);
		//this.gameObject.transform.localScale.Set(Random.Range (min, max),Random.Range (min, max),1.0f);
		this.gameObject.transform.localScale = new Vector3(Random.Range (min, max),Random.Range (min, max),1.0f);
		//this.gameObject.transform.localScale.y = Random.Range (min, max);
	}
}
