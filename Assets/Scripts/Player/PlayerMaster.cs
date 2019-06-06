using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMaster : MonoBehaviour
{
    public Slider healthSlider;
    public baseCharacter baseClass {get; set;}
    public GameObject[] oppositeTeamObjects { get => GameObject.FindGameObjectsWithTag(GetEnemyTag(tag)); }

    public PlayerMaster()
    {
        Start();
    }
    // Start is called before the first frame update
    public void Start()
    {
        baseClass = new baseWarriorClass(GetComponent<Rigidbody>(), this);
    }

    // Update is called once per frame
    void Update()
    {
        baseClass.Update();
        updateUI();
    }

    public float getCurrentHealth()
    {
        return baseClass.playerHealth.currentHealth;
    }

    //======================
    //UI UPDATE FUNCTIONS
    //======================
    void updateUI()
    {
        updateHealthUI();
    }

    void updateHealthUI()
    {
        healthSlider.value = getCurrentHealth();
    }

    protected string GetEnemyTag(string tag)
    {
        return tag == "RedTeam" ? "BlueTeam" : "RedTeam";
    }
}
