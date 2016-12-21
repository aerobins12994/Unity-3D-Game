using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {
    public Button replayB;

	// Use this for initialization
	void Start () {
        replayB.onClick.AddListener(() =>
        {
            SceneManager.LoadSceneAsync("starMenu");
        });


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
