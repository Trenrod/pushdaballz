using UnityEngine;
using System.Collections;

public class BorderCollisionTopDownEvent : MonoBehaviour {

    public GameManager gameManager;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Player")
        {
            gameManager.GameOver();
        }

    }
}
