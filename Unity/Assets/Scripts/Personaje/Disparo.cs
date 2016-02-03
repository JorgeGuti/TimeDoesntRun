using UnityEngine;
using System.Collections;

public class Disparo : MonoBehaviour {

	public float velocidaddisparo= 1f;
	Rigidbody2D rg;

	// Use this for initialization
	void Start () {
		rg = GetComponent<Rigidbody2D>();

	
	}
	
	// Update is called once per frame
	void Update () {
		rg.velocity = new Vector2(0f,velocidaddisparo);
	
	}
}
