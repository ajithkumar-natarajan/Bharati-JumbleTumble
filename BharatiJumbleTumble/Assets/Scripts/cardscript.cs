using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class cardscript : MonoBehaviour {

	public static GameObject DraggedInstance;
	Vector3 _startPosition;
	Vector3 _offsetToMouse;
	float _zDistanceToCamera;

	bool beingDragged =false;
	Rigidbody2D rigidbody2d;
	Vector3 startpos;
	Vector3 topos;
	Vector3 currentpos;
	public float x,y;
	public bool canmove=true;
	public int unique_id=0;

	//Sprites
	public SpriteRenderer spriterendr;
	public SpriteCode spritecode;
	public Sprite top,bottom;

	//Sound
	AudioSource source;
	AudioClip clip;
		
	// Use this for initialization
	void Start () {
		rigidbody2d = gameObject.GetComponent<Rigidbody2D> ();
		currentpos = topos = gameObject.transform.position;
		source = gameObject.GetComponent<AudioSource> ();
	}

	public void UpdateSubsprite()
	{
		if (unique_id >= 0 && unique_id <= 4 || unique_id == 40) {
			//bottom
			gameObject.GetComponent<SpriteRenderer>().sprite = bottom;
		} else if (unique_id >= 24 && unique_id <= 38 || unique_id == 39 || unique_id == 41) {
			//top
			gameObject.GetComponent<SpriteRenderer>().sprite = top;
		}
		spriterendr.sprite = spritecode.sprite [unique_id];
	}
	
	// Update is called once per frame
	void Update () {
		if(!canmove)
			transform.position = Vector3.Lerp (transform.position, topos, 0.5f);
		if (Vector3.Distance (transform.position, topos) < 0.01f) 
			canmove = true;
	}
	void OnTriggerEnter2D(Collider2D collider)
	{
		//print (collider.name);
		if(collider.tag!="ans")
			topos = currentpos;
	}
	void OnMouseDown()
	{
		currentpos = transform.position;
		startpos = Input.mousePosition;	
		//gameObject.GetComponent<SpriteRenderer>().color = 
	}
	void OnMouseUp()
	{
		Vector3 diff = Input.mousePosition - startpos;
		canmove = false;
		source.Play ();
		if (Mathf.Abs (diff.x) > Mathf.Abs (diff.y)) {
			if (diff.x > 50f) {
				topos = new Vector3 (topos.x + x, topos.y, 1.17f);
			} else if (diff.x < -50f) {
				topos = new Vector3 (topos.x - x, topos.y, 1.17f);
			}
		} else {
			if (diff.y > 50) {
				topos = new Vector3 (topos.x, topos.y + y, 1.17f);
			} else if (diff.y < -50) {
				topos = new Vector3 (topos.x, topos.y - y, 1.17f);
			}
		}
	}

}
