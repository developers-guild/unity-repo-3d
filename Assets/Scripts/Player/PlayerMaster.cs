using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaster : MonoBehaviour
{

    public baseCharacter baseClass {get; set;}

    // Start is called before the first frame update
    void Start()
    {
        baseClass = new baseWarriorClass();
    }

    // Update is called once per frame
    void Update()
    {
        baseClass.Update();
    }
}
