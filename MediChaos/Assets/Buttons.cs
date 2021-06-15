using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Button Yes;
    public Button No;

    private static bool Choice;

    void Start()
    {
        InitialiseButtons();




    }

    void InitialiseButtons()
    {
        Button YesButton = Yes.GetComponent<Button>();
        YesButton.onClick.AddListener(TriggeredYesButton);

        Button NoButton = No.GetComponent<Button>();
        NoButton.onClick.AddListener(TriggeredNoButton);




    }
    void TriggeredNoButton()
    {
        Choice = true;
        

    }
    void TriggeredYesButton()
    {
        Choice = true;
        

    }


















}
