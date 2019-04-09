using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Artist_Stuff : MonoBehaviour
{
    public int startAwakeness = 100;
    public int currentAwakeness;

    bool isSleep;
    bool isDamaged;

    void Awake()
    {
        currentAwakeness = startAwakeness;
    }

    //will need an is sleep checker and sleep func(NPC is asleep and cannont be woken up)

    void Sleep()
    {
        //will add sound later along with a Death state.
    }
}
