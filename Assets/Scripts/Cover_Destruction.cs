﻿using UnityEngine;
using System.Collections;

public class Cover_Destruction : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

}