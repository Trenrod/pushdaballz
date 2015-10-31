using UnityEngine;
using System.Collections;

public class BorderHandler : MonoBehaviour {

    public GameObject borderTop;
    public GameObject borderBottom;
    public GameObject borderLeft;
    public GameObject borderRight;

    public Rect curScreenSize = new Rect();

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (curScreenSize != Camera.main.pixelRect)
        {
            //Update border position
            Vector3 dimWorldPoint = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelRect.width, Camera.main.pixelRect.height, 0.0f));
            Debug.Log(dimWorldPoint);
            curScreenSize = Camera.main.pixelRect;

            borderTop.transform.localScale = Vector3.one;
            Bounds bounds = borderTop.GetComponent<SpriteRenderer>().sprite.bounds;
            borderTop.transform.localScale = new Vector3((dimWorldPoint.x * 2) / bounds.size.x, dimWorldPoint.y/10 / bounds.size.y, borderTop.transform.localScale.z);
            borderTop.transform.localPosition = new Vector3(0.0f, dimWorldPoint.y, 0.0f);

            borderBottom.transform.localScale = Vector3.one;
            bounds = borderBottom.GetComponent<SpriteRenderer>().sprite.bounds;
            borderBottom.transform.localScale = new Vector3((dimWorldPoint.x * 2) / bounds.size.x, dimWorldPoint.y / 10 / bounds.size.y, borderBottom.transform.localScale.z);
            borderBottom.transform.localPosition = new Vector3(0.0f, -dimWorldPoint.y, 0.0f);

            borderLeft.transform.localScale = Vector3.one;
            bounds = borderLeft.GetComponent<SpriteRenderer>().sprite.bounds;
            borderLeft.transform.localScale = new Vector3(dimWorldPoint.x / 10 / bounds.size.x, (dimWorldPoint.y*2)/ bounds.size.x, borderLeft.transform.localScale.z);
            borderLeft.transform.localPosition = new Vector3(-dimWorldPoint.x, 0.0f, 0.0f);

            borderRight.transform.localScale = Vector3.one;
            bounds = borderRight.GetComponent<SpriteRenderer>().sprite.bounds;
            borderRight.transform.localScale = new Vector3(dimWorldPoint.x / 10 / bounds.size.x, (dimWorldPoint.y * 2) / bounds.size.x, borderRight.transform.localScale.z);
            borderRight.transform.localPosition = new Vector3(dimWorldPoint.x +1 , 0.0f, 0.0f);
        }
    }
}
