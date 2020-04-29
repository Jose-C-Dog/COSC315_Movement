using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using UnityEngine;

public class HygieneManager : MonoBehaviour
    //this is what HygieneObjects effect
    //this can go on the player
{
    public int currentHygiene = 0;
    public int HygieneMin = 0;
    public int HygieneMax = 100;
    public int HygieneThreshHold = 50;

    HygieneObjects Needle = new HygieneObjects();

    void Start()
    {
        Needle.Name = "Needle";
        Needle.Value = 25;
        Needle.Description = "A needle!";
       
    }

    void Update()
    {
        Debug.Log(Needle.Name);

    }
}
    //HygieneEffects: if Hygiene = 0, then no effect, if Hygiene is 50-100, divide Karma by 2




  