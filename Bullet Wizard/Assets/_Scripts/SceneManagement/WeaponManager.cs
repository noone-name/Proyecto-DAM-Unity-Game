using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
public class WeaponManager : MonoBehaviour
{
    public SpriteRenderer sr;
    public List<Sprite> weapons = new List<Sprite>();

    private int selectedWeapon = 0;

    private GameObject weaponSkin;

    public GameObject RadioOptions;

    private RadioButtonsSystem script;


    private void Start()
    {
        script = RadioOptions.GetComponent<RadioButtonsSystem>();

    }

    public void NextOption()
    {
        selectedWeapon = selectedWeapon + 1;
        if (selectedWeapon == weapons.Count)
        {
            selectedWeapon = 0;
        }
        sr.sprite = weapons[selectedWeapon];
    }

    public void BackOption()
    {
        selectedWeapon = selectedWeapon - 1;
        if (selectedWeapon < 0)
        {
            selectedWeapon = weapons.Count - 1;
        }
        sr.sprite = weapons[selectedWeapon];
    }

    public void StartGame()
    {
        string dificultad = script.StartGame();


        if (dificultad == "Easy")
        {
            if (weapons[selectedWeapon].name == "assault_rifle")
            {
                SceneManager.LoadScene("GameScene_assault_rifle_easy");
            }
            else
            {
                SceneManager.LoadScene("GameScene_shotgun_easy");
            }

        }
        else
        {
            if (dificultad == "Hard")
            {
                if (weapons[selectedWeapon].name == "assault_rifle")
                {
                    SceneManager.LoadScene("GameScene_assault_rifle_hard");
                }
                else
                {
                    SceneManager.LoadScene("GameScene_shotgun_hard");
                }
            }

        }

    }

}
