using UnityEngine;
using System.Collections;

public class disparar : MonoBehaviour {
	
	public GameObject bala;
	bool pulsando_boton_dispara= false;
	bool solo_un_disparo = true;


	 void Update(){

		if(Input.GetKeyDown(KeyCode.Q) || (pulsando_boton_dispara && solo_un_disparo) ) { 
			disparo ();
			solo_un_disparo = false;
		}
	}
			

		public void disparo(){
		Instantiate(bala,transform.position, transform.rotation);

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
