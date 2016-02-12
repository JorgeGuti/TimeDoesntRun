using UnityEngine;
using System.Collections;

public class Quitavida : MonoBehaviour {

	public int puntos = 5;
	Vida gc;
	// Use this for initialization
	void Start () {
		gc = GameObject.Find("GameControl").GetComponent<Vida>();
	}
		// Update is called once per frame

	
	void OnTriggerEnter2D(Collider2D objeto){
		if(objeto.tag == "Player"){
			//Debug.Log("Entra Player");
			gc.resta_vida(puntos);
		}
	}
	

	
}
