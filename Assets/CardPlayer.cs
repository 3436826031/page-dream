using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPlayer : MonoBehaviour
{

    public GameObject lian;


    public static CardPlayer instane;

    public Sprite[] spr;


    // Start is called before the first frame update
    void Start()
    {
        instane = this;

        lian = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void dure() {

        lian.GetComponent<SpriteRenderer>().sprite = spr[0];
    
    
    }

    void xiao() {

        lian.GetComponent<SpriteRenderer>().sprite = spr[1];

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag.Equals("emeny")) { 
        
        
        
        
        }




    }




}
