using UnityEngine;
using System.Collections;

public class teletransporte : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		}

	void OnTriggerEnter2D(Collider2D objeto) {
		if (objeto.transform.tag == "emisor") {
			transform.position = GameObject.FindGameObjectWithTag ("receptor").transform.position; 
		}
		
		
	} 
	void OnCollisionEnter2D (Collision2D objeto){
		if(objeto.transform.tag == "Player"){
			Application.LoadLevel ("Nivel 04");
		}
	}


	}

