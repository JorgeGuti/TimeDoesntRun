using UnityEngine;
using System.Collections;

public class CargarNivel2 : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D objeto){
		if(objeto.transform.tag == "Player"){
			Application.LoadLevel ("Nivel02");
		}

	}
}
