using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountTag : MonoBehaviour {

	// Use this for initialization
	public string tag;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject[] c = GameObject.FindGameObjectsWithTag (tag);
		this.GetComponent<Text> ().text = "# of bits: " + c.Length;
		if (c.Length > 1000) {
			this.GetComponent<Text> ().color = Color.red;
		}
	}
}
