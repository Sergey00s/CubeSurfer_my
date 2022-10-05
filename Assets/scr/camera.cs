using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private GameObject player;
    public Vector3 distancev;

    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
            
    }
    private void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(transform.position, player.transform.position + distancev, Time.deltaTime);
    }
}
