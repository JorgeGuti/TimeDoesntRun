using UnityEngine;
using System.Collections;

public class disparar : MonoBehaviour {
	
	public GameObject[] bala;
	public Transform puntoDisparo;
	bool pulsando_boton_dispara= false;
	bool solo_un_disparo = true;
	public float velocidad = 200f;
	Rigidbody2D rb;
	private GameObject nuevabala;
	private int contador = 0;
	public Animator an;
	public int Tiempo_Espera = 5;
	bool permitido = true;

	 void Update(){

		if((Input.GetKeyDown(KeyCode.Q) || (pulsando_boton_dispara && solo_un_disparo)) && permitido ) { 
			disparo ();
			solo_un_disparo = false;
		}
	}
			

	public void disparo(){
		nuevabala = (GameObject)Instantiate(bala[contador],puntoDisparo.position, puntoDisparo.rotation);
		contador += 1;
		an.SetInteger ("Estado", contador);
		if (contador > 3) {
			permitido = false;
			StartCoroutine ("TiempoEspera");
		}
		rb = nuevabala.GetComponent<Rigidbody2D>();

		rb.AddForce ( transform.right * velocidad *transform.localScale.x * -1 );

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

	IEnumerator TiempoEspera (){
		yield return new WaitForSeconds (Tiempo_Espera);
		contador = 0;
		an.SetInteger ("Estado", contador);
		permitido = true;
	}

}
