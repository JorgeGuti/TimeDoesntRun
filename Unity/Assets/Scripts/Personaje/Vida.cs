using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Vida : MonoBehaviour {

	public int max_vida = 3;
	public int vida;
	Text Textovida;

	// Use this for initialization
	void Start () {
		vida = max_vida;
		Textovida = GameObject.Find("Textovida").GetComponent<Text>();
		Textovida.text = "" + vida;
	
	}

	public void resta_vida(int puntos){//que reste vida al tocar el enemigo al player
		vida = vida - puntos;
		if(vida < 0){
			//Aqui se pone que recarge el nivel
		}
		Textovida.text = "" + vida;
	}

	public void suma_vida(int puntos){ //que sume vida al tocar el item al player
		vida = vida + puntos;
		if(vida > 8){
			vida = 8;
		}
		Textovida.text = "" + vida;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
