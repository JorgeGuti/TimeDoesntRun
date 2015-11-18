using UnityEngine;
using System.Collections;

public class Pesa : MonoBehaviour {

	private Rigidbody2D rb;

	void Start (){
		rb=GetComponent<Rigidbody2D>();

	}
	void Update (){
	}
	void OnTriggerEnter2D (Collider2D objeto) { 
		if (objeto.transform.tag == "Player") {
						rb.isKinematic = false;
	
			 
		}
	}

}