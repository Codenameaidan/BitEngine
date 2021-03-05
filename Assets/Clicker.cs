using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Clicker : MonoBehaviour {

	// Use this for initialization
	public GameObject spawnOnClick;
	public GameObject spawnOnRightClick;
	public float speed = 300.0f;
	void Start () {
		//eventSys = GameObject.Find("EventSystem").GetComponent<EventSystem>();
	}
	
	// Update is called once per frame
	void Update () {
		if (EventSystem.current != null && !EventSystem.current.IsPointerOverGameObject()) {
			if (Input.GetMouseButton (0)) {
				Vector3 pz = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				pz.z = 0;
				GameObject spawned = Instantiate (spawnOnClick, pz, new Quaternion (0, 0, 0, 0));
				try {
					spawned.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (Random.Range (-1.0f, 1.0f), Random.Range (-1.0f, 1.0f)) * speed);
				} catch {

				}
				//gameObject.transform.position = pz;
			}
			if (Input.GetMouseButtonDown (1)) {
				Vector3 pz = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				pz.z = 0;
				GameObject spawned = Instantiate (spawnOnRightClick, pz, new Quaternion (0, 0, 0, 0));
			}
		}
	}
}
