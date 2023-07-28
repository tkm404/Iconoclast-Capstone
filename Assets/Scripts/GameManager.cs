using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Leader[] leaders;
    public Faction[] factions;

    public Leader currentLeader;
    public Faction currentFaction;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        if (leaders.Length > 0)
        {
            currentLeader = leaders[0];
        }

        if (factions.Length > 0)
        {
            currentFaction = factions[0];
        }    
    }

    public void SetLeader(Leader leader) 
    {
        currentLeader = leader;
    }

    public void SetFaction(Faction faction)
    {
        currentFaction = faction;
    }
}    
