using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public Sprite left;
    public Sprite right;
    public Sprite up;
    public Sprite down;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxisRaw("Vertical") > 0.5f ) {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            this.GetComponent<SpriteRenderer>().sprite = up;
        }
        else if (Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            this.GetComponent<SpriteRenderer>().sprite = down;
        }
        else if(Input.GetAxisRaw("Horizontal") > 0.5f ) {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            this.GetComponent<SpriteRenderer>().sprite = right;
        }
        else if( Input.GetAxisRaw("Horizontal") < -0.5f ) {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            this.GetComponent<SpriteRenderer>().sprite = left;
        }
	}
}
