using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class SubFactionChoiceUI : MonoBehaviour
{
    public GameObject subOptionPrefab;

    public Transform prevFaction;
    public Transform selectedFaction;
    public Transform selectedLeader;

    private void Start() {
        foreach (Faction f in GameManager.instance.factions)
        {
                GameObject subOption = Instantiate(subOptionPrefab, transform);
                Button button = subOption.GetComponent<Button>();

                button.onClick.AddListener(() =>
                {
                    GameManager.instance.SetFaction(f);
                    if (selectedFaction != null)
                    {
                        prevFaction = selectedFaction;
                    }
                        selectedFaction = subOption.transform;
                });
                
        }
    }
}
