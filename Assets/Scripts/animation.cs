using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class animation : MonoBehaviour
{    
    private Animator platform;
    public bool player = false;
    
    
    // Start is called before the first frame update
    void Start()
    {       
        platform = GetComponent<Animator>();
        
    }
    void OnCollisionEnter(Collision coll)
    {
        player = true;
        
    }
    void OnCollisionExit(Collision coll)
    {
        player = false;
        platform.SetBool("press", false);
    }
    // Update is called once per frame
    void Update()
    {       
        if(Input.GetMouseButtonDown(0))
        {     
            if(player == true)
            {
                platform.SetBool("press",true);
            }
            
        }               
    }
    
}
