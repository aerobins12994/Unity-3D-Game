﻿using UnityEngine;
using System.Collections;

public class Pick_Up : MonoBehaviour {

    public int distance;
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Collect();
	
	}

    void Collect()
    {
      if(Input.GetMouseButtonUp(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, distance))
            {
                if(hit.collider.gameObject.name == "item")
                {
                    Debug.Log("item hit");
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
