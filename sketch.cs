using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sketch : MonoBehaviour {

	public GameObject myPrefab;

	//public UnityEngine.GameObject[] cubes;
	//public int cube = 0;


	void Start () {
		int totalCubes = 30;
		float totalDistance = 2.9f;
			float duration = 1.5f;


		
		//cubes = new GameObject[30];
		//Linear distro
		//for (int i = 0; i < totalCubes; i++) 
		//{
			//float perc = i / (float)totalCubes;
			//float x = perc * totalDistance;
			//float y = 3.0f; 
			//float z = 0.0f;
			//var newCube = (GameObject)Instantiate (myPrefab, new Vector3 (x, y, z), Quaternion.identity);
			//newCube.GetComponent<CubeScript> ().SetSize (1.0f - perc);
			//newCube.GetComponent<CubeScript> ().rotateSpeed = 0; // perc;// Random.value;
		//}
		// SIN() distro 
		for (int i = 0; i < totalCubes; i++) 
		{
			//making cubes fit the screen by working out percentage 
			float perc = i / (float)totalCubes;
			//used for distribution of space between the cubes 
			float sin = Mathf.Sin(perc * Mathf.PI/2);

			//placing cubes equally distributed in the x axis 
			float x = 1.8f + sin * totalDistance;
			float y = 5.0f; 
			float z = 0.0f;

			//assigning the cibes to a random space 
			//float x = (Random.value - Random.value)*3;
			//float y = (Random.value)*8;
			//float z = (Random.value - Random.value)*5;

			//Have to deviate the initial x position from 0 to spin off center 
			var newCube = (GameObject)Instantiate (myPrefab, new Vector3 (x, y, z), Quaternion.identity);
			newCube.GetComponent<CubeScript> ().SetSize (.45f*(1.0f - perc));
			newCube.GetComponent<CubeScript> ().rotateSpeed = .2f + perc*4.0f; // perc;// Random.value;
		
			//sketch is layout view and scene view 

			//cubes[i] = newCube;
		}
		//InvokeRepeating ("ChangeColor", 2.0f, 1.0f);
	}
	

	void Update () {
		
	}

	//void colorChanger() {
		//cubes[cube].GetComponent<Renderer>().material.color = Random.ColorHSV (0f, 1f, 1f, 1f, 0.5f, 1f);
		//if (cube < 29) {
			//cube = cube + 1;
		//} 
		//else {
			//cube = 0;
		//}
}

