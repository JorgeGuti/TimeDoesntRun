﻿using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {
	public float fuerza = 200f;
	public float velocidad_edgar = 8f;
	bool pulsado_boton_dch = false;
	bool pulsado_boton_izq = false;
	bool derecha = false;
	Rigidbody2D rg; //Esto es para usar el rigidbody del objeto
	Vector3 mira_izquierda = new Vector3(1,1,1);
	Vector3 mira_derecha = new Vector3 (-1,1,1);
	public ControlSuelo CS;
	public Animator an;
	bool otro_salto = true;


	void Start () {
		rg = GetComponent<Rigidbody2D> ();// Cargamos el rigidbody dentro de
	}
	
	// Update is called once per frame
	void Update () {
		//si pulsamos espacio saltamos
		Vector2 velocidad = GetComponent<Rigidbody2D>().velocity; 
		Debug.DrawLine(transform.position, new Vector3(transform.position.x + velocidad.x, transform.position.y + velocidad.y, transform.position.z));
	

		if(Input.GetKeyDown(KeyCode.Space)&& otro_salto == true){
			salto();
			an.SetBool("Saltando", true);
			Invoke("TerminaSalto",0.3f);
		}

		if (Input.GetKey (KeyCode.A) || pulsado_boton_izq) {
			mueve_izquierda ();
		}

		if(Input.GetKey(KeyCode.D)|| pulsado_boton_dch) {
			mueve_derecha();
		}

		if (Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp(KeyCode.D)) {
			an.SetFloat("Velocidad", 0.0f);
		}

		if (CS.Saber_Suelo () == true) {
			an.SetBool("Saltando", false);
			Debug.Log ("tocosuelo");
			if(otro_salto == false){
				Debug.Log ("ahora");
				otro_salto = true;
			}
		}
	}


	/*Funcion salto
	 * Aplica una fuerza al objeto con fuerza: fuerza
	 */

	public void salto(){
		rg.velocity = new Vector2 (rg.velocity.x, fuerza);
		otro_salto = false;
	}

	void mueve_derecha(){
		transform.localScale = mira_derecha;
		derecha = true;
		rg.velocity = new Vector2 (velocidad_edgar,rg.velocity.y);
		an.SetFloat ("Velocidad", velocidad_edgar);
	}

	void mueve_izquierda(){
		transform.localScale = mira_izquierda;
		derecha = false;
		rg.velocity = new Vector2 (-velocidad_edgar, rg.velocity.y);
		an.SetFloat ("Velocidad", velocidad_edgar);
	}

	public void pulsa_boton_dch(){
		pulsado_boton_dch = true;
	}

	public void suelta_boton_dch(){
		pulsado_boton_dch = false;
		an.SetFloat("Velocidad", 0.0f);
	}

	public void pulsa_boton_izq(){
		pulsado_boton_izq = true;
	}

	public void suelta_boton_izq(){
		pulsado_boton_izq = false;
		an.SetFloat("Velocidad", 0.0f);
	}

	public void pulsa_boton_salto(){
		if(otro_salto == true){
			salto();
			an.SetBool("Saltando", true);
			Invoke("TerminaSalto",0.3f);
		}
	}

	public bool direccion(){
		return derecha;
	}

	void TerminaSalto(){
		an.SetBool("Saltando", false);
	}
}