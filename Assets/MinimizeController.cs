using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinimizeController : MonoBehaviour {

	// Use this for initialization
	public GameObject main;
	public GameObject mini;
	void Start () {
		mini.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Minimize(){
		//main.gameObject.GetComponent<<Canvas>().
		//main.gameObject.
		main.SetActive (false);
		mini.SetActive (true);
	}
	public void Maximize(){
		main.SetActive (true);
		mini.SetActive (false);
	}
}
