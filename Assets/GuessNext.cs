using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Accord; 
using Accord.Statistics;
using Accord.Neuro;
using Accord.MachineLearning;
using Accord.Math;
using Accord.Math.Optimization;
using Accord.Controls;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Statistics.Kernels;


public class GuessNext : MonoBehaviour {
	public Text miText;
	public GameObject milo;


	void Start(){
		// Generate always same random numbers
		//Accord.Math.Random.Generator.Seed = 0;

		// The following is a simple auto association function in which 
		// the last column of each input correspond to its own class. This
		// problem should be easily solved using a Linear kernel.

		// Sample input data
		double[][] inputs = {
		new double[] { 1, 2, 8 },
		new double[] { 6, 2, 3 },
		new double[] { 1, 1, 1 },
		new double[] { 7, 6, 7 },
	};

	// Output for each of the inputs
	int[] outputs = { 0, 3, 1, 2 };


	// Create the multi-class learning algorithm for the machine
	var teacher = new MulticlassSupportVectorLearning<Linear>()
	{
		// Configure the learning algorithm to use SMO to train the
		//  underlying SVMs in each of the binary class subproblems.
		Learner = (param) => new SequentialMinimalOptimization<Linear>()
		{
			// If you would like to use other kernels, simply replace
			// the generic parameter to the desired kernel class, such
			// as for example, Polynomial or Gaussian:

			Kernel = new Linear() // use the Linear kernel
		}
	};

	// Estimate the multi-class support vector machine using one-vs-one method
	MulticlassSupportVectorMachine<Linear> ovo = teacher.Learn(inputs, outputs);

	// Obtain class predictions for each sample
		int[] predicted = ovo.Decide(inputs);


		miText.text = "Input : " +
		" {1, 2, 0 } \n" +
		" {6, 2, 3 }\n" +
		" {1, 1, 1 }\n" +
		" { 7, 6, 2 }\n\n" +
		"Predicted Guess: ";
		for(int i=0; i < predicted.Length; i++)
			{
			Console.WriteLine(predicted[i]);
			miText.text += predicted [i];
			}
	}}
	// Compute classification error
	//double error = new ZeroOneLoss(outputs).Loss(predicted);