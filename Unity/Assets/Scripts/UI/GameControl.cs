using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameControl3 : MonoBehaviour {

	//Text text;
	GameObject player;


	[Header("Checkpoints")]
	public string level;
	public string checkpoint;
	public string checkpoint2;
    void Awake() {

		if (!PlayerPrefs.HasKey ("Puntos")) {
			PlayerPrefs.SetInt("Puntos", 0);
		}

		//score = PlayerPrefs.GetInt("Puntos");


		if (!PlayerPrefs.HasKey("Level")) {
			PlayerPrefs.SetString("Level", "Nivel01");
		}



		if (!PlayerPrefs.HasKey("Checkpoint")) {
			PlayerPrefs.SetString("Checkpoint", "CH1_0");
		}
		
		checkpoint = PlayerPrefs.GetString ("Checkpoint");
		level = PlayerPrefs.GetString ("Level");
		//text = GameObject.Find("Puntos").GetComponent<Text>();

		player = GameObject.FindGameObjectWithTag("Player");

        
    }
    // Use this for initialization
    void Start () {
       
		if (checkpoint != "CH1_0") {

			player.transform.position = GameObject.Find(checkpoint).transform.position;
		}

	}
	
	// Update is called once per frame
	void Update () {
	  
	}

   // public void cambiaPuntos(int puntos)
	//{
        //score = PlayerPrefs.GetInt("Puntos");
	//score = score + puntos;
	//PlayerPrefs.SetInt("Puntos", score);
	//text.text = "" + score;
	// }

    public void reiniciar(){
        PlayerPrefs.SetInt("Puntos", 0);
		PlayerPrefs.SetString("Level", "Nivel01");
		PlayerPrefs.SetString("Checkpoint", "CH1_0");
		Application.LoadLevel(PlayerPrefs.GetString("Level"));
    }

	public void continuar(){
		PlayerPrefs.SetInt("Puntos", 0);
		Application.LoadLevel(PlayerPrefs.GetString("Level"));
	}

	public void salir (){
		Application.LoadLevel ("Inicio");
	}

	public void resta(){

	}

	public void exit (){
		Application.Quit();
	}

}
