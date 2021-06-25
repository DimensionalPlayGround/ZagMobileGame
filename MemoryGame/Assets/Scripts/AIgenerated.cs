using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIgenerated : MonoBehaviour
{
    string StartingDot = "";
    int InstructionCount = 5;
    public string[] Instruction;

    private void Awake()
    {
        Instruction = new string[5];
        int randnum = Random.Range(0, 9);
        switch(randnum)
        {
            case 0:
                StartingDot = "Dot01";
                break;
            case 1:
                StartingDot = "Dot02";
                break;
            case 2:
                StartingDot = "Dot03";
                break;
            case 3:
                StartingDot = "Dot04";
                break;
            case 4:
                StartingDot = "Dot05";
                break;
            case 5:
                StartingDot = "Dot06";
                break;
            case 6:
                StartingDot = "Dot07";
                break;
            case 7:
                StartingDot = "Dot08";
                break;
            case 8:
                StartingDot = "Dot09";
                break;
            default:
                StartingDot = "Dot01";
                break;
        }
        for (int i = 0; i < InstructionCount; i++)
        {
            
            switch(StartingDot)
            {
                case "Dot01":
                    int randnum1 = Random.Range(0, 5);
                    switch(randnum1)
                    {
                        case 0:
                            StartingDot = "Dot02";
                            Instruction[i] = "Dot01_Dot02";
                            break;
                        case 1:
                            StartingDot = "Dot04";
                            Instruction[i] = "Dot01_Dot04";
                            break;
                        case 2:
                            StartingDot = "Dot05";
                            Instruction[i] = "Dot01_Dot05";
                            break;
                        case 3:
                            StartingDot = "Dot06";
                            Instruction[i] = "Dot01_Dot06";
                            break;
                        case 4:
                            StartingDot = "Dot08";
                            Instruction[i] = "Dot01_Dot08";
                            break;
                    }
                    break;
                case "Dot02":
                    int randnum2 = Random.Range(0, 7);
                    switch (randnum2)
                    {
                        case 0:
                            StartingDot = "Dot01";
                            Instruction[i] = "Dot02_Dot01";
                            break;
                        case 1:
                            StartingDot = "Dot03";
                            Instruction[i] = "Dot02_Dot03";
                            break;
                        case 2:
                            StartingDot = "Dot04";
                            Instruction[i] = "Dot02_Dot04";
                            break;
                        case 3:
                            StartingDot = "Dot05";
                            Instruction[i] = "Dot02_Dot05";
                            break;
                        case 4:
                            StartingDot = "Dot06";
                            Instruction[i] = "Dot02_Dot06";
                            break;
                        case 5:
                            StartingDot = "Dot07";
                            Instruction[i] = "Dot02_Dot07";
                            break;
                        case 6:
                            StartingDot = "Dot09";
                            Instruction[i] = "Dot02_Dot09";
                            break;
                    }
                    break;
                case "Dot03":
                    int randnum3 = Random.Range(0, 5);
                    switch (randnum3)
                    {
                        case 0:
                            StartingDot = "Dot02";
                            Instruction[i] = "Dot03_Dot02";
                            break;
                        case 1:
                            StartingDot = "Dot04";
                            Instruction[i] = "Dot03_Dot04";
                            break;
                        case 2:
                            StartingDot = "Dot05";
                            Instruction[i] = "Dot03_Dot05";
                            break;
                        case 3:
                            StartingDot = "Dot06";
                            Instruction[i] = "Dot03_Dot06";
                            break;
                        case 4:
                            StartingDot = "Dot08";
                            Instruction[i] = "Dot03_Dot08";
                            break;
                    }
                    break;
                case "Dot04":
                    int randnum4 = Random.Range(0, 7);
                    switch (randnum4)
                    {
                        case 0:
                            StartingDot = "Dot01";
                            Instruction[i] = "Dot04_Dot01";
                            break;
                        case 1:
                            StartingDot = "Dot02";
                            Instruction[i] = "Dot04_Dot02";
                            break;
                        case 2:
                            StartingDot = "Dot03";
                            Instruction[i] = "Dot04_Dot03";
                            break;
                        case 3:
                            StartingDot = "Dot05";
                            Instruction[i] = "Dot04_Dot05";
                            break;
                        case 4:
                            StartingDot = "Dot07";
                            Instruction[i] = "Dot04_Dot07";
                            break;
                        case 5:
                            StartingDot = "Dot08";
                            Instruction[i] = "Dot04_Dot08";
                            break;
                        case 6:
                            StartingDot = "Dot09";
                            Instruction[i] = "Dot04_Dot09";
                            break;
                    }
                    break;
                case "Dot05":
                    int randnum6 = Random.Range(0, 8);
                    switch (randnum6)
                    {
                        case 0:
                            StartingDot = "Dot01";
                            Instruction[i] = "Dot05_Dot01";
                            break;
                        case 1:
                            StartingDot = "Dot02";
                            Instruction[i] = "Dot05_Dot02";
                            break;
                        case 2:
                            StartingDot = "Dot03";
                            Instruction[i] = "Dot05_Dot03";
                            break;
                        case 3:
                            StartingDot = "Dot04";
                            Instruction[i] = "Dot05_Dot04";
                            break;
                        case 4:
                            StartingDot = "Dot06";
                            Instruction[i] = "Dot05_Dot06";
                            break;
                        case 5:
                            StartingDot = "Dot07";
                            Instruction[i] = "Dot05_Dot07";
                            break;
                        case 6:
                            StartingDot = "Dot08";
                            Instruction[i] = "Dot05_Dot08";
                            break;
                        case 7:
                            StartingDot = "Dot09";
                            Instruction[i] = "Dot05_Dot09";
                            break;
                    }
                    break;
                case "Dot06":
                    int randnum5 = Random.Range(0, 7);
                    switch (randnum5)
                    {
                        case 0:
                            StartingDot = "Dot01";
                            Instruction[i] = "Dot06_Dot01";
                            break;
                        case 1:
                            StartingDot = "Dot02";
                            Instruction[i] = "Dot06_Dot02";
                            break;
                        case 2:
                            StartingDot = "Dot03";
                            Instruction[i] = "Dot06_Dot03";
                            break;
                        case 3:
                            StartingDot = "Dot05";
                            Instruction[i] = "Dot06_Dot05";
                            break;
                        case 4:
                            StartingDot = "Dot07";
                            Instruction[i] = "Dot06_Dot07";
                            break;
                        case 5:
                            StartingDot = "Dot08";
                            Instruction[i] = "Dot06_Dot08";
                            break;
                        case 6:
                            StartingDot = "Dot09";
                            Instruction[i] = "Dot06_Dot09";
                            break;
                    }
                    break;
                case "Dot07":
                    int randnum7 = Random.Range(0, 5);
                    switch (randnum7)
                    {
                        case 0:
                            StartingDot = "Dot02";
                            Instruction[i] = "Dot07_Dot02";
                            break;
                        case 1:
                            StartingDot = "Dot04";
                            Instruction[i] = "Dot07_Dot04";
                            break;
                        case 2:
                            StartingDot = "Dot05";
                            Instruction[i] = "Dot07_Dot05";
                            break;
                        case 3:
                            StartingDot = "Dot06";
                            Instruction[i] = "Dot07_Dot06";
                            break;
                        case 4:
                            StartingDot = "Dot08";
                            Instruction[i] = "Dot07_Dot08";
                            break;
                    }
                    break;
                case "Dot08":
                    int randnum8 = Random.Range(0, 7);
                    switch (randnum8)
                    {
                        case 0:
                            StartingDot = "Dot01";
                            Instruction[i] = "Dot08_Dot01";
                            break;
                        case 1:
                            StartingDot = "Dot03";
                            Instruction[i] = "Dot08_Dot03";
                            break;
                        case 2:
                            StartingDot = "Dot04";
                            Instruction[i] = "Dot08_Dot04";
                            break;
                        case 3:
                            StartingDot = "Dot05";
                            Instruction[i] = "Dot08_Dot05";
                            break;
                        case 4:
                            StartingDot = "Dot06";
                            Instruction[i] = "Dot08_Dot06";
                            break;
                        case 5:
                            StartingDot = "Dot07";
                            Instruction[i] = "Dot08_Dot07";
                            break;
                        case 6:
                            StartingDot = "Dot09";
                            Instruction[i] = "Dot08_Dot09";
                            break;
                    }
                    break;
                case "Dot09":
                    int randnum9 = Random.Range(0, 5);
                    switch (randnum9)
                    {
                        case 0:
                            StartingDot = "Dot02";
                            Instruction[i] = "Dot09_Dot02";
                            break;
                        case 1:
                            StartingDot = "Dot04";
                            Instruction[i] = "Dot09_Dot04";
                            break;
                        case 2:
                            StartingDot = "Dot05";
                            Instruction[i] = "Dot09_Dot05";
                            break;
                        case 3:
                            StartingDot = "Dot06";
                            Instruction[i] = "Dot09_Dot06";
                            break;
                        case 4:
                            StartingDot = "Dot08";
                            Instruction[i] = "Dot09_Dot08";
                            break;
                    }
                    break;
            }
        }
        for (int u = 0; u < InstructionCount; u++)
        {
            print(Instruction[u]);
        }
        }
}
