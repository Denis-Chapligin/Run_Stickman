using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class finish_trigger : MonoBehaviour
{
    public Text counter_n;
    public Text counter_h;
    public GameObject mens_counter;
    public GameObject Panel_Win;
    public GameObject Panel_Lose;
    public GameObject Game_panel;
    public int is_finished = 0;
   
    public GameObject[] player;
    // Start is called before the first frame update
    void Start()
    {
        counter_n.text = Convert.ToString(is_finished);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        counter_n.text = Convert.ToString(is_finished);
        if (is_finished == 4)
        {
            for(int i = 0;i < player.Length;i++)
            {
                player[i].GetComponent<Player>().LevelEnd = true;
            }
            Game_panel.SetActive(false);
            Panel_Win.SetActive(true);
        }
        if(mens_counter.GetComponent<Men_Cont>().Mens == 0)
        {
            for (int i = 0; i < player.Length; i++)
            {
                player[i].GetComponent<Player>().LevelEnd = true;
            }
            Game_panel.SetActive(false);
            Panel_Lose.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            is_finished++;
            mens_counter.GetComponent<Men_Cont>().Mens--;
        }
    }
}
