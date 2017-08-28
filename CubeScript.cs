using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

	public float rotateSpeed = 1.0f;
	public Vector3 spinSpeed = Vector3.zero;
	//define axis of spin as y axis
	Vector3 spinAxis = new Vector3(0, 1, 0);

	// Use this for initialization
	void Start () {
		// setsize(2.0f);
		//this.transform.position = new vector3(0, 5, 3);
		spinSpeed = new Vector3 (Random.value, Random.value, Random.value);
		spinAxis = Vector3.up;
		spinAxis.x = (Random.value - Random.value)*.1f;


	}

	public void SetSize(float size)
	{
		this.transform.localScale = new Vector3(size, size, size);
	}
	// Update is called once per frame
	void Update () {
		this.transform.Rotate(spinSpeed);
		this.transform.RotateAround (Vector3.zero, spinAxis, rotateSpeed);
		// comment out above section when you dont want spin 
		//cube is individual cube 

		//Renderer rend = GetComponent<Renderer>();
		//rend.material.shader = Shader.Find("specular");
		//rend.material.color = new Color (Random.value, Random.value, Random.value);

	}
}
