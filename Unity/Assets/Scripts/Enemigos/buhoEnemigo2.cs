using UnityEngine;
using System.Collections;

public class buhoEnemigo2 : MonoBehaviour {
	
		public Transform buho;
		public Transform jugador;
		public float velocidad = 1.0F;
		private float startTime;
		private float journeyLength;
		public bool veo_a_edgar = false;
	    private Animator an;
		private Animator an_ala;

		void Start() {
			startTime = Time.time;
			journeyLength = Vector3.Distance(buho.position, jugador.position);
			an = GetComponent<Animator>();
			an_ala = transform.Find("alalante").GetComponent<Animator>();
		}
		void Update() {
			if(veo_a_edgar){
				float distCovered = (Time.time - startTime) * velocidad;
				float fracJourney = distCovered / journeyLength;
				transform.position = Vector3.Lerp(buho.position, jugador.position, fracJourney);
				
			}
		}

		void OnTriggerEnter2D(Collider2D objeto){
			if(objeto.transform.tag == "Player"){
				veo_a_edgar = true;
				an.SetBool("ataque", true);
				an_ala.SetBool("ataque", true);
			}

		}

		

		void OnTriggerExit2D(Collider2D objeto){
		if(objeto.transform.tag == "Player"){
			veo_a_edgar = false;
		}
		an.SetBool("ataque", false);
		an_ala.SetBool("ataque", false);
		
		}
	}

