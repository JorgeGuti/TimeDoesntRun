using UnityEngine;
using System.Collections;

public class PayasoEnemigo : MonoBehaviour {
	
	public Transform payaso;
	public Transform jugador;
	public float velocidad = 1.0f;
	private float startTime;
	private float journeyLength;
	public bool veo_a_edgar = false;
	private Animator an;
	private Animator an_rueda;
	
	void Start() {
		startTime = Time.time;
		journeyLength = Vector3.Distance(payaso.position, jugador.position);
		an = GetComponent<Animator>();
		an_rueda = transform.Find("rueda_payaso").GetComponent<Animator>();
	
	}
	void Update() {
		if(veo_a_edgar){
			float distCovered = (Time.time - startTime) * velocidad;
			float fracJourney = distCovered / journeyLength;
			transform.position = Vector3.Lerp(payaso.position, jugador.position, fracJourney);
			
		}
	}
	
	void OnTriggerEnter2D(Collider2D objeto){
		if(objeto.transform.tag == "Player"){
			veo_a_edgar = true;
			an.SetBool("ataque", true);
			an_rueda.SetBool("ataque", true);

		}
		
	}
	
	
	
	void OnTriggerExit2D(Collider2D objeto){
		if(objeto.transform.tag == "Player"){
			veo_a_edgar = false;
		}
		an.SetBool("ataque", false);
		an_rueda.SetBool("ataque", false);

		
	}
}
