using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
  
    public Rigidbody charRigidbody;
    
    
    public float moveSpeed = 1;
    public string playerClass;
    
    void Start()
    {
        Managers.input.keyaction-= OnKeyboard;
        Managers.input.keyaction+= OnKeyboard;
        
       
    }

    void Update()
    {
        




    }

    void OnKeyboard()
    {
        
        
        charRigidbody = gameObject.GetComponent<Rigidbody>();
      
        float hAxis = Input.GetAxisRaw("Horizontal");
        float vAxis = Input.GetAxisRaw("Vertical");

        Vector3 inputDir = new Vector3(hAxis, 0, vAxis).normalized;

        charRigidbody.position += inputDir * moveSpeed*Time.deltaTime;
        
        transform.LookAt(transform.position + inputDir);
        
    }

    void attack()
    {
        

    }
}
