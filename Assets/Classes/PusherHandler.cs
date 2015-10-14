using UnityEngine;
using System.Collections;

public class PusherHandler : MonoBehaviour {

    public float factorForce = 1.0f;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void AddForce(Vector2 forceDir) {
        this.GetComponent<Rigidbody2D>().AddForce(forceDir * factorForce);
    }

    public void Reset()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        this.transform.position = Vector3.zero;
    }
}
