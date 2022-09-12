using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ClassCricleTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject knight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        
        
        
        // if (other.gameObject == player)
        // {
        //     Managers.classSelect.player.playerClass = "CrazyKnight";
        //     Debug.Log("변신");
        //     Debug.Log(Managers.classSelect.player.playerClass);
        // }
        //
        player.SetActive(false);
        knight.SetActive(true);
    }

    void OnTriggerStay(Collider other) {
        //실행문
    }
    
    void OnTriggerExit(Collider other) {
        //실행문
    }
}
