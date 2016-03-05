using UnityEngine;
using System.Collections;

public class CargarNInicio : MonoBehaviour {
	
	void OnCollisionEnter2D (Collision2D objeto){
		if(objeto.transform.tag == "Player"){
			Application.LoadLevel ("inicio");
		}
		
	}
}
