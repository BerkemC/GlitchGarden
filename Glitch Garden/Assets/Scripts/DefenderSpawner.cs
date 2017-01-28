using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {
	private StarDisplay stars;
	// Use this for initialization
	void Start () {
		stars = GameObject.FindObjectOfType<StarDisplay> ();
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnMouseDown(){
		int starNumber = Button.selected.GetComponent <Defender>().starValue;
		if(CheckIfThereIsDefender ()) {
			if(Button.selected) {
				if(stars.ReduceStar (starNumber)) {
					GameObject newSpawn = Instantiate (Button.selected, CalculateLocationToPut (), Quaternion.identity) as GameObject; 
					newSpawn.transform.parent = GameObject.Find ("Defenders").transform;
				}
			}
		}
	}

	Vector2 CalculateLocationToPut(){
		int x, y;
		Vector3 temp = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		x = (int)(temp.x + 0.5f);
		y = (int)(temp.y + 0.5f);

		return new Vector2 (x, y);
	}
	bool CheckIfThereIsDefender(){
		foreach(Transform child in GameObject.Find("Defenders").transform){
			if(new Vector2(child.transform.position.x,child.transform.position.y) == CalculateLocationToPut ()){
				return false;
			}
		}
		return true;
	}
}
