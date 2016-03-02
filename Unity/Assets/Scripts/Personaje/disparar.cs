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
	public movimiento mov;
	Vector3 mira_izquierda = new Vector3 (-1,1,1);
	Vector3 mira_derecha = new Vector3 (1,1,1);
	public Animator an_personaje;

	 void Update(){

		if((Input.GetKeyDown(KeyCode.Q) || (pulsando_boton_dispara && solo_un_disparo)) && permitido ) {
			an_personaje.SetBool ("Disparar", true);
			Invoke ("vuelta_normal", 0.4f);
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

		if (mov.direccion () == true) {
			rb.transform.localScale = mira_derecha;
			rb.AddForce ( transform.right * velocidad * transform.localScale.x * -1 );
		}

		else{
			rb.transform.localScale = mira_izquierda;
			rb.AddForce ( transform.right * velocidad * transform.localScale.x * -1 );
		}
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

	void vuelta_normal(){
		an_personaje.SetBool ("Disparar", false);
		disparo();
		solo_un_disparo = false;
	}

}
