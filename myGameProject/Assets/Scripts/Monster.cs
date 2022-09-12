using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private float MonsterSpeed = 2;
    
    public GameObject Player;
    public GameObject Monster1;
    
    private float Distance;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        followUser();
    }

    void followUser()
    {
        
        Distance = Vector3.Distance( Player.transform.position,Monster1.transform.position);
        if (Distance <= 3)
        {
            Monster1.transform.position 
                = Vector3.MoveTowards(Monster1.transform.position, Player.transform.position, MonsterSpeed* Time.deltaTime);
        }
    }
}
