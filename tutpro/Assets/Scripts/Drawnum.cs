using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drawnum : MonoBehaviour {

    public Text CurrentScore;
    public Text HighScore;

	// Use this for initialization
	void Start ()
    {
        int a1 = PlayerPrefs.GetInt("Highscore", 0);
        HighScore.text = a1.ToString();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    //Button function
    public void Draw()
    {
        int a = Random.Range(1, 1000);
        CurrentScore.text = a.ToString();
        int a1 = PlayerPrefs.GetInt("Highscore", 0);
        if(a > a1)
        {
            HighScore.text = a.ToString();
            PlayerPrefs.SetInt("Highscore", a);
        }
    }
}
