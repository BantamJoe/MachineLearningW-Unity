using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Threading;
using System;


public class MyAi : MonoBehaviour {
    public GameObject Me;
    public GameObject Goal;
    public int agentStartX;
    public int agentStartY;
    public int agentStopX;
    public int agentStopY;
    public bool needToStop;
    public float myx, myz, myy;
    // learning settings
    public int learningIterations = 100;
    public double explorationRate = 0.5;
    public double learningRate = 0.5;
    public Rigidbody rb;
    public double poisonReward = 0; 
    public double moveReward = 0;
    public double wallReward = -1;
    public double goalReward = 1;
    public  int mapWidth = 10;
    public int mapHeight = 10;

    public enum Mood {HUNGER = 1, ANGER, SADNESS, SLEEPLESS, BORED };

    public void MyMood() { }

    public void Movement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.forward * 110);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
             rb.AddForce(Vector3.forward * -110);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * 110);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left* 110);
        }

    }
    public void  infront()
    {

    }
 
    public void Try() {
        Movement();
    }

    public void Learn()
    {
        
    }

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
	// Update is called once per frame
	void Update () {
        Try();
    }
}
