﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorcontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
        if (Input.GetKey(KeyCode.Space))
        {
            Cursor.visible = true;
        }
    }
}
