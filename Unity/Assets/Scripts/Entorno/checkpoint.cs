using UnityEngine;
using System.Collections;

public class checkpoint : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D objeto){
		Debug.Log ("Trriger Enter");
		if (objeto.transform.tag == "Player") {
			PlayerPrefs.SetString("Checkpoint",transform.name);
			Debug.Log ("Checkpoint " + transform.name);
		}
	}
}
