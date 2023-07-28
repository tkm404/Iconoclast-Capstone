using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leader1Spawner : MonoBehaviour
{
    private void Start()
    {
        Instantiate(GameManager.instance.currentLeader.deckLeader, transform.position, Quaternion.identity);
    }
}
