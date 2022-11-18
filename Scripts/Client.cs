using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Client : MonoBehaviour
{
    public GameObject NPC;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //NPC.GetComponent<NPC>().TakeDamage(100);
            NPC.GetComponent<NumberOfHitsHealth>().TakeDamage(100);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }
}
