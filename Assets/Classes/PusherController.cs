using UnityEngine;
using System.Collections;

public class PusherController : MonoBehaviour {

    public PusherHandler pushHandler;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetMouseButton(0) || Input.GetMouseButtonDown(0))
        {
            if(this.GetComponent<RectTransform>().rect.Contains(Input.mousePosition - this.transform.position)) { 
                Vector2 forceDir = (Input.mousePosition - this.transform.position) * Time.deltaTime;
                pushHandler.AddForce(forceDir);
            }
        }
    }
}
