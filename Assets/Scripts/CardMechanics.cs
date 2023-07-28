using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardMechanics : MonoBehaviour
{
    public GameObject Player1BoutZone;
    public GameObject Player2BoutZone;

    public GameObject MatchFeedbackBox;
    public GameObject ScoreboardP1;
    public GameObject ScoreboardP2;
    public GameObject ScoreIndicatorP1;
    public GameObject ScoreIndicatorP2;
    public GameObject BoutsFinishedTab;
    public GameObject BoutIndicator;

    public GameObject p1Card;
    public GameObject p2Card;

    public GameObject BackButton;

    public int BoutsFinished;
    public int BoutsWonP1;
    public int BoutsWonP2;

    public int Pointsp1;
    public int Pointsp2;

    public TMP_Text p1PointsIndicator;
    public TMP_Text p2PointsIndicator;

    void Start()
    {
        MatchFeedbackBox = GameObject.Find("MatchFeedback");
        ScoreboardP1 = GameObject.Find("ScoreboardP1");
        ScoreboardP2 = GameObject.Find("ScoreboardP2");
        ScoreIndicatorP1 = GameObject.Find("ScoreIndicatorP1_1");
        ScoreIndicatorP2 = GameObject.Find("ScoreIndicatorP2_1");
        BoutsFinishedTab = GameObject.Find("BoutsPlayedIndicator");
        BoutIndicator = GameObject.Find("BoutNumber1");
    }

    // Update is called once per frame
    void Update()
    {
        Player1BoutZone = GameObject.Find("Player1BoutZone");
        Player2BoutZone = GameObject.Find("Player2BoutZone");
    }

    public void onClick()
    {   
        // find correct card objects and get their stats:
        GameObject p1Card = Player1BoutZone.transform.GetChild(Player1BoutZone.transform.childCount -1).gameObject;
        GameObject p2Card = Player2BoutZone.transform.GetChild(Player2BoutZone.transform.childCount -1).gameObject;

        CardDisplay p1Stats = p1Card.GetComponent<CardDisplay>();
        CardDisplay p2Stats = p2Card.GetComponent<CardDisplay>();

        var p1PowerConvert = int.Parse(p1Stats.powerText.text);
        var p1DefenseConvert = int.Parse(p1Stats.defenseText.text);
        var p1Type = p1Stats.typeText.text;

        var p2PowerConvert = int.Parse(p2Stats.powerText.text);
        var p2DefenseConvert = int.Parse(p2Stats.defenseText.text);
        var p2Type = p2Stats.typeText.text;


        // find match log and prep to update:
        TMP_Text matchLog = MatchFeedbackBox.GetComponentInChildren<TMP_Text>();




        // type advantage block:
        if (p1Type == "R" && p2Type == "S" || p1Type == "P" && p2Type == "R" || p1Type == "S" && p2Type == "P")
        {
            p1PowerConvert++;
            matchLog.text = matchLog.text + "<br>P1 Boosted Attack to " + p1PowerConvert + "!";

        }
        else if (p2Type == "R" && p1Type == "S" || p2Type == "P" && p1Type =="R" || p2Type == "S" && p1Type == "P")
        {
            p2PowerConvert++;
            matchLog.text = matchLog.text + "<br>P2 Boosted Attack to " + p2PowerConvert + "!";
        }

        if (p1Type == "R" && p2Type == "P" || p1Type =="P" && p2Type == "S" || p1Type == "S" && p2Type == "R")
        {
            p1PowerConvert--;
            matchLog.text = matchLog.text + "<br>P1 Attack Fell to " + p1PowerConvert + "!";
        }
        else if (p2Type == "R" && p1Type == "P" || p2Type =="P" && p1Type == "S" || p2Type == "S" && p1Type == "R")
        {
            p2PowerConvert--;
            matchLog.text = matchLog.text + "<br>P2 Attack Fell to " + p2PowerConvert + "!";
        }


        // Win or Draw block:
        if (p1PowerConvert > p2DefenseConvert && p2PowerConvert > p1DefenseConvert || p1PowerConvert == p2DefenseConvert && p2PowerConvert == p1DefenseConvert)
        {
            matchLog.text = matchLog.text + "<br><br>Draw! Replay this bout!";
        }
        else if (p1PowerConvert > p2DefenseConvert)
        {
            matchLog.text = matchLog.text + "<br><br>P1 Wins this bout!";
            BoutsFinished++;
            BoutsWonP1++;

            if (BoutsFinished == 1)
            {
            GameObject BoutIndicatorOn = Instantiate(BoutIndicator, new Vector2(152,3), Quaternion.identity);
            BoutIndicatorOn.GetComponent<Image>().color = new Color (255, 0, 0);
            BoutIndicatorOn.transform.SetParent(BoutsFinishedTab.transform, false); 
            BoutIndicatorOn.tag = "Indicator";               
            } else if (BoutsFinished == 2)
            {
            GameObject BoutIndicatorOn = Instantiate(BoutIndicator, new Vector2(200,3), Quaternion.identity);
            BoutIndicatorOn.GetComponent<Image>().color = new Color (255, 0, 0);
            BoutIndicatorOn.transform.SetParent(BoutsFinishedTab.transform, false);
            BoutIndicatorOn.tag = "Indicator";                
            } else if (BoutsFinished == 3)
            {
            GameObject BoutIndicatorOn = Instantiate(BoutIndicator, new Vector2(248,3), Quaternion.identity);
            BoutIndicatorOn.GetComponent<Image>().color = new Color (255, 0, 0);
            BoutIndicatorOn.transform.SetParent(BoutsFinishedTab.transform, false);
            BoutIndicatorOn.tag = "Indicator";                   
            } else if (BoutsFinished == 4)
            {
            GameObject BoutIndicatorOn = Instantiate(BoutIndicator, new Vector2(296,3), Quaternion.identity);
            BoutIndicatorOn.GetComponent<Image>().color = new Color (255, 0, 0);
            BoutIndicatorOn.transform.SetParent(BoutsFinishedTab.transform, false);
            BoutIndicatorOn.tag = "Indicator";                 
            } else if (BoutsFinished == 5)
            {
            GameObject BoutIndicatorOn = Instantiate(BoutIndicator, new Vector2(344,3), Quaternion.identity);
            BoutIndicatorOn.GetComponent<Image>().color = new Color (255, 0, 0);
            BoutIndicatorOn.transform.SetParent(BoutsFinishedTab.transform, false);
            BoutIndicatorOn.tag = "Indicator";                 
            }

            if (BoutsWonP1 == 1)
            {
                GameObject P1WinIndicatorOn = Instantiate(ScoreIndicatorP1, new Vector2(0, -86), Quaternion.identity);
                P1WinIndicatorOn.GetComponent<Image>().color = new Color (236, 210, 0);
                P1WinIndicatorOn.transform.SetParent(ScoreboardP1.transform, false);
                P1WinIndicatorOn.tag = "Indicator";
                matchLog.text = matchLog.text + "<br>P1 has won 1 out of 5 bouts!";
            } else if (BoutsWonP1 == 2)
            {
                GameObject P1WinIndicatorOn = Instantiate(ScoreIndicatorP1, new Vector2(0, -152), Quaternion.identity);
                P1WinIndicatorOn.GetComponent<Image>().color = new Color (236, 210, 0);
                P1WinIndicatorOn.transform.SetParent(ScoreboardP1.transform, false);
                P1WinIndicatorOn.tag = "Indicator";                
                matchLog.text = matchLog.text + "<br>P1 has won 2 out of 5 bouts!";
            } else if (BoutsWonP1 == 3)
            {
                GameObject P1WinIndicatorOn = Instantiate(ScoreIndicatorP1, new Vector2(0, -215), Quaternion.identity);
                P1WinIndicatorOn.GetComponent<Image>().color = new Color (236, 210, 0);
                P1WinIndicatorOn.transform.SetParent(ScoreboardP1.transform, false);
                P1WinIndicatorOn.tag = "Indicator";                
                matchLog.text = matchLog.text + "<br>P1 has won 3 out of 5 bouts! <br><br>P1 Wins the Round!";
                Pointsp1 = Pointsp1 + BoutsFinished;
                p1PointsIndicator.text = Pointsp1.ToString();
                BoutsFinished = 0;
                BoutsWonP1 = 0;
                BoutsWonP2 = 0;
                GameObject[] indicators;
                indicators = GameObject.FindGameObjectsWithTag("Indicator");
                foreach (var bI in indicators)
                {
                    Destroy(bI);
                }
            }
        }
        else if (p2PowerConvert > p1DefenseConvert)
        {
            matchLog.text = matchLog.text + "<br><br>P2 Wins this bout!";
            BoutsFinished++;
            BoutsWonP2++;

            if (BoutsFinished == 1)
            {
            GameObject BoutIndicatorOn = Instantiate(BoutIndicator, new Vector2(152,3), Quaternion.identity);
            BoutIndicatorOn.GetComponent<Image>().color = new Color (255, 0, 0);
            BoutIndicatorOn.transform.SetParent(BoutsFinishedTab.transform, false);
            BoutIndicatorOn.tag = "Indicator";                 
            } else if (BoutsFinished == 2)
            {
            GameObject BoutIndicatorOn = Instantiate(BoutIndicator, new Vector2(200,3), Quaternion.identity);
            BoutIndicatorOn.GetComponent<Image>().color = new Color (255, 0, 0);
            BoutIndicatorOn.transform.SetParent(BoutsFinishedTab.transform, false);
            BoutIndicatorOn.tag = "Indicator";               
            } else if (BoutsFinished == 3)
            {
            GameObject BoutIndicatorOn = Instantiate(BoutIndicator, new Vector2(248,3), Quaternion.identity);
            BoutIndicatorOn.GetComponent<Image>().color = new Color (255, 0, 0);
            BoutIndicatorOn.transform.SetParent(BoutsFinishedTab.transform, false);  
            BoutIndicatorOn.tag = "Indicator";                
            } else if (BoutsFinished == 4)
            {
            GameObject BoutIndicatorOn = Instantiate(BoutIndicator, new Vector2(296,3), Quaternion.identity);
            BoutIndicatorOn.GetComponent<Image>().color = new Color (255, 0, 0);
            BoutIndicatorOn.transform.SetParent(BoutsFinishedTab.transform, false); 
            BoutIndicatorOn.tag = "Indicator";               
            } else if (BoutsFinished == 5)
            {
            GameObject BoutIndicatorOn = Instantiate(BoutIndicator, new Vector2(344,3), Quaternion.identity);
            BoutIndicatorOn.GetComponent<Image>().color = new Color (255, 0, 0);
            BoutIndicatorOn.transform.SetParent(BoutsFinishedTab.transform, false); 
            BoutIndicatorOn.tag = "Indicator";               
            }

            if (BoutsWonP2 == 1)
            {
                GameObject P2WinIndicatorOn = Instantiate(ScoreIndicatorP2, new Vector2(0, -86), Quaternion.identity);
                P2WinIndicatorOn.GetComponent<Image>().color = new Color (209, 123, 0);
                P2WinIndicatorOn.transform.SetParent(ScoreboardP2.transform, false);
                P2WinIndicatorOn.tag = "Indicator";
                matchLog.text = matchLog.text + "<br>P2 has won 1 out of 5 bouts!";
            } else if (BoutsWonP2 == 2)
            {
                GameObject P2WinIndicatorOn = Instantiate(ScoreIndicatorP2, new Vector2(0, -152), Quaternion.identity);
                P2WinIndicatorOn.GetComponent<Image>().color = new Color (209, 123, 0);
                P2WinIndicatorOn.transform.SetParent(ScoreboardP2.transform, false);
                P2WinIndicatorOn.tag = "Indicator";
                matchLog.text = matchLog.text + "<br>P2 has won 2 out of 5 bouts!";
            } else if (BoutsWonP2 == 3)
            {
                GameObject P2WinIndicatorOn = Instantiate(ScoreIndicatorP2, new Vector2(0, -215), Quaternion.identity);
                P2WinIndicatorOn.GetComponent<Image>().color = new Color (209, 123, 0);
                P2WinIndicatorOn.transform.SetParent(ScoreboardP2.transform, false);
                P2WinIndicatorOn.tag = "Indicator";                
                matchLog.text = matchLog.text + "<br>P2 has won 3 out of 5 bouts! <br><br>P2 Wins the Round!";
                Pointsp2 = Pointsp2 + BoutsFinished;
                p2PointsIndicator.text = Pointsp2.ToString();
                BoutsFinished = 0;
                BoutsWonP1 = 0;
                BoutsWonP2 = 0;
                GameObject[] indicators;
                indicators = GameObject.FindGameObjectsWithTag("Indicator");
                foreach (var bI in indicators)
                {
                    Destroy(bI);
                }
            }
        }
    }

}
