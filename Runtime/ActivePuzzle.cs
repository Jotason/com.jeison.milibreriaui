using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePuzzle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]GameObject activeObject;

    PlayerControlle player;
    void Start()
    {
        player = FindFirstObjectByType<PlayerControlle>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.PuzzleImage == true) { 
            //activeObject.SetActive(true);
        }

        if (player.PuzzleImage == false)
        {
            //activeObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player")) player.PuzzleImage = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("Player")) player.PuzzleImage = false;

    }
}
