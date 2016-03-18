using UnityEngine;
using System.Collections;

public class GreenPlanetScript : MonoBehaviour {

    private float speed = 0.03f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Transform>().Rotate(Vector3.forward * speed);
	}
}
