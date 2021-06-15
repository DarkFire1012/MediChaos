using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChoicePath : MonoBehaviour
{
    public SceneManager SCN;
    public Scene CurrSCN;
    public Scene NextSCN;

    void Awake()
    {
        CurrSCN = SceneManager.GetActiveScene();
        Debug.Log(SceneManager.GetActiveScene().name);
        //NextSCN = SceneManager.GetSceneAt(SceneManager.sce)
        //Debug.Log(SceneManager.GetActiveScene().name);
        


    }

    void Start()
    {



    }





}
