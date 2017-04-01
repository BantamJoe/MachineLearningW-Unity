using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Accord; 
using Accord.Neuro;
using Accord.Statistics;
using System.IO;
using System.Threading;
using Accord.Neuro.Learning;
using AForge;
using Accord.Controls;



public class NewBehaviourScript : MonoBehaviour {
	public double initialStep = 0.0125;
	public double sigmoidAlphaValue = 2.0;
	public double learningErrorLimit = 0.1;
	public  int sigmoidType = 0;
	public bool saveStatisticsToFiles = false;
	public bool needToStop=false;
	//public Text neuronsBox = new Text();
	//string neurons = "";
	public double[][] input = new double[4][] {
		new double[] {0, 0}, new double[] {0, 1},
		new double[] {1, 0}, new double[] {1, 1}
	};

	public double[][] output = new double[4][] {
		new double[] {0}, new double[] {1},
		new double[] {1}, new double[] {0}
	};




	public void starty(){
		
	}

	public void endy (){
	
	}

	public void Functionyy(){
		
	}


	// Use this for initialization
    void Start () {
		print ("Hello");
	//	neuronsBox.Text = neurons.ToString();
    }
	
	// Update is called once per frame
	void Update () {
	}
}
