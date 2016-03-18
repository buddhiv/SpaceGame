using UnityEngine;
using System.Collections;

public class BluePlanetScript : MonoBehaviour {

    private float speed = 0.01f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().Rotate(Vector3.forward * speed * -1);
    }
}
