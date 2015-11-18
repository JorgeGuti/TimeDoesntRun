using UnityEngine;
using System.Collections;

public class CargarNivel4 : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D objeto){
		if(objeto.transform.tag == "Player"){
			Application.LoadLevel ("Nivel 04");
		}
	}
}