﻿using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	public GameObject prefab;
	private Button[] buttonArray;
	public static GameObject selected;
	// Use this for initialization
	void Start () {
		buttonArray = GameObject.FindObjectsOfType<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		foreach(Button thisButton in buttonArray){
			thisButton.GetComponent<SpriteRenderer> ().color = Color.black;
		}
		GetComponent<SpriteRenderer> ().color = Color.white;
		selected = prefab;	}
}
