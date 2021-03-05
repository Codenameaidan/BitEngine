using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	public float speed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			this.transform.Translate (Vector2.left * speed * Camera.main.orthographicSize);
		}
		if (Input.GetKey (KeyCode.W)) {
			this.transform.Translate (Vector2.up* speed * Camera.main.orthographicSize);
		}
		if (Input.GetKey (KeyCode.S)) {
			this.transform.Translate (Vector2.down * speed * Camera.main.orthographicSize);
		}
		if (Input.GetKey (KeyCode.D)) {
			this.transform.Translate (Vector2.right * speed * Camera.main.orthographicSize);
		}


		if (Input.GetAxis("Mouse ScrollWheel") > 0 && Camera.main.orthographicSize > 6)
		{
			Camera.main.orthographicSize/=2;
			Debug.Log (Camera.main.orthographicSize);
		}

		if (Input.GetAxis("Mouse ScrollWheel") < 0)
		{
			Camera.main.orthographicSize*=2;
			//Debug.Log (Camera.main.orthographicSize);
		}


	}
}

