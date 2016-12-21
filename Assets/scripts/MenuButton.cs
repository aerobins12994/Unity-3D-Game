using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour {

    public Button playB;
   // public Button how2playB;

	// Use this for initialization
	/*void Start() {
        playB.onClick.AddListener(() =>
       {
           //Application.LoadLevel("demoLevel"); //This is obsolete now, they now provide an async way to call this for better performance
           SceneManager.LoadSceneAsync("demoLevel");
       });

        how2playB.onClick.AddListener(() =>
        {
            SceneManager.LoadSceneAsync("how2play");
        });
	}*/
    void startGameBtn()
    {
        SceneManager.LoadSceneAsync("demoLevel");
    }
}