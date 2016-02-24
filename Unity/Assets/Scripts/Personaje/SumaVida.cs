using UnityEngine;
using System.Collections;

public class SumaVida : MonoBehaviour {
	
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
			gc.suma_vida(puntos);
			Destroy(gameObject);


		}
	}

	
	
	
}

