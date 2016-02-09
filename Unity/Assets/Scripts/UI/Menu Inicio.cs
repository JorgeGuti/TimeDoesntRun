using UnityEngine;
using System.Collections;

public class MenuInicio : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void NuevaPartida (){
		Time.timeScale = 1f;		
		Application.LoadLevel ("Nivel01");
	}
	public void Continuear (){
		Time.timeScale = 1f;		
		Application.LoadLevel ("Nivel04");
	}
	
	public void Salir(){
		Application.Quit ();
	}

}
