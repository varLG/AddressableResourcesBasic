using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelObject : MonoBehaviour
{
    [SerializeField] Text textLevel;
    
    void Start()
    {
        textLevel.text = name + " Loaded!";    
    }
}
