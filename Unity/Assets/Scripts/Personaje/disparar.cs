using UnityEngine;
using System.Collections;

public class disparar : MonoBehaviour {
	
	public GameObject bala;
	public Transform puntoDisparo;
	bool pulsando_boton_dispara= false;
	bool solo_un_disparo = true;
	public float velocidad = 200f;
	Rigidbody2D rb;
	private GameObject nuevabala;

	 void Update(){

		if(Input.GetKeyDown(KeyCode.Q) || (pulsando_boton_dispara && solo_un_disparo) ) { 
			disparo ();
			solo_un_disparo = false;
		}
	}
			

	public void disparo(){
		nuevabala = (GameObject)Instantiate(bala,puntoDisparo.position, puntoDisparo.rotation);
		rb = nuevabala.GetComponent<Rigidbody2D>();
		nuevabala.transform.localScale = transform.localScale;
		rb.AddForce ( transform.right * velocidad );

	}

	public void  pulsa_dispara(){
		Debug.Log ("dispara");
		pulsando_boton_dispara = true;
	}

	public void suelta_dispara(){
		Debug.Log ("suelta");
		pulsando_boton_dispara = false;
		solo_un_disparo = true;
	}


}
