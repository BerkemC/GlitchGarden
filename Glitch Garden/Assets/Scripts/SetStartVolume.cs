using UnityEngine;
using System.Collections;

public class SetStartVolume : MonoBehaviour {
	private MusicPlayer musicPlayer;
	// Use this for initialization
	void Start () {
		musicPlayer = GameObject.FindObjectOfType<MusicPlayer> ();
		float volume = PlayerPrefsManager.GetMasterVolume ();
		musicPlayer.GetComponent<AudioSource> ().volume = volume;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
