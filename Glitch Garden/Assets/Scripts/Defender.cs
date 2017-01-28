using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour {
	public int starValue;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void AddStars(int starNumber){
		GameObject.FindObjectOfType <StarDisplay>().AddStar (starNumber);
	}
}
