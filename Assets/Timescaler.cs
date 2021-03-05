using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timescaler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//input.onEndEdit.AddListener(UpdateTimeScale);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void UpdateTimeScales(){
		//Time.timeScale = s;
		//Debug.Log(s);
		//float x = float.Parse (this.gameObject.GetComponent<Text>()>);
		float x = float.Parse (this.gameObject.GetComponent<InputField>().text);
		Time.timeScale = x;
		Debug.Log (Time.timeScale);
	}
}
