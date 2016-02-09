using UnityEngine;
using System.Collections;

public class mirar : MonoBehaviour {

	public Transform target;
	public GameObject bala;
	public float tiempo_disparo = 3f;
	private float prox_disparo = 0f;

	void Start(){
		prox_disparo = tiempo_disparo;
	}

	void Update (){

		transform.LookAt (target);
				if (Time.time >= prox_disparo) {
					Instantiate(bala,transform.position, transform.rotation);
					prox_disparo = Time.time + tiempo_disparo;
	}
}
}
