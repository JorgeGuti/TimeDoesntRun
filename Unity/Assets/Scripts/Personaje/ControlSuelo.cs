using UnityEngine;
using System.Collections;

public class ControlSuelo : MonoBehaviour {

	bool toca_suelo = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.transform.tag == "Base"){
			toca_suelo = true;
		}
	}
	
	
	void OnTriggerExit2D(Collider2D objeto){
		toca_suelo = false;
	}

	public bool Saber_Suelo(){
		return toca_suelo;
	}
}
