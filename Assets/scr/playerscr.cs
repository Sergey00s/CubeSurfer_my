using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;

public class playerscr : MonoBehaviour
{
    public int spd;
    private int i;
    public int pos;
    public bool status;
    public GameObject txt;
    private int score;

    void Start()
    {
        i = 0;
        score = 0;
        status = true;
       
    }

    void inputs()
    {
        float hor = Input.GetAxis("Horizontal");

           
        this.transform.Translate(0, 0, hor * Time.deltaTime * 15);
       
        
    }

    void Update()
    {
        TextMeshProUGUI mytxt;

        if (!status)
        {
            Debug.Log("bitti");
            Time.timeScale = 0.1f;
        }    
        inputs();
        this.transform.Translate(-1 * spd * Time.deltaTime, 0, 0);
        mytxt = this.txt.GetComponent<TextMeshProUGUI>();
        mytxt.text = "Score: " + score.ToString();
    }

    public void newCollectable(GameObject obj)
    {
        
      
        obj.tag = "Player";
        obj.transform.SetParent(this.transform);
        obj.transform.position = this.transform.position;
        this.transform.Translate(0, 1, 0);
        i++;
        obj.transform.Translate(0, -i, 0);

    }
    

    public void newscore()
    {
        score++;
    }


    void mvdown()
    {
        this.transform.Translate(0, -1, 0);
    }

    public void banCollectable(GameObject obj)
    {
        GameObject[] objs;

        obj.tag = "nothing";
        i--;
        obj.transform.SetParent(null);
        objs = GameObject.FindGameObjectsWithTag("Player");
        Invoke("mvdown", 0.2f);
         
    }
 
}
