using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish_animation_script : MonoBehaviour
{
    private Animator finish;
    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        finish = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision coll)
    {
        i++;
        finish.SetInteger("steps", i);
    }
}
