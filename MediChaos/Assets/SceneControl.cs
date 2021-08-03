using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class SceneControl : MonoBehaviour
{
    //public SceneManager SCN;
    //public Scene CurrSCN;
    //public Scene NextSCN;

    public Texture Scene1;
    public Texture Scene2;
    public Texture Scene3;
    public Texture Scene4;
    //public Texture Scene5;
    //public Texture Scene6;
    //public Texture Scene7;
    public RawImage Backdrop;
    public List<Texture> Backgrounds;
    public int LineIndex;

    public bool End = false;


    void Awake()
    {

    }

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        Backgrounds.Add(Scene1);
        Backgrounds.Add(Scene2);
        Backgrounds.Add(Scene3);
        Backgrounds.Add(Scene4);
        SwitchScene();
        
    }
    private void Update()
    {
        LineIndex = gameObject.GetComponent<TextControl>().LineIndex;
        SwitchScene();

        if (LineIndex == gameObject.GetComponent<TextControl>().TextLines.Length - 1)
        {
            End = true;
        }
        if (End)
        {
            End = false;
            gameObject.GetComponent<SceneControl>().enabled = false;
            //gameObject.SetActive(false);
            EndGame();

        }
    }

    void EndGame()
    {
        SceneManager.LoadScene("End Screen");
        
    }

    void SwitchScene()
    {
        //Fade VFX


        switch (LineIndex)
        {
            case 0:
                Backdrop.texture = Backgrounds.ElementAt(0);
                break;

            case 15:
                Backdrop.texture = Backgrounds.ElementAt(1);
                break;

            case 29:
                Backdrop.texture = Backgrounds.ElementAt(0);
                break;

                /*     
                 default:
                     Backdrop.texture = Backgrounds.ElementAt(0);
                     break;
                     */
        }



    
    }









}
