using UnityEngine;
using System.Collections;

public class menuController2 : MonoBehaviour {
	private Animator anim; 
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Escape)){
			if(anim.GetBool("MuestraMenu")==false){
				muestra_menu();
			}
			
			else{
				oculta_menu();
			}
		}
	}
	
	
	public void muestra_menu(){
		Time.timeScale = 0;
		anim.SetBool("MuestraMenu",true);
	}
	
	public void oculta_menu(){
		Time.timeScale = 1f;
		anim.SetBool("MuestraMenu",false);
		Debug.Log("Oculta");
	} 
	
	public void Empezar (){
		Time.timeScale = 1f;		
		Application.LoadLevel("Nivel02") ;
	}
	
	public void SiguienteNivel (){
		Time.timeScale = 1f;		
		Application.LoadLevel ("Nivel05");
	}
	
	public void Salir(){
		Application.LoadLevel ("Inicio");
	}
	
}