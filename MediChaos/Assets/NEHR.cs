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

    //public Texture Scene4;
    //public Texture Scene5;
    //public Texture Scene6;
    //public Texture Scene7;

    public int Min;
    public int Max;
    public int Page = 1;
    RangeAttribute PageRange;

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

        PageRange = new RangeAttribute(0,2);

        NEHRScreens.Add(Screen1);
        NEHRScreens.Add(Screen2);
        NEHRScreens.Add(Screen3);
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
            case 1:
                NEHRImage.texture = NEHRScreens.ElementAt(1);
                break;

            case 2:
                NEHRImage.texture = NEHRScreens.ElementAt(2);
                break;


            default:
                NEHRImage.texture = NEHRScreens.ElementAt(0);
                break;

        }




    }




}
