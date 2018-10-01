using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chara_Visible : MonoBehaviour
{
    // Use this for initialization

    public GameObject Hero_Image;
    public GameObject Hero_txt;
    public GameObject Hero_btn;
    
    public GameObject Witch_Image;
    public GameObject Witch_txt;
    public GameObject Witch_btn;
    
    public GameObject Math_Image;
    public GameObject Math_txt;
    public GameObject Math_btn;
    
    public GameObject Drunkard_Image;
    public GameObject Drunkard_txt;
    public GameObject Drunkard_btn;

    public GameObject Menu_btn;
    public GameObject Heroes_Wanted_Img;

    public EventManager eventManager; //Holds the chance variables for later
    public ItemDatabase itemDatabase; //Holds the items and characteristics for the player


    //public bool HeroImgOn;
    //public bool HerotxtOn;
    //public bool WitchImgOn;
    //public bool WitchtxtOn;
    //public bool MathImgOn;
    //public bool MathtxtOn;
    //public bool DrunkardImgOn;
    //public bool DrunkardtxtOn;

    void Start()
    {
        Hero_Image = GameObject.Find("Hero_Image");
        Hero_txt = GameObject.Find("Hero_txt");
        Hero_btn = GameObject.Find("Hero_btn");

        Witch_Image = GameObject.Find("Witch_Image");
        Witch_txt = GameObject.Find("Witch_txt");
        Witch_btn = GameObject.Find("Witch_btn");

        Math_Image = GameObject.Find("Math_Image");
        Math_txt = GameObject.Find("Math_txt");
        Math_btn = GameObject.Find("Math_btn");

        Drunkard_Image = GameObject.Find("Drunkard_Image");
        Drunkard_txt = GameObject.Find("Drunkard_txt");
        Drunkard_btn = GameObject.Find("Drunkard_btn");

        Heroes_Wanted_Img = GameObject.Find("Heroes_Wanted_Img");

        CharaSelect();
    }

    public void HeroBtn()
    {
        Hero_Image.SetActive(true);
        Hero_txt.SetActive(true);
        Hero_btn.SetActive(true);


        Witch_Image.SetActive(false);
        Witch_txt.SetActive(false);
        Witch_btn.SetActive(false);


        Math_Image.SetActive(false);
        Math_txt.SetActive(false);
        Math_btn.SetActive(false);


        Drunkard_Image.SetActive(false);
        Drunkard_txt.SetActive(false);
        Drunkard_btn.SetActive(false);

        Heroes_Wanted_Img.SetActive(false);

    }

    public void WitchButton()
    {
        Hero_Image.SetActive(false);
        Hero_txt.SetActive(false);
        Hero_btn.SetActive(false);


        Witch_Image.SetActive(true);
        Witch_txt.SetActive(true);
        Witch_btn.SetActive(true);


        Math_Image.SetActive(false);
        Math_txt.SetActive(false);
        Math_btn.SetActive(false);


        Drunkard_Image.SetActive(false);
        Drunkard_txt.SetActive(false);
        Drunkard_btn.SetActive(false);

        Heroes_Wanted_Img.SetActive(false);
    }

    public void MathBtn()
    {
        Hero_Image.SetActive(false);
        Hero_txt.SetActive(false);
        Hero_btn.SetActive(false);


        Witch_Image.SetActive(false);
        Witch_txt.SetActive(false);
        Witch_btn.SetActive(false);


        Math_Image.SetActive(true);
        Math_txt.SetActive(true);
        Math_btn.SetActive(true);


        Drunkard_Image.SetActive(false);
        Drunkard_txt.SetActive(false);
        Drunkard_btn.SetActive(false);

        Heroes_Wanted_Img.SetActive(false);
    }

    public void DrunkardBtn()
    {
        Hero_Image.SetActive(false);
        Hero_txt.SetActive(false);
        Hero_btn.SetActive(false);


        Witch_Image.SetActive(false);
        Witch_txt.SetActive(false);
        Witch_btn.SetActive(false);


        Math_Image.SetActive(false);
        Math_txt.SetActive(false);
        Math_btn.SetActive(false);


        Drunkard_Image.SetActive(true);
        Drunkard_txt.SetActive(true);
        Drunkard_btn.SetActive(true);

        Heroes_Wanted_Img.SetActive(false);


        eventManager.maxChance = itemDatabase.drunkardHoney;
    }

    public void CharaSelect()
    {
        
    }

    // Update is called once per frame
    // void Update () {

    // }
}
