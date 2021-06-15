using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class SceneControl : MonoBehaviour
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
        DontDestroyOnLoad(gameObject);



    }

    void PreLoadNextScene()
    {
        SceneManager.LoadSceneAsync(CurrSCN.buildIndex + 1,);



    }

    void SwitchScene()
    {





    }









}
