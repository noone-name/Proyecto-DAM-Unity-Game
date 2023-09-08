using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
public class RadioButtonsSystem : MonoBehaviour
{
    ToggleGroup toggleGroup;
    private void Start() {
        toggleGroup = GetComponent<ToggleGroup>();
    }

    public string StartGame(){
  
        Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();
        return toggle.name;

        


    }



}
