using UnityEngine;
using System.Collections;

public class buhoEnemigo2 : MonoBehaviour {
	
		public Transform buho;
		public Transform jugador;
		public float speed = 1.0F;
		private float startTime;
		private float journeyLength;
		void Start() {
			startTime = Time.time;
			journeyLength = Vector3.Distance(buho.position, jugador.position);
		}
		void Update() {
			float distCovered = (Time.time - startTime) * speed;
			float fracJourney = distCovered / journeyLength;
			transform.position = Vector3.Lerp(buho.position, jugador.position, fracJourney);
		}
	}

