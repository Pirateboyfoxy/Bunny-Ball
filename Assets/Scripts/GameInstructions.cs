using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstructions : MonoBehaviour
{
    public string message = "Use WASD to move. Navigate though the maze and find the key!";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
