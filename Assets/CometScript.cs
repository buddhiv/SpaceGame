using UnityEngine;
using System.Collections;

public class CometScript : MonoBehaviour {

    private GameObject gameObject;

	// Use this for initialization
	void Start () {
        gameObject = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        spawn();
	}

    void spawn()
    {
        new WaitForSeconds(2);
        Vector3 newpos = new Vector3(Random.Range(100,200), Random.Range(100,200));
        Instantiate(GetComponent<Transform>(), newpos, );
    }
}
