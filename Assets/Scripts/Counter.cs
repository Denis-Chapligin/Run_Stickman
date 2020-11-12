using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public GameObject counter;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
            counter.GetComponent<Men_Cont>().Mens -= 1;
    }
}
