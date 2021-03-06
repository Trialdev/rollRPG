﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


/// <summary>
/// This is an object that can be interacted with, these are to be placed in rooms. These are things like enemies, doors, objects, etc. 
/// </summary>


public abstract class RoomObject : MonoBehaviour {
    [SerializeField]
    public string ButtonText;
    public abstract void Interact();
     
	
}
