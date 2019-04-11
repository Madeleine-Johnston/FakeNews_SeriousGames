using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjInteraction : MonoBehaviour {

    public Collider coll;
    public GameObject laptopClick;
    public bool click = false;
    public GameObject laptopUI;

    //public GameObject linkAna1;
    //public GameObject linkAna2;
    //public GameObject linkAna3;
    //public GameObject linkAna4;
    //public GameObject linkAna5;
    //public GameObject linkAna6;
    //public GameObject linkAna7;
    //public GameObject linkAna8;


    // Use this for initialization
    void Start () {
        coll = GetComponent<Collider>();
    }

    public void onClick()
    {
        if (click == false)
        {
            //laptopClick.SetActive(false);
            laptopUI.SetActive(true);
            click = true;
        }
        else
        {
            if (click == true)
            {
                laptopUI.SetActive(false);
                click = false;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && click == false)
        {
            //send raycast to detect collision
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            //if collision by raycast and object
            if (coll.Raycast(ray, out hit, 100.0f))
            {
                //displays info 
                laptopClick.SetActive(false);
                laptopUI.SetActive(true);
                click = true;
                //linkAna1.SetActive(true);
                //linkAna2.SetActive(true);
            }
        }

        else
        {
            if (Input.GetMouseButtonDown(0) && click == true)
            {
                //removes info text on screen
                Debug.Log("set false");

                //send raycast to detect collision
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                //if collision by raycast and object
                if (coll.Raycast(ray, out hit, 100.0f))
                {
                    //displays info 
                    laptopClick.SetActive(false);
                    laptopUI.SetActive(false);
                    click = false;
                }
            }
        }
    }

        
}
