using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int scoreval;
    Text score;
    public GameObject player;
    Scene m_Scene;
    string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
        score = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        scoreval = player.GetComponent<Coldetection>().score;
        score.text = "Score: " + scoreval;
        if (scoreval >= 16 && sceneName == "Level One")
        {
            SceneManager.LoadScene(sceneName: "Level Two");
        }
        if (scoreval >= 40 && sceneName == "Level Two")
        {
            SceneManager.LoadScene(sceneName: "Level One");
        }
    }
}
