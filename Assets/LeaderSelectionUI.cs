using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LeaderSelectionUI : MonoBehaviour
{
    public GameObject optionPrefab;

    public Transform prevLeader;
    public Transform selectedLeader;

    private void Start()
    {
        foreach (Leader d in GameManager.instance.leaders)
        {
            GameObject option = Instantiate(optionPrefab, transform);
            Button button = option.GetComponent<Button>();

            button.onClick.AddListener(() => 
            {
                GameManager.instance.SetLeader(d);
                if (selectedLeader != null)
                {
                    prevLeader = selectedLeader;
                }
                    selectedLeader = option.transform;
            });
            TMP_Text text = option.GetComponentInChildren<TMP_Text>();
            text.text = d.name;

            Image image = option.GetComponentInChildren<Image>();
            image.sprite = d.portrait;
        }
    }

    private void Update()
    {
        if (selectedLeader != null)
        {
            selectedLeader.localScale = Vector3.Lerp(selectedLeader.localScale, new Vector3(1.75f, 1.75f, 1.75f), Time.deltaTime * 10);
        }

        if (prevLeader != null)
        {
            prevLeader.localScale = Vector3.Lerp(prevLeader.localScale, new Vector3(1.5f, 1.5f, 1.5f), Time.deltaTime * 10);
        }
    }
}
