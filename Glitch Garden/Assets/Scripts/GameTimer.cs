using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameTimer : MonoBehaviour {
	private Slider slider;
	private float time = 0f;
	public float levelTime = 120f;
	private bool isFinished = false;
	// Use this for initialization
	void Start () {
		slider = GetComponent <Slider> ();
	}
	
	// Update is called once per frame
	void Update () {
		slider.value = time / levelTime;

		time += Time.deltaTime;

		if (slider.value >= 0.99f && isFinished == false) {
			GetComponent <AudioSource> ().Play ();
			isFinished = true;
			Invoke ("LoadWin", GetComponent <AudioSource> ().clip.length);
		}
	}

	void LoadWin(){
		Application.LoadLevel ("Win");
	}
}
