using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectPicker : MonoBehaviour {

	// Use this for initialization
	public GameObject [] bits;
	public Clicker clicker;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Change(){
		clicker.spawnOnClick = bits [this.gameObject.GetComponent<Dropdown> ().value];
	}
	public void ChangeRight(){
		clicker.spawnOnRightClick = bits [this.gameObject.GetComponent<Dropdown> ().value];
	}
}
