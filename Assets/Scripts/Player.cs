using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Player : MonoBehaviour
{

    public Vector3 direction;
    public bool is_finish = false;
    public bool PlayerHad = false;
    public bool LevelEnd = false;
    bool jump = false;
    private Animator anim;
    public float speed;
    Rigidbody rb;
    public float force = 0f;
    public GameObject Next;
    public GameObject RedLine;
    public GameObject counter;
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();

    }
    void FixedUpdate()
    {       
        if (is_finish == false && PlayerHad == false)
        {
            transform.Translate(direction.normalized * speed);
            anim.SetBool("isRuning", true);          
        }
        if (LevelEnd == true)
        {
            if (is_finish == true && PlayerHad == false)
            {
                is_finish = false;
            }
            else if (is_finish == true && PlayerHad == true)
            {
                is_finish = false;
                PlayerHad = false;
            }          
        }
    }      
    void OnTriggerEnter(Collider coll)
    {        
        anim.SetBool("isRuning", false);
        if(coll.tag == "Finish")
        {
            if(LevelEnd == false)
            {
                PlayerHad = false;
                is_finish = true;
                Next.GetComponent<Player>().speed = 0.04f;
            }
            else if (LevelEnd == true)
            {
                PlayerHad = false;
                is_finish = true;
            }
        }
    }
    
    void OnTriggerStay(Collider coll)
    {       
        if(coll.tag == "ground_j")
        {            
            jump = true;            
        }        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "ground")
        {   
            if(LevelEnd == false)
            {
                Next.GetComponent<Player>().speed = 0.04f;
                PlayerHad = false;                        
            }
            else if (LevelEnd == true)
            {
                PlayerHad = false;                
            }
        }
        if(collision.collider.tag == "PlayerHad" )
        {   
            if(LevelEnd == false)
            {               
                PlayerHad = true;
                Next.GetComponent<Player>().speed = 0.04f;
                anim.SetBool("isRuning", false);                
            }
            else if(LevelEnd == true)
            {
                PlayerHad = true;
                anim.SetBool("isRuning", false);
            }
        }
        
    }
    
    
    void OnTriggerExit(Collider coll)
    {        
        if(coll.tag == "ground_j") 
        {
            jump = false;                   
        } 
        if(coll.tag == "Finish")
        {
            is_finish = false;
            PlayerHad = false;
        }
    }            
    void Update()
    {
        if(Input.GetMouseButtonDown(0) )
        {                
            if(jump == true)  
            {
                rb.AddForce(Vector3.up * force, ForceMode.Impulse);           
            }         
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            LevelEnd = true;            
        }        
        
    }
    // -------------------------------------------------- Menu  Buttons
    public void Restart()
    {
        Application.LoadLevel(0);
    }
    public void Exit()
    {
        Exit();
    }
    
    




}
