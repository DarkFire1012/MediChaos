using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using UnityEngine.UI;
//using Random as System.Random;

public class TextControl : MonoBehaviour
{
    //local
    [Header("Local Variables")]
    [SerializeField] private string[] TextLines;

    [SerializeField] private int LetterIndex =  0;
    [SerializeField] private bool CompletedLine = true;
    [SerializeField] private float LetterSpeed = 0.1f;
    [SerializeField] private string WrittenText;

    [SerializeField] private bool CompletedQuestion = true;
    [SerializeField] private bool IsQuestion = false;

    //global
    [SerializeField] private static int LineIndex = 0;

    private static bool Choice;
    public Text SpeechBox;
    
    void Start()
    {
        GetTextFile();
        //ReadAllText();
        
    }
    void LateUpdate()
    {
        SpeechBox.text = WrittenText;

        ClickTrigger();
        //QuestionTriggerCheck();

    }
    void GetTextFile()
    {
        //Get Text File

        var fileText = File.ReadAllText("Assets/GameText.txt");
        TextLines = fileText.Split("\n"[0]);

    }
    void ReadAllText()
    {
        //int lineNo = 0;
        foreach (string line in TextLines)
        {
            if (TextLines.Length == 0) Debug.Log("Empty");
            //lineNo++;
            Debug.Log(line);// + lineNo);

        }

    }
    void Typewriter()
    {
        LetterIndex++;
        if (LineIndex < TextLines.Length)
        {
            if (LetterIndex > TextLines[LineIndex].Length)
            {
                CancelInvoke();
                LetterIndex = 0;
                if (!IsQuestion)
                {
                    LineIndex++;
                    CompletedLine = true;
                }
                    
            }
            else
            {
                WrittenText = TextLines[LineIndex].Substring(0, LetterIndex);
            }
        }
        else
        {
            //end game

        }
        //}
        
    }
    void ClickTrigger()
    {
        if (Input.GetMouseButtonDown(0) && CompletedLine)
        {
            CompletedLine = false;
            InvokeRepeating("Typewriter", 0.001f, LetterSpeed);

        }

    }
    /// <summary>
    /// Disabled Chunk Shifted to scenemanager
    /// </summary>
    /*
    void QuestionTriggerCheck()
    {
        //The part to verify or not
        if (CompletedQuestion)
        {
            //when Text line reaches a certain line, trigger question (verification)
            switch (LineIndex)
            {
                //pretend
                case (15):
                    //CompletedQuestion = false;
                    Debug.Log("trigger1");
                    VerifyMedication();
                    //StartCoroutine("VerifyMedication") ;
                    break;



                default: 
                    ClickTrigger();
                    break;

            }
            //CompletedQuestion = false;

        }
        else
        {


        }

    }
    */

    void VerifyMedication()
    {
        CompletedLine = false;
        CompletedQuestion = false;
        IsQuestion = true;
        //CancelInvoke("Typewriter");
        //Debug.Log(qn);

        //timer 
        
        //Wait for user input
        if (!Choice)
        {
            switch (LineIndex)
            {

                case (15):
                    //Insert Qn here
                    WrittenText = "Test Question";
                    break;


            }
        }
        else
        {
            //soft reset
            Choice = false;

        }

    }



}
