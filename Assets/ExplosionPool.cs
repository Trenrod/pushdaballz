using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ExplosionPool : MonoBehaviour {

    public List<GameObject> explosions;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Explosion(Vector3 position)
    {
        GameObject go = Instantiate(explosions[0]);
        go.transform.position = position;
    }
}
