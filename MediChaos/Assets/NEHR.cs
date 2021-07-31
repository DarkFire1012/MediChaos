using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class NEHR : MonoBehaviour
{
    public RawImage NEHRImage;
    public List<Texture> NEHRScreens;
    public bool Enabled = false;


    public Texture Screen1;
    public Texture Screen2;
    public Texture Screen3;
    public Texture Screen4;
    public Texture Screen5;
    public Texture Screen6;
    public Texture Screen7;
    public Texture Screen8;
    public Texture Screen9;
    public Texture Screen10;
    public Texture Screen11;
    public Texture Screen12;
    public Texture Screen13;
    public Texture Screen14;
    public Texture Screen15;
    public Texture Screen16;
    public Texture Screen17;
    public Texture Screen18;
    public Texture Screen19;
    public Texture Screen20;
    public Texture Screen21;

    public int Min = 0;
    public int Max = 0;
    public int Page = 1;
    public RangeAttribute PageRange;

    public Button Prev;
    public Button Next;
    public bool[] ChoiceList;

    bool Choice = true;
    //bool QComp = true;

    void Awake()
    {

    }
    void Start()
    {
        InitialiseButtons();
        Min = 0;
        Max = 3;
        PageRange = new RangeAttribute(Min, Max);

        NEHRScreens.Add(Screen1);
        NEHRScreens.Add(Screen2);
        NEHRScreens.Add(Screen3);
        NEHRScreens.Add(Screen4);
        NEHRScreens.Add(Screen5);
        NEHRScreens.Add(Screen6);
        NEHRScreens.Add(Screen7);
        NEHRScreens.Add(Screen8);
        NEHRScreens.Add(Screen9);
        NEHRScreens.Add(Screen10);
        NEHRScreens.Add(Screen11);
        NEHRScreens.Add(Screen12);
        NEHRScreens.Add(Screen13);
        NEHRScreens.Add(Screen14);
        NEHRScreens.Add(Screen15);
        NEHRScreens.Add(Screen16);
        NEHRScreens.Add(Screen17);
        NEHRScreens.Add(Screen18);
        NEHRScreens.Add(Screen19);
        NEHRScreens.Add(Screen20);
        NEHRScreens.Add(Screen21);
        SwitchScene();

    }

    
    private void Update()
    {
        //LineIndex = gameObject.GetComponent<TextControl>().IsQuestion
        SwitchScene();

    }
    void SetupArray()
    {

        ChoiceList[0] = true;



    }

    void InitialiseButtons()
    {
        Prev.onClick.AddListener(TriggeredPrev);

        Next.onClick.AddListener(TriggeredNext);

    }
    void TriggeredPrev()
    {
        Page--;

    }
    void TriggeredNext()
    {
        Page++;

    }
    void SetRange()
    {
        PageRange = new RangeAttribute(Min, Max);

    }

    void SwitchScene()
    {
        if (Page < Min)
        {
            Page = Min;
        }
        else if (Page > Max)
        {
            Page = Max;
        }


        switch (Page)
        {
            case 0:
                NEHRImage.texture = NEHRScreens.ElementAt(0);
                break;

            case 1:
                NEHRImage.texture = NEHRScreens.ElementAt(1);
                break;

            case 2:
                NEHRImage.texture = NEHRScreens.ElementAt(2);
                break;

            case 3:
                NEHRImage.texture = NEHRScreens.ElementAt(3);
                break;



            case 4:
                NEHRImage.texture = NEHRScreens.ElementAt(4);
                break;

            case 5:
                NEHRImage.texture = NEHRScreens.ElementAt(5);
                break;

            case 6:
                NEHRImage.texture = NEHRScreens.ElementAt(6);
                break;

            case 7:
                NEHRImage.texture = NEHRScreens.ElementAt(7);
                break;
                
            case 8:
                NEHRImage.texture = NEHRScreens.ElementAt(8);
                break;
                
            case 9:
                NEHRImage.texture = NEHRScreens.ElementAt(9);
                break;
                
            case 10:
                NEHRImage.texture = NEHRScreens.ElementAt(10);
                break;



        }




    }




}
