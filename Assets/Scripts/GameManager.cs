using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver;
    public GameObject winnerUI;
    public GameObject player;
    //Level switch code
    public GameObject LevelOne;
    public GameObject LevelTwo;
    public int currentLevel = 1;

    private void Update()
    {
        if(currentLevel == 2)
        {
            LevelOne.SetActive(false);
            LevelTwo.SetActive(true);
        }
       //is the game over?
       if(gameOver == true)
       {
        GameOver();
       }
    }

    void GameOver() {
        player.GetComponent<Player>().enabled = false;
        Destroy(player.GetComponent<Rigidbody>());
        winnerUI.SetActive(true);
        gameObject.SetActive(false);
    }
}
