using UnityEngine;
using System.Collections;

public class bala : MonoBehaviour {
	public GameObject balas;

	// Use this for initialization
	void Start () {

		Destroy (gameObject, 3f);
	}

	void OnCollisionEnter2D (Collision2D objeto){
		if(objeto.transform.tag == "enemigo"){
			Destroy(gameObject);
			Destroy (objeto.gameObject);
		}

		if((objeto.transform.tag == "danio")||(objeto.transform.tag == "Base")||(objeto.transform.tag == "Limite")){
			Destroy(gameObject);
		}
	}
	
	void OnTriggerEnter2D(Collider2D objeto){
		if(objeto.transform.tag == "enemigo"){
			Destroy(gameObject);
			Destroy (objeto.gameObject);
		}
	}
}