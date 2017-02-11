using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roundtracker : MonoBehaviour {

    int player1wins;
    int player2wins;
    int player1display;
    int player2display;
    

	
	void Awake () {
        DontDestroyOnLoad(transform.gameObject);
	}

    public void endround(bool winner)
    {
        if(winner)
        {
            player1wins++;
        }
        else
        {
            player2wins++;
        }
        if(player1wins == 3 || player2wins == 3)
        {
            player1display = player1wins;
            player2display = player2wins;
            player1wins = 0;
            player2wins = 0;
            SceneManager.LoadScene("Game_Over");
        }
    }
}
