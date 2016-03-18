using UnityEngine;
using System.Collections;

public class CaptainScript : MonoBehaviour {

    private float speed = 0.02f;
    private int angle = -60;
    private int direction = 1;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        //GetComponent<Transform>().Rotate(Vector3.forward);

        if(direction == 1){
            GetComponent<Transform>().Rotate(Vector3.forward * speed);
            angle++;

            if(angle == 61){
                direction = 0;
            }
        }else if(direction == 0){
            GetComponent<Transform>().Rotate(Vector3.forward * -1 * speed);
            angle--;

            if(angle == -61){
                direction = 1;
            }
        }

	}

    void FixedUpdate()
    {
        
    }
}
