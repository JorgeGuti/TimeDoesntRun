using UnityEngine;
using System.Collections;

public class Quitavidas : MonoBehaviour {

	public int puntos = 5;
	public float cadencia = 1f;
	float proximo_hit = 0;
	bool dentro_area = false;
	GameControl gc;
	// Use this for initialization
	void Start () {
		gc = GameObject.Find("GameControl").GetComponent<GameControl>();
	}
	
	// Update is called once per frame
	void Update () {
		if( (proximo_hit < Time.time) && dentro_area){
			gc.resta_vida(puntos);
			proximo_hit = Time.time + cadencia;
		}
	}
	
	void OnTriggerEnter(Collider2D objeto){
		if(objeto.tag == "Player"){
			//Debug.Log("Entra Player");
			dentro_area = true;
		}
	}
	
	void OnTriggerExit2d(Collider2D objeto){
		if(objeto.tag == "Player"){
			//Debug.Log("Entra Player");
			dentro_area = false;
		}
	}
	
}
*/