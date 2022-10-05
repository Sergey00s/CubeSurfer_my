using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        GameObject obj;

        obj = collision.gameObject;
        if (obj.tag == "Player" && this.tag == "enemy")
        {
            if (obj.name == "player")
            {
                player.GetComponent<playerscr>().status = false;
                return;
            }
            player.GetComponent<playerscr>().banCollectable(obj.gameObject);
            this.tag = "nothing";
        }
    }


}
