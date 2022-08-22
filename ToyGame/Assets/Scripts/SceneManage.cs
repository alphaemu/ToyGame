using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public string sceneName;
    public int numberOfPickupsToChangeScene;
    public GameObject levelButton;
    bool levelCompletion;
	
    [SerializeField]
	private PlayerController playerController;

    public void Start()
    {
        Debug.Log(playerController.collectedPickups.ToString());
        levelButton.SetActive(false);
        levelCompletion = false;
        
        
    }

    public void Update()
    {
        if (playerController.collectedPickups == numberOfPickupsToChangeScene)
        {
            levelButton.SetActive(true);
            levelCompletion = true;
        }

        // if 'Q' pressed && levelCompletion == true, load scene

        if (Input.GetKeyDown(KeyCode.Q) && levelCompletion == true)
        {
            LoadScene(sceneName);
        }
    }

    public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}

}
