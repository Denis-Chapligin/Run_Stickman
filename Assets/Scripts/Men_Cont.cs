using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Men_Cont : MonoBehaviour
{
    public Text Counter;
    public int Mens = 0;

    void Update()
    {
        Counter.text = Convert.ToString(Mens);
    }
    void OnCollisionEnter(Collision collision)
    {
        Mens--;
        Counter.text = Convert.ToString(Mens);
    }
}
