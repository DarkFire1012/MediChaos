using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System.Linq;

public class Results : MonoBehaviour
{
    public string[] ResultArray;
    public List<Text> TextBoxes;

    public Text Score;

    public Text Result0;
    public Text Result1;
    public Text Result2;
    public Text Result3;
    public Text Result4;
    public Text Result5;
    public Text Result6;
    public GameObject Player;

    public List<Text> ResultText;
    void Start()
    {

        //GetTextFile();
        //GetTextBoxes();
        //UpdateResults();
        Player = GameObject.Find("Player (Indest)");
        ResultArray = Player.GetComponent<Buttons>().ResultArray;
        SetupTextBox();
        ResultUpdateNew();
        DisableScript();
    }
    void DisableScript()
    {
        Player.GetComponent<TextControl>().enabled = false;
    }
    void SetupTextBox()
    {
        ResultText.Add(Result0);
        ResultText.Add(Result1);
        ResultText.Add(Result2);
        ResultText.Add(Result3);
        ResultText.Add(Result4);
        ResultText.Add(Result5);
        ResultText.Add(Result6);
    }
    void GetTextFile()
    {
        //Get Text File

        var ResultTxt = File.ReadAllText("Assets/Results.txt");
        ResultArray = ResultTxt.Split("\n"[0]);

    }
    void GetTextBoxes()
    {
        TextBoxes = GameObject.FindObjectsOfType<Text>().ToList();
        //TextBoxes.Sort();

        foreach (Text Box in TextBoxes)
        {
            if (!Box.name.Contains("Result"))
            {
                TextBoxes.Remove(Box);
                Debug.Log("removed " + Box);
            }

        }

    }
    void UpdateResults()
    {
        for (int i = 1; i < ResultArray.Length; i++)
        {
            TextBoxes.ElementAt(i).text = "" + ResultArray.ElementAt(i);

        }

    }
    void ResultUpdateNew()
    {
        //Result0.text = "Scenario 1: Option was " + ResultArray.ElementAt(0);
        //Result1.text = "Scenario 2: Option was " + ResultArray.ElementAt(1);
        //Result2.text = "Scenario 3: Option was " + ResultArray.ElementAt(2);
        //Result3.text = "Scenario 4: Option was " + ResultArray.ElementAt(3);
        //Result4.text = "Scenario 5: Option was " + ResultArray.ElementAt(4);
        //Result5.text = "Scenario 6: Option was " + ResultArray.ElementAt(6);

        for (int i = 0; i < ResultArray.Length; i++)
        {
            if (ResultArray[i] != "")
            {
                ResultText.ElementAt(i + 1).text = "Scenario " + (i + 1) + ": Option was " + ResultArray[i];
            }
            else
            {
                //Debug.Log(i);
                break;
            }


        }

    }

    void Update()
    {
        
    }
}
