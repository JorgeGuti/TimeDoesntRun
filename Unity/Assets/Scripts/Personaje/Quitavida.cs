using UnityEngine;
using System.Collections;

public class Quitavida : MonoBehaviour {

	public int puntos = 5;
	Vida gc;

	void Start () {
		gc = GameObject.Find("GameControl").GetComponent<Vida>();
	}

	void OnCollisionEnter2D(Collision2D objeto){
		if(objeto.transform.tag == "Player"){
			Debug.Log("Choca Player");
			gc.resta_vida(puntos);
		}
	}

	void OnTriggerEnter2D(Collider2D objeto){
		if(objeto.tag == "Player"){
			//Debug.Log("Entra Player");
			gc.resta_vida(puntos);
		}
	}
}
