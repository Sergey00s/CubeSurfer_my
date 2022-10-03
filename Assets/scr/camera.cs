using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float camDistance;
    public GameObject player;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(player.transform.position.x + camDistance, this.transform.position.y, player.transform.position.z + camDistance);
    }

    void fixedUpdate()
    {
        this.transform.position = new Vector3(player.transform.position.x, this.transform.position.y, player.transform.position.z + camDistance);
    }
}
