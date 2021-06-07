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
        if (CurrSCN.name == "Name")
        {

        }
        if (CurrSCN.name == "Name")
        {

        }
        if (CurrSCN.name == "Name")
        {

        }
        if (CurrSCN.name == "Name")
        {

        }
        if (CurrSCN.name == "Name")
        {

        }


    }

    public Text DialogBox;          //Box
    public int TxtLine;             //Line of Dialog - using a text file
    public int ChrIndex = 0;        //Percentage covererd
    public string ToWrite;
    public float WriteSpeed;

    void DialogUpdater()//string Dialog, int TxtLine)
    {
        if (Input.anyKeyDown)
        {

        }

        int timer = 0;
        if (timer <= 0)
        {


            DialogBox.text = ToWrite.Substring(0, ChrIndex);
        }

    }

    void Section1()
    {






    }





    /*
    public class Section1 : ChoicePath
    {
        void Start(ref Scen)
        {
            if (currSCN)
            {


            }
        }
    }
    public class Section2 : ChoicePath
    {





    }
    public class Section3 : ChoicePath
    {





    }
    public class Section4 : ChoicePath
    {





    }
    public class Section5 : ChoicePath
    {





    }
    */
}
