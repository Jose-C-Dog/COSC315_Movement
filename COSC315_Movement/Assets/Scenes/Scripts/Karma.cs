using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karma: MonoBehaviour
{
    //current Karma
    int KarmaTotal;
    //Karma Gauge
    int KarmaMin;
    int KarmaMax;
    int GoodKarmaLevel;
    int NeutralKarmaLevel;
    int BadKarmaLevel;
    //KarmaRating
    string GoodKarma;
    string NeutralKarma;
    string BadKarma;

    //KarmaEffects
    //KarmaTotal is halved if Hygiene is below 50
    //KarmaTotal is normal if Hygiene is above 50


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
