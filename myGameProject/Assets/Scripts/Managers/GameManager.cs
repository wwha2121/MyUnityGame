using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject Knight;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        Player = GameObject.Find("Player");
        Knight = GameObject.Find("Knight");
        gameInit();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void gameInit()
    {   
        Knight.SetActive(false);
        
    }
}
