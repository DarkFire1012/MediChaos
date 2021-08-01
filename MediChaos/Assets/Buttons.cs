using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Buttons : MonoBehaviour
{
    public Button Yes;
    public Button No;
    public List<bool> ChoiceList;
    public GameObject NEHRObj;

    bool Choice = true;
    //bool QComp = true;
    public int QuestionNumber = 0;
    public int[] CorrectAnswer = {1, 0, 0, 0, 1, 1};                         //0 for false, 1 for true

    public string[] ResultArray;        //= new string[10];

    //public TextControl txscript;

    void Start()
    {
        InitialiseButtons();
        //GetTextFile();
    }
    void GetTextFile()
    {
        //Get Text File

        var ResultTxt = File.ReadAllText("Assets/Results.txt");
        //ResultArray = ResultTxt.Split("\n"[0]);

    }


    void InitialiseButtons()
    {
        Yes.onClick.AddListener(TriggeredYesButton);

        No.onClick.AddListener(TriggeredNoButton);
        
    }
    void TriggeredNoButton()
    {
        Triggered();
        CompareResult(0);
        CheckEnd();
    }
    void TriggeredYesButton()
    {
        Triggered();
        CompareResult(1);
        CheckEnd();
    }
    void CheckEnd()
    {
        if (gameObject.GetComponent<TextControl>().LineIndex == gameObject.GetComponent<TextControl>().TextLines.Length)
        {
            //File.WriteAllLines("Assets/Results.txt", ResultArray);

        }
        else
        {
            QuestionNumber++;
        }

    }

    void CompareResult(int answer)
    {
        //Debug.Log(answer);
        if (answer == CorrectAnswer[QuestionNumber])
        {
            //Debug.Log(ResultArray[QuestionNumber]);
            //Debug.Log(ResultArray.Length);
            ResultArray[QuestionNumber] = "Correct";
        }
        else
        {
            ResultArray[QuestionNumber] = "Wrong";
        }

    }

    void Triggered()
    {

        gameObject.GetComponent<TextControl>().Choice = true;
        //QComp = true;
        gameObject.GetComponent<TextControl>().ChoiceButtons.SetActive(false);
        gameObject.GetComponent<TextControl>().CompletedQuestion = true;
        gameObject.GetComponent<TextControl>().IsQuestion = false;
        gameObject.GetComponent<TextControl>().WrittenText = "";
        NEHRObj.SetActive(false);




    }
















}
