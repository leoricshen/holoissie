﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject Transporter;

	// Use this for initialization
	void Start () {
       
    }

    // Update is called once per frame
    void Update () {
         // Check if no wormhole abort
        if (Transporter == null)
        {
            Debug.Log("No transporter. Please set!");
            return;
        }

        // Get the position
        Vector3 transporter = Transporter.transform.position;
        Vector3 camera = Camera.main.transform.position;
        Vector3 yDifference = transporter - camera;

        TransporterBehaviour behaviour = Transporter.GetComponent<TransporterBehaviour>();

        
        //Debug.Log("Camera " + camera.y + " Transporter " + transporter.y + " Difference " + yDifference.y);
        

        if (!behaviour.TransporterComplete)
        {
            if (yDifference.y > .5)
            {
                // Get Transporter behaviour script and call methods on it
                behaviour.TriggerDown();
            }
            else
            {
                behaviour.TriggerUp();
            }
        }

    }

    // ALIENS can look for gameplay manager
    // 
}