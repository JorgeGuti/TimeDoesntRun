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
		}


}
}