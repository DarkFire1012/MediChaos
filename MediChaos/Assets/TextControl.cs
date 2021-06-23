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
    [SerializeField] private string TextToWrite;

    public GameObject NEHRObj;
    public GameObject ChoiceButtons;
    public bool CompletedQuestion = true;
    public bool IsQuestion = false;

    //global 
    public int LineIndex = 0;

    public bool Choice = true;
    public Text SpeechBox;
    public Animator Fader;
    //public Animation Fader;

    
    void Start()
    {
        GetTextFile();
        //ReadAllText();
        WrittenText = TextLines[0];
        //TextToWrite = TextLines[1];
    }
    void LateUpdate()
    {
        SpeechBox.text = WrittenText;

        ClickTrigger();
        QuestionCheck();
        
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
    void SkipEmptyLines()
    {
        //if line empty, proceed next
        if (TextLines[LineIndex].Length == 0)
        {
            LineIndex++;
            SkipEmptyLines();
        }
    }
    void Typewriter()
    {

        SkipEmptyLines();

        LetterIndex++;
        if (LineIndex < TextLines.Length)                   //end of file
        {

            if (LetterIndex > TextToWrite.Length)
            {
                CancelInvoke();
                LetterIndex = 0;

                if (!IsQuestion)
                {
                    LineIndex++;
                    TextToWrite = TextLines[LineIndex];
                }
                else if (IsQuestion)
                {
                    
                    ButtonTrigger();
                }

                TextToWrite = TextLines[LineIndex];

                CompletedLine = true;

            }
            else
            {
                WrittenText = TextToWrite.Substring(0, LetterIndex);

            }
        }
        else
        {
            //end game

        }

    }
    void ClickTrigger()
    {
        if (Input.GetMouseButtonDown(0) && CompletedQuestion) //not a question
        {
            //QuestionCheck();


            if (CompletedLine)// && !IsQuestion)    // if the typing is completed
            {
                CompletedLine = false;
                InvokeRepeating("Typewriter", 0.001f, LetterSpeed);

            }

            else if (!CompletedLine) // && !IsQuestion) //typing not completed.
            {
                LetterIndex = TextToWrite.Length;
                WrittenText = TextToWrite.Substring(0, LetterIndex);

            }

        }
        
        
        if (Input.GetMouseButtonDown(0) && !CompletedQuestion) //is a question
        {
            if (!CompletedLine) //when question is done
            {
                LetterIndex = TextToWrite.Length;
                WrittenText = TextToWrite.Substring(0, LetterIndex);

            }
            if (CompletedLine && Choice)
            {
                CompletedLine = false;
                InvokeRepeating("Typewriter", 0.001f, LetterSpeed);

            } 
            
            
            if (CompletedLine && IsQuestion && TextToWrite.Contains("Question"))
            {
                CompletedLine = false;
                InvokeRepeating("Typewriter", 0.001f, LetterSpeed);

            }
            
        }
        
    }
    void ButtonTrigger()
    {
        //InvokeRepeating("Typewriter", 0.001f, LetterSpeed);
        Choice = false;
        ChoiceButtons.SetActive(true);
    }
    void CallQuestion()
    {
        //Insert fade here

        CompletedQuestion = false;
        IsQuestion = true;
        LetterIndex = 0;
        //ButtonTrigger();
        //Choice = false;
    }
    void QuestionCheck()
    {
        if (CompletedLine && CompletedQuestion && !Choice)
        {
            switch (LineIndex)
            {
                case (5):

                    TextToWrite = "Question 1";
                    CallQuestion();
                    CallNEHR();
                    break;


            }

        }

    }
    void CallNEHR()
    {
        NEHRObj.SetActive(true);
    }

    void VerifyMedication()
    {
        
        //CompletedLine = false;                  //Text line
        //CompletedQuestion = false;              //Question
        //IsQuestion = true;                      //Set if
                                                
        if (!Choice)                            //Choice not made
        {

        }
        else
        {
            //soft reset
            //Choice = false;

        }

    }



}
