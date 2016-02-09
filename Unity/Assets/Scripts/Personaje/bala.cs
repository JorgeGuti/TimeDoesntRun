using UnityEngine;
using System.Collections;

public class bala : MonoBehaviour {
	public float velocidad = 50f;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.AddForce (transform.forward * 100);
		Destroy (transform.gameObject, 3);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
