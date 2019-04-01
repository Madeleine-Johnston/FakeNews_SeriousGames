using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//This class is used by any of the UI elements to run methods
public class UIControl : MonoBehaviour 
{
	public AudioSource myClip;

	//Quits the app
	public void ChangeToOutro()
	{
		SceneManager.LoadScene("Outro");
	}

	public void ChangeToGameSceneStarts()
	{
		Invoke("ChangeToGameScene", 1.3f);
	}

	//Changes scene
	public void ChangeToGameScene()
	{
		SceneManager.LoadScene("02");				
	}
	public void ChangeToMenuStarts()
	{
		Invoke("ChangeToMenu", 1.3f);
	}

	//Changes scene
	public void ChangeToMenu()
	{
		SceneManager.LoadScene("01");				
	}

}
