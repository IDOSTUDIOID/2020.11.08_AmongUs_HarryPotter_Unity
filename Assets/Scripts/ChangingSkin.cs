﻿using UnityEngine;
using System.IO;

public class ChangingSkin : MonoBehaviour
{
    public GameObject[] skin = new GameObject[21];

    private string wearingBool; // 착용 여부
    private int iWearingSkinNum; // 착용 번호 


    void Start()
    {
        wearingBool = "false";
        iWearingSkinNum = 0;

    }
    
    public void skin01Click() { skinMethod(1); }
    public void skin02Click() { skinMethod(2); }
    public void skin03Click() { skinMethod(3); }
    public void skin04Click() { skinMethod(4); }
    public void skin05Click() { skinMethod(5); }
    public void skin06Click() { skinMethod(6); }
    public void skin07Click() { skinMethod(7); }
    public void skin08Click() { skinMethod(8); }
    public void skin09Click() { skinMethod(9); }
    public void skin10Click() { skinMethod(10); }
    public void skin11Click() { skinMethod(11); }
    public void skin12Click() { skinMethod(12); }
    public void skin13Click() { skinMethod(13); }
    public void skin14Click() { skinMethod(14); }
    public void skin15Click() { skinMethod(15); }
    public void skin16Click() { skinMethod(16); }
    public void skin17Click() { skinMethod(17); }
    public void skin18Click() { skinMethod(18); }
    public void skin19Click() { skinMethod(19); }
    public void skin20Click() { skinMethod(20); }
    public void skin21Click() { skinMethod(21); }


    public void skinMethod(int iWearingSkinNumCheck)
    {
        // 무언가 착용 O 
        if (wearingBool.Equals("true"))
        {

            // 해당 번호 착용중 -> 벗음
            if (iWearingSkinNum == iWearingSkinNumCheck)
            {
                Debug.Log(iWearingSkinNum + "벗음");
                wearingBool = "false";
                iWearingSkinNum = 0;
                skin[iWearingSkinNumCheck - 1].SetActive(false);

            }
            else
            {    // 다른 것 착용중 -> 벗음 -> 해당 번호 착용
                 // 그대로 착용중이기에 wearing(true/false)값은 변경하지 않음

                skin[iWearingSkinNum - 1].SetActive(false);
                skin[iWearingSkinNumCheck - 1].SetActive(true);
                Debug.Log(iWearingSkinNum + "벗고" + iWearingSkinNumCheck + "착용");
                iWearingSkinNum = iWearingSkinNumCheck;
            }

        }

        else
        { // 착용 X ->  착용
            Debug.Log(iWearingSkinNumCheck + "착용");
            wearingBool = "true";
            iWearingSkinNum = iWearingSkinNumCheck;
            skin[iWearingSkinNumCheck - 1].SetActive(true);

        }

    } // end

}
