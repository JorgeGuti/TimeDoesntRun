using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

public void inicio(){
		Application.LoadLevel("Nivel 04");
	}
	public void salir(){
		Application.Quit();
	}
}