using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
	//　スタートボタンを押したら実行する
	public void StartStore()
	{
		SceneManager.LoadScene("ECstore");
	}
}
