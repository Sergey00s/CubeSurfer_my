using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class collectable : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody h;
        if (this.tag == "nothing")
        {
            h = this.GetComponent<Rigidbody>();
            h.useGravity = true;
            h.freezeRotation = false;
            h.constraints = RigidbodyConstraints.None;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject obj;

        obj = collision.gameObject;
        if (obj.tag == "Player" && this.tag == "collectable")
        {
            player.GetComponent<playerscr>().newCollectable(this.gameObject);
        }
       
    }


}
