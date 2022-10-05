using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elmas : MonoBehaviour
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
        if (obj.tag == "Player")
        {
            Destroy(this.gameObject);
            player.GetComponent<playerscr>().newscore();
        }
    }
}
