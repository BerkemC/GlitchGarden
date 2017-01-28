using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	public AudioClip[] musicChange; 
	private AudioSource  music;
	// Use this for initialization
	void Awake(){
		DontDestroyOnLoad (gameObject);	
	}
	void Start () {
		music = GetComponent<AudioSource> ();
		music.clip = musicChange [0];
		music.Play ();
	}
	void OnLevelWasLoaded(int level){

		if (level == 1){
			music.Stop ();
			music.clip = musicChange [1]; 
			music.loop = true;
			music.Play ();
		}
		else if(level != 2){
			music.Stop ();
			music.clip = musicChange [level-1]; 
			music.loop = true;
			music.Play ();
		}

	}
}
