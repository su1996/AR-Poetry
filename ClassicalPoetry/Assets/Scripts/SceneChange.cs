using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

	public void ReturnShiRenScene()
	{
		SceneManager.LoadScene ("ShiRen");
	}

	public void ReturnShiCiScene()
	{
		SceneManager.LoadScene ("ShiCi");
	}

	public void ReturnSaoMiaoScene()
	{
		SceneManager.LoadScene ("SaoMiaoScene");
	}
}
