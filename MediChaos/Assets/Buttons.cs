using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Button Yes;
    public Button No;

    bool Choice = true;
    //bool QComp = true;

    void Start()
    {
        InitialiseButtons();


    }

    void InitialiseButtons()
    {
        Yes.onClick.AddListener(TriggeredYesButton);

        No.onClick.AddListener(TriggeredNoButton);


    }
    void TriggeredNoButton()
    {
        Triggered();

    }
    void TriggeredYesButton()
    {
        Triggered();

    }

    void Triggered()
    {

        gameObject.GetComponent<TextControl>().Choice = true;
        //QComp = true;
        gameObject.GetComponent<TextControl>().ChoiceButtons.SetActive(false);
        gameObject.GetComponent<TextControl>().CompletedQuestion = true;
        gameObject.GetComponent<TextControl>().IsQuestion = false;

    }
















}
