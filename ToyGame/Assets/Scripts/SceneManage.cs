using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public string sceneName;
    public int numberOfPickupsToChangeScene; 
	
    [SerializeField]
	private PlayerController playerController;

    public void Start()
    {
        Debug.Log(playerController.collectedPickups.ToString()); 
    }

    public void Update()
    {
        if (playerController.collectedPickups == numberOfPickupsToChangeScene)
        {
            LoadScene(sceneName); 
        }
    }

    public void LoadScene(string sceneName)
	{
		
		SceneManager.LoadScene(sceneName);
	}

}
