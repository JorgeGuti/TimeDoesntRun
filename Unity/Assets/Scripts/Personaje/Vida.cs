using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Vida : MonoBehaviour {

	public int max_vida = 100;
	public int vida;
	Slider barravida;

	// Use this for initialization
	void Start () {
		vida = max_vida;
		barravida = GameObject.Find("BarraVida").GetComponent<Slider>();
	
	}

	public void resta_vida(int puntos){//que reste vida al tocar el enemigo al player
		vida = vida - puntos;
		if(vida<0){
			vida = 0;
		}
		barravida.value = vida;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
