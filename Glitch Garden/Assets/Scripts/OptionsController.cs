using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class OptionsController : MonoBehaviour {

	public Slider volumeSlider, difficultySlider;
	private LevelManager levelManager;
	private MusicPlayer music;
	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
		music = GameObject.FindObjectOfType<MusicPlayer> ();
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume ();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty ();
	}
	
	// Update is called once per frame
	void Update () {
		music.GetComponent<AudioSource> ().volume = volumeSlider.value;
	}
	public void SaveAndExit(){
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		PlayerPrefsManager.SetDifficulty (difficultySlider.value);
		levelManager.LoadLevel ("Menu");
	}
	public void SetDefault(){
		volumeSlider.value = 0.7f;
		difficultySlider.value = 2f;
	}
}
