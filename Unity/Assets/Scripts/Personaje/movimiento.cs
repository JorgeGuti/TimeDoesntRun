﻿using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {
	private Animator anim;
	public float fuerza = 200f;
	public float velocidad_edgar = 8f;
	bool pulsado_boton_dch = false;
	bool pulsado_boton_izq = false;
	Rigidbody2D rg; //Esto es para usar el rigidbody del objeto
	Vector3 mira_izquierda = new Vector3(1,1,1);
	Vector3 mira_derecha = new Vector3 (-1,1,1);
	public ControlSuelo CS;
		// Use this for initialization
	void Start () {
		rg = GetComponent<Rigidbody2D> ();// Cargamos el rigidbody dentro de
	}
	
	// Update is called once per frame
	void Update () {
		//si pulsamos espacio saltamos
		Vector2 velocidad = GetComponent<Rigidbody2D>().velocity; 
		Debug.DrawLine(transform.position,
		               new Vector3(transform.position.x + velocidad.x,
		            transform.position.y + velocidad.y,
		            transform.position.z));
	

		if(Input.GetKeyDown(KeyCode.Space)){
			salto ();
			}
		if (Input.GetKey (KeyCode.A) || pulsado_boton_izq) {
			mueve_izquierda ();
				}
		if(Input.GetKey(KeyCode.D)|| pulsado_boton_dch) {
			mueve_derecha();
		}
	
	}


	/*Funcion salto
	 * Aplica una fuerza al objeto con fuerza: fuerza
	 */

	public void salto(){
		Debug.Log ("Salta");
		rg.AddForce (new Vector2 (0, fuerza)); // Añadimos una fuerza
        anim = GetComponent<Animator>();
		//CS.Saber_Suelo ();
	}

	void mueve_derecha(){
		transform.localScale = mira_derecha;
		rg.AddForce(new Vector2(velocidad_edgar,0));
	}

	void mueve_izquierda(){
		transform.localScale = mira_izquierda;
		rg.AddForce(new Vector2(-velocidad_edgar,0));
	}

	public void pulsa_boton_dch(){
		pulsado_boton_dch = true;
	}

	public void suelta_boton_dch(){
		pulsado_boton_dch = false;
	}

	public void pulsa_boton_izq(){
		pulsado_boton_izq = true;

	}

	public void suelta_boton_izq(){
		pulsado_boton_izq = false;

	}
}