using UnityEngine;
using System.Collections;

public class troncopodrido : MonoBehaviour {

	public string nombre = "Player";
	public int Tiempo_Espera = 3;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start (){
		rb = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D (Collision2D objeto){
		string etiqueta = objeto.transform.tag;
		if (etiqueta == nombre) {
			Debug.Log (etiqueta);
			StartCoroutine ("TiempoEspera");
		}
		if (etiqueta == "Limite") {
			Destroy(gameObject);
		}
	}

	IEnumerator TiempoEspera (){
		yield return new WaitForSeconds (Tiempo_Espera);
		rb.isKinematic = false;
	}
}
