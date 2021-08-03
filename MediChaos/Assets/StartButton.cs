using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{

    private Button self;
    // Start is called before the first frame update
    void Start()
    {
        self = gameObject.GetComponent<Button>();
        self.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

}
