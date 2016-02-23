using UnityEngine;
using System.Collections;

public class troncopodrido : MonoBehaviour {

	public string nombre = "player";
	private Rigidbody2D rb;

	// Use this for initialization
	void Start (){
		rb=GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D objeto){
		string etiqueta = objeto.transform.tag;
		Debug.Log (etiqueta);
		if (etiqueta == nombre) {
			rb.isKinematic = false;
		}
	}
}
