using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity:  MonoBehaviour  {
	public float pullRadius = 2;
	public float pullForce = 1;

	public void FixedUpdate() {
		/*foreach (Collider2D collider in Physics2D.OverlapCircle(new Vector2(this.transform.position.x,this.transform.position.y), pullRadius)) 
			{
				// calculate direction from target to me
				Vector3 forceDirection = transform.position - collider.transform.position;

				// apply force on target towards me
				collider.GetComponent<Rigidbody2D>().AddForce(forceDirection.normalized * pullForce * Time.fixedDeltaTime);

		}*/
		Collider2D[] c = Physics2D.OverlapCircleAll (new Vector2 (this.transform.position.x, this.transform.position.y), pullRadius);
		for (int x = 0; x < c.Length; x++) {
			Vector3 forceDirection = transform.position - c[x].transform.position;

			// apply force on target towards me
			try{
			c[x].GetComponent<Rigidbody2D>().AddForce(forceDirection.normalized * pullForce * Time.fixedDeltaTime);
			}catch{
				
			}

		}
		}
	}
