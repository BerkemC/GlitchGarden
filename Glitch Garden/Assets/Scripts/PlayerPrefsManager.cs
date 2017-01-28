using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY ="master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";

	// VOLUME
	public static void SetMasterVolume(float volume){
		if(volume >= 0f && volume <= 1f)
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
	}

	public static float GetMasterVolume(){
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}


	/// lEVEL

	public static void SetLevelUnlock(int level){
		if (level <= Application.levelCount - 1 )PlayerPrefs.SetInt (LEVEL_KEY + level.ToString(), 1);
	}

	public static bool IsLevelUnlock(int level){
		int levelGiven = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString() );
		bool isOkay = (levelGiven == 1);
		if (level <= Application.levelCount - 1)
			return isOkay;
		else
			return false;
	}

	/// DiFFiCULTY
	public static void SetDifficulty(float diff){
		if (diff >= 1f && diff <= 3f)
			PlayerPrefs.SetFloat (DIFFICULTY_KEY, diff);
	}

	public static float GetDifficulty(){
		return PlayerPrefs.GetFloat (DIFFICULTY_KEY);
	}
}
