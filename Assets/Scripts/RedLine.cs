using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RedLine : MonoBehaviour
{
    public GameObject count;
    public GameObject MainCamera;
    public Color lose;
    public bool LevelsEnd = false;    
    void Start()
    {
        
    }  
    void Update()
    {
        if (count.GetComponent<Men_Cont>().Mens == 0)
        {
            LevelsEnd = true;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if( count.GetComponent<Men_Cont>().Mens == 0)
        {
            LevelsEnd = true;
        }
        else
        {
            LevelsEnd = true;
            MainCamera.GetComponent<Camera>().backgroundColor = lose;
        }
    }

}
