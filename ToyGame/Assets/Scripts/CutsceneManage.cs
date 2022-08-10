using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneManage : MonoBehaviour
{

    public string sceneName;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
