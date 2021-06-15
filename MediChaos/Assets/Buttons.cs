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
        YesButton.onClick.AddListener(TriggeredButton);
        




    }
    void TriggeredButton()
    {
        Choice = true;

    }


















}
