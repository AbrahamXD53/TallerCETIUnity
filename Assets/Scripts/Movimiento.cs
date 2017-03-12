using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

	public int puntos=0;
	

	void Awake()
	{
		Debug.Log("He despertado!");
	}

	void Start () {
		puntos=100;
		print("Has ganado 100 puntos");
	}
	
	void Update () {
		puntos++;
		if(Input.GetKeyDown(KeyCode.Space)){
			Debug.Log("Quizas podria brincar");

			transform.Translate(new Vector3(0, 2f,0));
		}
	}
}
