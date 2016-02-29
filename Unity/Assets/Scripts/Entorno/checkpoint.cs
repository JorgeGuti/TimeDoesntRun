using UnityEngine;
using System.Collections;

public class checkpoint : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D objeto){
		//Debug.Log ("Triger Enter");
		if (objeto.transform.tag == "Player") {
			PlayerPrefs.SetString("Checkpoint",transform.name);
			PlayerPrefs.SetString("Level",Application.loadedLevelName);
			Debug.Log ("Checkpoint " + transform.name);
		}
	}
}
