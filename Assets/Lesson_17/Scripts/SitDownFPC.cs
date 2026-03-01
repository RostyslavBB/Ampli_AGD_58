using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitDownFPC : MonoBehaviour
{
    private CharacterController character;
    private float startHeight;

    void Start()
    {
        character = GetComponent<CharacterController>();
        startHeight = character.height;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (character.height == startHeight)
                character.height = startHeight / 2;
            else
                character.height = startHeight;
        }
    }
}
