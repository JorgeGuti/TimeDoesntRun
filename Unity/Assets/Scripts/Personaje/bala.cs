using UnityEngine;
using System.Collections;

public class bala : MonoBehaviour {
	public float velocidad = 200f;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.AddForce (transform.right * 100f * velocidad * -1);
		Destroy (gameObject, 3f);
	}

}
