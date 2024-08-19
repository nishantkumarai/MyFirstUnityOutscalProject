using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackScene : MonoBehaviour
{
    public Button button;
    public string sceneName;


    private void Start()
    {
        button.onClick.AddListener(OnEnterButton);
    }

    private void OnEnterButton()
    {
        Debug.Log("Enter button");
        SceneManager.LoadScene(sceneName);
    }
}
