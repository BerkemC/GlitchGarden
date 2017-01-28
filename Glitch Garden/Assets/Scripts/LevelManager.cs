using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public bool AutoLoad = false;
	public float time = 2.5f;
	public void LoadLevel(string name){
		Application.LoadLevel(name);
	}
	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	public void LoadSameLevel(){
		Application.LoadLevel(Application.loadedLevel -1);
	}
	public void Exit(){
		Application.Quit();
	}
	void autoLoad(){
		time -= Time.deltaTime;
		if(time <= 0f) LoadNextLevel();
	}

	void Update(){
		if (AutoLoad){
			autoLoad();
		}
	}
}
