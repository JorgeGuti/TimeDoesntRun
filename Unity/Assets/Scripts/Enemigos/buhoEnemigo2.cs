using UnityEngine;
using System.Collections;

public class buhoEnemigo2 : MonoBehaviour {
	
		public Transform buho;
		public Transform jugador;
		public float velocidad = 1.0F;
		private float startTime;
		private float journeyLength;
		public bool veo_a_edgar = false;
	    public Animator an;
		void Start() {
			startTime = Time.time;
			journeyLength = Vector3.Distance(buho.position, jugador.position);
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
			}

		}

		void OnTriggerExit2D(Collider2D objeto){
		if(objeto.transform.tag == "Player"){
			veo_a_edgar = false;
		}
		
		}
	}

