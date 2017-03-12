using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciar : MonoBehaviour {

	public GameObject prefab;

	public float espera=1f;

	void Start () {
		StartCoroutine(Spawn());
	}

	IEnumerator Spawn(){
		Instantiate(prefab,transform.position,Quaternion.identity);
		yield return new WaitForSeconds(espera);
		StartCoroutine(Spawn());
	}
	
	void Update () {
		
	}
}
