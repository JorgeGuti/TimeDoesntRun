using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameControl : MonoBehaviour {

	//Text text;
	GameObject player;

	//[Header("Health Settings")]
	//public int score;

	[Header("Checkpoints")]
	public string level;
	public string checkpoint;
    void Awake() {

		/*if (!PlayerPrefs.HasKey ("Puntos")) {
			PlayerPrefs.SetInt("Puntos", 0);
		}*/

		//score = PlayerPrefs.GetInt("Puntos");


		if (!PlayerPrefs.HasKey("Level")) {
			PlayerPrefs.SetString("Level", "Nivel04");
		}



		if (!PlayerPrefs.HasKey("Checkpoint")) {
			PlayerPrefs.SetString("Checkpoint", "checkpoint_0");
		}
		
		checkpoint = PlayerPrefs.GetString ("Checkpoint");
		level = PlayerPrefs.GetString ("Level");
        //text = GameObject.Find("Puntos").GetComponent<Text>();

		player = GameObject.FindGameObjectWithTag("Player");
        
    }
    // Use this for initialization
    void Start () {
        //text.text = ""+score;
		if (checkpoint != "checkpoint_0") {
			player.transform.position = GameObject.Find(checkpoint).transform.position;
		}

	}
	
	// Update is called once per frame
	void Update () {
	  
	}

    public void cambiaPuntos(int puntos)
    {
        /*score = PlayerPrefs.GetInt("Puntos");
        score = score + puntos;*/
        //PlayerPrefs.SetInt("Puntos", score);
        //text.text = "" + score;
    }

    public void restart()
    {
        //PlayerPrefs.SetInt("Puntos", 0);
		PlayerPrefs.SetString("Level", "Level1");
		PlayerPrefs.SetString("Checkpoint", "checkpoint_0");
        Application.LoadLevel("level1");
    }



}
