using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
