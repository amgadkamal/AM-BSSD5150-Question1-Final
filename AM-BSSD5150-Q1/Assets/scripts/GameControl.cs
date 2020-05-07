using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Text onetxt,twotxt,threetxt,fourtxt,fivetxt;
    string m_PlayerName;
    private String txt;
    private GameObject bullet;
    private int countt;
    public int mistakes=0;
    
    //positions
    Vector3 armrposition = new Vector3(0,0,0f);
    Vector3 armlposition = new Vector3(6,0,0f);
    Vector3 legrposition = new Vector3(2,-3,0f);
    Vector3 leglposition = new Vector3(4,-3,0f);
    Vector3 headposition = new Vector3(3,5,0f);
    private int mistake;
    
    //parts of human
    [SerializeField]
    private GameObject rarm;
    
    [SerializeField]
    private GameObject larm;
    
    [SerializeField]
    private GameObject head;
    
    [SerializeField]
    private GameObject rleg;
    
    [SerializeField]
    private GameObject lleg;


    void Start()
    //button to submit letter
    { GameObject.FindWithTag("start").GetComponent<Button>().onClick.AddListener(startgame); }
        
    public void Update()
    { 
        //input field with limit 1 character
        GameObject inputFieldGo = GameObject.FindWithTag("input");
        InputField inputFieldCo = inputFieldGo.GetComponent<InputField>();
        inputFieldCo.characterLimit = 1; 
        txt = inputFieldCo.text;
            
        //text fields to view the letters
        GameObject onet= GameObject.FindWithTag("one");
        onetxt = onet.GetComponent<Text>();
           
        GameObject twot = GameObject.FindWithTag("two");
        twotxt= twot.GetComponent<Text>();
        
        GameObject threet = GameObject.FindWithTag("three");
        threetxt = threet.GetComponent<Text>();
        
        GameObject fourt = GameObject.FindWithTag("four");
        fourtxt= fourt.GetComponent<Text>();
        
        GameObject fivet = GameObject.FindWithTag("five"); 
        fivetxt= fivet.GetComponent<Text>(); }


    //view part of body with each wrong letter
    public void SetText()
    {
        mistakes += 1;
        if (mistakes==1) { Instantiate(larm, armrposition, Quaternion.identity); }
        if (mistakes==3) { Instantiate(rarm, armlposition, Quaternion.identity); }
        if (mistakes==5) { Instantiate(lleg, leglposition, Quaternion.identity); }
        if (mistakes==7) { Instantiate(rleg, legrposition, Quaternion.identity); }
        if (mistakes==9) { Instantiate(head, headposition, Quaternion.identity); }

        if (mistakes == 9)
        {
            //lose scene
            SceneManager.LoadScene("lose");
        }
        
    }
    
    
    
//check input with letters of target word 
    public  void startgame()
  {
      if (txt == "w") { onetxt.text = "W";
          countt += 1; }
      else if (txt == "o") { twotxt.text = "O";
          countt += 1; }
      else if (txt == "r") { threetxt.text = "R";
          countt += 1; }
      else if (txt == "l") { fourtxt.text = "L";
          countt += 1; }
      else if (txt == "d") { fivetxt.text = "D";
          countt += 1; }
      else
      {SetText(); }
      
      //win scene
      if (countt > 9)
      { SceneManager.LoadScene("win"); } }}
        
   
    




