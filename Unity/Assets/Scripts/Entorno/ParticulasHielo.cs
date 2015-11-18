using UnityEngine;
using System.Collections;

public class ParticulasHielo : MonoBehaviour {
	
	public GameObject particulashielo; 
	void OnCollisionEnter2D (Collision2D objeto){
		if (objeto.transform.tag == "Base") {
			Instantiate (particulashielo, transform.position, transform.rotation); 
		}
		if(objeto.transform.tag == "Base"){
			Destroy(gameObject);
		}
		}
	}
