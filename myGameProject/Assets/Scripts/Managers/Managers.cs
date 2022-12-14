using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance; // 유일성이 보장된다
    static Managers Instance { get { Init(); return s_instance; } } // 유일한 매니저를 갖고온다
    
    ClassSelectManager _classSelect = new  ClassSelectManager();
    public static ClassSelectManager classSelect
    {
        get { return Instance._classSelect; }
    }
    
    InputManager _input = new InputManager();

    public static InputManager input
    {
        get { return Instance._input; }
    }
    
    GameManager _game= new GameManager();
    public static GameManager game
    {
        get { return Instance._game; }
    }

    
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {   
        
       
        _input.OnUpdate();
      
    }
    
    static void Init()
    {
        
        
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();
            
            
        }		
    }
    
    
}
    