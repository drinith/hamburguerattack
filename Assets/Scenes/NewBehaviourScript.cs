﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioSource gameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        gameOver.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
