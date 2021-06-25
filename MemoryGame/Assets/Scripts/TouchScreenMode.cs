using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScreenMode : MonoBehaviour
{
    // Update is called once per frame
    public AIgenerated AI;
    public string StartingDotAI = "";
    public string EndingDotAI = "";
    bool HasDrawnLine = false;
    int Line_To_Delete = 0; 
    int LineCounter = 0; 
    public GameObject Player;
    public LineRenderer[] Line;
    public GameObject[] Dots;
    bool IsAIGameState = true;
    public bool[] isLineActive;
    public bool isOnelineActive = false;
    bool HasPlaced = false;
    float CloseXAxis = 2;
    float FarXAxis = 4;
    float CloseYAxis = 3;
    float FarYAxis = 6;
    int pp = 0;
    int sec = 3;
    int PlayerCount = 0;
    public GameObject EndCondition;
    public string[] EndingDots;
    public void Awake()
    {
        isLineActive = new bool[9];
       // Dots = new GameObject[9];
        IsAIGameState = true;
        EndingDots = new string[5];
    }

        
    
    IEnumerator WaitAndDrawLine(string end)
    {
        HasDrawnLine = true;
        int i = 0;
        switch (StartingDotAI)
        {
            case "Dot01":
                switch (end)
                {
                    case "Dot02":
                        Vector3[] EndingPos = new Vector3[2];
                        EndingPos[1] = new Vector3(CloseXAxis, 0, 0);
                        Line[0].SetPositions(EndingPos);
                        float segmentDuration = sec / Line[0].positionCount;
                        int pointsCount = Line[0].positionCount;
                        Vector3[] linePoints = new Vector3[pointsCount];
                        for (int pp = 0; pp < pointsCount; pp++)
                        {
                            linePoints[pp] = Line[0].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[0].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints[p];
                            Vector3 endPosition = linePoints[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount; j++)
                                    Line[0].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 0;
                        break;
                    case "Dot04":
                        Vector3[] EndingPos1 = new Vector3[2];
                        EndingPos1[1] = new Vector3(0, -CloseYAxis, 0);
                        Line[0].SetPositions(EndingPos1);

                        float segmentDuration1 = sec / Line[0].positionCount;
                        int pointsCount1 = Line[1].positionCount;
                        Vector3[] linePoints1 = new Vector3[pointsCount1];
                        for (int pp = 0; pp < pointsCount1; pp++)
                        {
                            linePoints1[pp] = Line[0].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[0].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints1[p];
                            Vector3 endPosition = linePoints1[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration1;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount1; j++)
                                    Line[0].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 0;
                        break;
                    case "Dot05":
                        Vector3[] EndingPos2 = new Vector3[2];
                        EndingPos2[1] = new Vector3(CloseXAxis, -CloseYAxis, 0);
                        Line[0].SetPositions(EndingPos2);

                        float segmentDuration2 = sec / Line[0].positionCount;
                        int pointsCount2 = Line[0].positionCount;
                        Vector3[] linePoints2 = new Vector3[pointsCount2];
                        for (int pp = 0; pp < pointsCount2; pp++)
                        {
                            linePoints2[pp] = Line[0].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[0].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints2[p];
                            Vector3 endPosition = linePoints2[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration2;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount2; j++)
                                    Line[0].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 0;
                        break;
                    case "Dot06":
                        Vector3[] EndingPos3 = new Vector3[2];
                        EndingPos3[1] = new Vector3(FarXAxis, -CloseYAxis, 0);
                        Line[0].SetPositions(EndingPos3);

                        float segmentDuration3 = sec / Line[0].positionCount;
                        int pointsCount3 = Line[0].positionCount;
                        Vector3[] linePoints3 = new Vector3[pointsCount3];
                        for (int pp = 0; pp < pointsCount3; pp++)
                        {
                            linePoints3[pp] = Line[0].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[0].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints3[p];
                            Vector3 endPosition = linePoints3[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration3;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount3; j++)
                                    Line[0].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 0;
                        break;
                    case "Dot08":
                        Vector3[] EndingPos4 = new Vector3[2];
                        EndingPos4[1] = new Vector3(CloseXAxis, -FarYAxis, 0);
                        Line[0].SetPositions(EndingPos4);

                        float segmentDuration4 = sec / Line[0].positionCount;
                        int pointsCount4 = Line[0].positionCount;
                        Vector3[] linePoints4 = new Vector3[pointsCount4];
                        for (int pp = 0; pp < pointsCount4; pp++)
                        {
                            linePoints4[pp] = Line[0].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[0].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints4[p];
                            Vector3 endPosition = linePoints4[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration4;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount4; j++)
                                    Line[0].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 0;
                        break;
                    default:
                        //  Line[i].enabled = false;
                        break;
                }
                break;
            case "Dot02":
                switch (end)
                {
                    case "Dot01":
                        Vector3[] EndingPos = new Vector3[2];
                        EndingPos[1] = new Vector3(-CloseXAxis, 0, 0);
                        Line[1].SetPositions(EndingPos);
                        float segmentDuration = sec / Line[1].positionCount;
                        int pointsCount = Line[1].positionCount;
                        Vector3[] linePoints = new Vector3[pointsCount];
                        for (int pp = 0; pp < pointsCount; pp++)
                        {
                            linePoints[pp] = Line[1].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[1].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints[p];
                            Vector3 endPosition = linePoints[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount; j++)
                                    Line[1].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 1;
                        break;
                    case "Dot03":
                        Vector3[] EndingPos2 = new Vector3[2];
                        EndingPos2[1] = new Vector3(CloseXAxis, 0, 0);
                        Line[1].SetPositions(EndingPos2);
                        float segmentDuration2 = sec / Line[1].positionCount;
                        int pointsCount2 = Line[1].positionCount;
                        Vector3[] linePoints2 = new Vector3[pointsCount2];
                        for (int pp = 0; pp < pointsCount2; pp++)
                        {
                            linePoints2[pp] = Line[1].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[1].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints2[p];
                            Vector3 endPosition = linePoints2[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration2;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount2; j++)
                                    Line[1].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 1;
                        break;
                    case "Dot04":
                        Vector3[] EndingPos3 = new Vector3[2];
                        EndingPos3[1] = new Vector3(-CloseXAxis, -CloseYAxis, 0);
                        Line[1].SetPositions(EndingPos3);
                        float segmentDuration3 = sec / Line[1].positionCount;
                        int pointsCount3 = Line[1].positionCount;
                        Vector3[] linePoints3 = new Vector3[pointsCount3];
                        for (int pp = 0; pp < pointsCount3; pp++)
                        {
                            linePoints3[pp] = Line[1].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[1].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints3[p];
                            Vector3 endPosition = linePoints3[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration3;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount3; j++)
                                    Line[1].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 1;
                        break;
                    case "Dot05":
                        Vector3[] EndingPos4 = new Vector3[2];
                        EndingPos4[1] = new Vector3(0, -CloseYAxis, 0);
                        Line[1].SetPositions(EndingPos4);
                        float segmentDuration4 = sec / Line[1].positionCount;
                        int pointsCount4 = Line[1].positionCount;
                        Vector3[] linePoints4 = new Vector3[pointsCount4];
                        for (int pp = 0; pp < pointsCount4; pp++)
                        {
                            linePoints4[pp] = Line[1].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[1].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints4[p];
                            Vector3 endPosition = linePoints4[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration4;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount4; j++)
                                    Line[1].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 1;
                        break;
                    case "Dot06":
                        Vector3[] EndingPos5 = new Vector3[2];
                        EndingPos5[1] = new Vector3(CloseXAxis, -CloseYAxis, 0);
                        Line[1].SetPositions(EndingPos5);
                        float segmentDuration5 = sec / Line[1].positionCount;
                        int pointsCount5 = Line[1].positionCount;
                        Vector3[] linePoints5 = new Vector3[pointsCount5];
                        for (int pp = 0; pp < pointsCount5; pp++)
                        {
                            linePoints5[pp] = Line[1].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[1].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints5[p];
                            Vector3 endPosition = linePoints5[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration5;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount5; j++)
                                    Line[1].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 1;
                        break;
                    case "Dot07":
                        Vector3[] EndingPos6 = new Vector3[2];
                        EndingPos6[1] = new Vector3(-CloseXAxis, -FarYAxis, 0);
                        Line[1].SetPositions(EndingPos6);
                        float segmentDuration6 = sec / Line[1].positionCount;
                        int pointsCount6 = Line[1].positionCount;
                        Vector3[] linePoints6 = new Vector3[pointsCount6];
                        for (int pp = 0; pp < pointsCount6; pp++)
                        {
                            linePoints6[pp] = Line[1].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[1].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints6[p];
                            Vector3 endPosition = linePoints6[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration6;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount6; j++)
                                    Line[1].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 1;
                        break;
                    case "Dot09":
                        Vector3[] EndingPos7 = new Vector3[2];
                        EndingPos7[1] = new Vector3(CloseXAxis, -FarYAxis, 0);
                        Line[1].SetPositions(EndingPos7);
                        float segmentDuration7 = sec / Line[1].positionCount;
                        int pointsCount7 = Line[1].positionCount;
                        Vector3[] linePoints7 = new Vector3[pointsCount7];
                        for (int pp = 0; pp < pointsCount7; pp++)
                        {
                            linePoints7[pp] = Line[1].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[1].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints7[p];
                            Vector3 endPosition = linePoints7[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration7;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount7; j++)
                                    Line[1].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 1;
                        break;
                    default:
                        //  Line[i].enabled = false;
                        break;
                }
                break;
            case "Dot03":
                switch (end)
                {
                    case "Dot02":
                        Vector3[] EndingPos7 = new Vector3[2];
                        EndingPos7[1] = new Vector3(-CloseXAxis, 0, 0);
                        Line[2].SetPositions(EndingPos7);
                        float segmentDuration5 = sec / Line[2].positionCount;
                        int pointsCount5 = Line[2].positionCount;
                        Vector3[] linePoints5 = new Vector3[pointsCount5];
                        for (int pp = 0; pp < pointsCount5; pp++)
                        {
                            linePoints5[pp] = Line[2].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[2].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints5[p];
                            Vector3 endPosition = linePoints5[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration5;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount5; j++)
                                    Line[2].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 2;
                        break;
                    case "Dot04":
                        Vector3[] EndingPos6 = new Vector3[2];
                        EndingPos6[1] = new Vector3(-FarXAxis, -CloseYAxis, 0);
                        Line[2].SetPositions(EndingPos6);
                        float segmentDuration6 = sec / Line[2].positionCount;
                        int pointsCount6 = Line[2].positionCount;
                        Vector3[] linePoints6 = new Vector3[pointsCount6];
                        for (int pp = 0; pp < pointsCount6; pp++)
                        {
                            linePoints6[pp] = Line[2].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[2].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints6[p];
                            Vector3 endPosition = linePoints6[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration6;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount6; j++)
                                    Line[2].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 2;
                        break;
                    case "Dot05":
                        Vector3[] EndingPos5 = new Vector3[2];
                        EndingPos5[1] = new Vector3(-CloseXAxis, -CloseYAxis, 0);
                        Line[2].SetPositions(EndingPos5);
                        float segmentDuration7 = sec / Line[2].positionCount;
                        int pointsCount7 = Line[2].positionCount;
                        Vector3[] linePoints7 = new Vector3[pointsCount7];
                        for (int pp = 0; pp < pointsCount7; pp++)
                        {
                            linePoints7[pp] = Line[2].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[2].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints7[p];
                            Vector3 endPosition = linePoints7[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration7;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount7; j++)
                                    Line[2].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 2;
                        break;
                    case "Dot06":
                        Vector3[] EndingPos4 = new Vector3[2];
                        EndingPos4[1] = new Vector3(0, -CloseYAxis, 0);
                        Line[2].SetPositions(EndingPos4);
                        float segmentDuration8 = sec / Line[2].positionCount;
                        int pointsCount8 = Line[2].positionCount;
                        Vector3[] linePoints8 = new Vector3[pointsCount8];
                        for (int pp = 0; pp < pointsCount8; pp++)
                        {
                            linePoints8[pp] = Line[2].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[2].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints8[p];
                            Vector3 endPosition = linePoints8[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration8;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount8; j++)
                                    Line[2].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 2;
                        break;
                    case "Dot08":
                        Vector3[] EndingPos3 = new Vector3[2];
                        EndingPos3[1] = new Vector3(-CloseXAxis, -FarYAxis, 0);
                        Line[2].SetPositions(EndingPos3);
                        float segmentDuration9 = sec / Line[2].positionCount;
                        int pointsCount9 = Line[2].positionCount;
                        Vector3[] linePoints9 = new Vector3[pointsCount9];
                        for (int pp = 0; pp < pointsCount9; pp++)
                        {
                            linePoints9[pp] = Line[2].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[2].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints9[p];
                            Vector3 endPosition = linePoints9[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration9;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount9; j++)
                                    Line[2].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 2;
                        break;
                    default:
                        //  Line[i].enabled = false;
                        break;
                }
                break;
            case "Dot04":
                switch (end)
                {
                    case "Dot01":
                        Vector3[] EndingPos7 = new Vector3[2];
                        EndingPos7[1] = new Vector3(0, CloseYAxis, 0);
                        Line[3].SetPositions(EndingPos7);
                        float segmentDuration5 = sec / Line[3].positionCount;
                        int pointsCount5 = Line[3].positionCount;
                        Vector3[] linePoints5 = new Vector3[pointsCount5];
                        for (int pp = 0; pp < pointsCount5; pp++)
                        {
                            linePoints5[pp] = Line[3].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[3].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints5[p];
                            Vector3 endPosition = linePoints5[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration5;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount5; j++)
                                    Line[3].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 3;
                        break;
                    case "Dot02":
                        Vector3[] EndingPos = new Vector3[2];
                        EndingPos[1] = new Vector3(CloseXAxis, CloseYAxis, 0);
                        Line[3].SetPositions(EndingPos);
                        float segmentDuration6 = sec / Line[3].positionCount;
                        int pointsCount6 = Line[3].positionCount;
                        Vector3[] linePoints6 = new Vector3[pointsCount6];
                        for (int pp = 0; pp < pointsCount6; pp++)
                        {
                            linePoints6[pp] = Line[3].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[3].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints6[p];
                            Vector3 endPosition = linePoints6[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration6;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount6; j++)
                                    Line[3].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 3;
                        break;
                    case "Dot03":
                        Vector3[] EndingPos1 = new Vector3[2];
                        EndingPos1[1] = new Vector3(FarXAxis, CloseYAxis, 0);
                        Line[3].SetPositions(EndingPos1);
                        float segmentDuration7 = sec / Line[3].positionCount;
                        int pointsCount7 = Line[3].positionCount;
                        Vector3[] linePoints7 = new Vector3[pointsCount7];
                        for (int pp = 0; pp < pointsCount7; pp++)
                        {
                            linePoints7[pp] = Line[3].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[3].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints7[p];
                            Vector3 endPosition = linePoints7[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration7;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount7; j++)
                                    Line[3].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 3;
                        break;
                    case "Dot05":
                        Vector3[] EndingPos2 = new Vector3[2];
                        EndingPos2[1] = new Vector3(CloseXAxis, 0, 0);
                        Line[3].SetPositions(EndingPos2);
                        float segmentDuration8 = sec / Line[3].positionCount;
                        int pointsCount8 = Line[3].positionCount;
                        Vector3[] linePoints8 = new Vector3[pointsCount8];
                        for (int pp = 0; pp < pointsCount8; pp++)
                        {
                            linePoints8[pp] = Line[3].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[3].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints8[p];
                            Vector3 endPosition = linePoints8[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration8;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount8; j++)
                                    Line[3].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 3;
                        break;
                    case "Dot07":
                        Vector3[] EndingPos3 = new Vector3[2];
                        EndingPos3[1] = new Vector3(0, -CloseYAxis, 0);
                        Line[3].SetPositions(EndingPos3);
                        float segmentDuration9 = sec / Line[3].positionCount;
                        int pointsCount9 = Line[3].positionCount;
                        Vector3[] linePoints9 = new Vector3[pointsCount9];
                        for (int pp = 0; pp < pointsCount9; pp++)
                        {
                            linePoints9[pp] = Line[3].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[3].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints9[p];
                            Vector3 endPosition = linePoints9[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration9;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount9; j++)
                                    Line[3].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 3;
                        break;
                    case "Dot08":
                        Vector3[] EndingPos4 = new Vector3[2];
                        EndingPos4[1] = new Vector3(CloseXAxis, -CloseYAxis, 0);
                        Line[3].SetPositions(EndingPos4);
                        float segmentDuration1 = sec / Line[3].positionCount;
                        int pointsCount1 = Line[3].positionCount;
                        Vector3[] linePoints1 = new Vector3[pointsCount1];
                        for (int pp = 0; pp < pointsCount1; pp++)
                        {
                            linePoints1[pp] = Line[3].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[3].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints1[p];
                            Vector3 endPosition = linePoints1[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration1;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount1; j++)
                                    Line[3].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 3;
                        break;
                    case "Dot09":
                        Vector3[] EndingPos5 = new Vector3[2];
                        EndingPos5[1] = new Vector3(FarXAxis, -CloseYAxis, 0);
                        Line[3].SetPositions(EndingPos5);
                        float segmentDuration2 = sec / Line[3].positionCount;
                        int pointsCount2 = Line[3].positionCount;
                        Vector3[] linePoints2 = new Vector3[pointsCount2];
                        for (int pp = 0; pp < pointsCount2; pp++)
                        {
                            linePoints2[pp] = Line[3].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[3].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints2[p];
                            Vector3 endPosition = linePoints2[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration2;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount2; j++)
                                    Line[3].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 3;
                        break;
                    default:
                        // Line[i].enabled = false;
                        break;
                }
                break;
            case "Dot05":
                switch (end)
                {
                    case "Dot01":
                        Vector3[] EndingPos7 = new Vector3[2];
                        EndingPos7[1] = new Vector3(-CloseXAxis, CloseYAxis, 0);
                        Line[4].SetPositions(EndingPos7);
                        float segmentDuration1 = sec / Line[4].positionCount;
                        int pointsCount1 = Line[4].positionCount;
                        Vector3[] linePoints1 = new Vector3[pointsCount1];
                        for (int pp = 0; pp < pointsCount1; pp++)
                        {
                            linePoints1[pp] = Line[4].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[4].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints1[p];
                            Vector3 endPosition = linePoints1[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration1;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount1; j++)
                                    Line[4].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 4;
                        break;
                    case "Dot02":
                        Vector3[] EndingPos6 = new Vector3[2];
                        EndingPos6[1] = new Vector3(0, CloseYAxis, 0);
                        Line[4].SetPositions(EndingPos6);
                        float segmentDuration2 = sec / Line[4].positionCount;
                        int pointsCount2 = Line[4].positionCount;
                        Vector3[] linePoints2 = new Vector3[pointsCount2];
                        for (int pp = 0; pp < pointsCount2; pp++)
                        {
                            linePoints2[pp] = Line[4].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[4].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints2[p];
                            Vector3 endPosition = linePoints2[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration2;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount2; j++)
                                    Line[4].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 4;
                        break;
                    case "Dot03":
                        Vector3[] EndingPos5 = new Vector3[2];
                        EndingPos5[1] = new Vector3(CloseXAxis, CloseYAxis, 0);
                        Line[4].SetPositions(EndingPos5);
                        float segmentDuration3 = sec / Line[4].positionCount;
                        int pointsCount3 = Line[4].positionCount;
                        Vector3[] linePoints3 = new Vector3[pointsCount3];
                        for (int pp = 0; pp < pointsCount3; pp++)
                        {
                            linePoints3[pp] = Line[4].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[4].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints3[p];
                            Vector3 endPosition = linePoints3[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration3;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount3; j++)
                                    Line[4].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 4;
                        break;
                    case "Dot04":
                        Vector3[] EndingPos4 = new Vector3[2];
                        EndingPos4[1] = new Vector3(-CloseXAxis, 0, 0);
                        Line[4].SetPositions(EndingPos4);
                        float segmentDuration4 = sec / Line[4].positionCount;
                        int pointsCount4 = Line[4].positionCount;
                        Vector3[] linePoints4 = new Vector3[pointsCount4];
                        for (int pp = 0; pp < pointsCount4; pp++)
                        {
                            linePoints4[pp] = Line[4].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[4].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints4[p];
                            Vector3 endPosition = linePoints4[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration4;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount4; j++)
                                    Line[4].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 4;
                        break;
                    case "Dot06":
                        Vector3[] EndingPos3 = new Vector3[2];
                        EndingPos3[1] = new Vector3(CloseXAxis, 0, 0);
                        Line[4].SetPositions(EndingPos3);
                        float segmentDuration5 = sec / Line[4].positionCount;
                        int pointsCount5 = Line[4].positionCount;
                        Vector3[] linePoints5 = new Vector3[pointsCount5];
                        for (int pp = 0; pp < pointsCount5; pp++)
                        {
                            linePoints5[pp] = Line[4].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[4].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints5[p];
                            Vector3 endPosition = linePoints5[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration5;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount5; j++)
                                    Line[4].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 4;
                        break;
                    case "Dot07":
                        Vector3[] EndingPos2 = new Vector3[2];
                        EndingPos2[1] = new Vector3(-CloseXAxis, -CloseYAxis, 0);
                        Line[4].SetPositions(EndingPos2);
                        float segmentDuration6 = sec / Line[4].positionCount;
                        int pointsCount6 = Line[4].positionCount;
                        Vector3[] linePoints6 = new Vector3[pointsCount6];
                        for (int pp = 0; pp < pointsCount6; pp++)
                        {
                            linePoints6[pp] = Line[4].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[4].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints6[p];
                            Vector3 endPosition = linePoints6[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration6;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount6; j++)
                                    Line[4].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 4;
                        break;
                    case "Dot08":
                        Vector3[] EndingPos = new Vector3[2];
                        EndingPos[1] = new Vector3(0, -CloseYAxis, 0);
                        Line[4].SetPositions(EndingPos);
                        float segmentDuration7 = sec / Line[4].positionCount;
                        int pointsCount7 = Line[4].positionCount;
                        Vector3[] linePoints7 = new Vector3[pointsCount7];
                        for (int pp = 0; pp < pointsCount7; pp++)
                        {
                            linePoints7[pp] = Line[4].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[4].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints7[p];
                            Vector3 endPosition = linePoints7[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration7;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount7; j++)
                                    Line[4].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 4;
                        break;
                    case "Dot09":
                        Vector3[] EndingPos9 = new Vector3[2];
                        EndingPos9[1] = new Vector3(CloseXAxis, -CloseYAxis, 0);
                        Line[4].SetPositions(EndingPos9);
                        float segmentDuration8 = sec / Line[4].positionCount;
                        int pointsCount8 = Line[4].positionCount;
                        Vector3[] linePoints8 = new Vector3[pointsCount8];
                        for (int pp = 0; pp < pointsCount8; pp++)
                        {
                            linePoints8[pp] = Line[4].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[4].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints8[p];
                            Vector3 endPosition = linePoints8[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration8;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount8; j++)
                                    Line[4].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 4;
                        break;
                    default:
                        //  Line[i].enabled = false;
                        break;
                }
                break;
            case "Dot06":
                switch (end)
                {
                    case "Dot01":
                        Vector3[] EndingPos7 = new Vector3[2];
                        EndingPos7[1] = new Vector3(-FarXAxis, CloseYAxis, 0);
                        Line[5].SetPositions(EndingPos7);
                        float segmentDuration1 = sec / Line[5].positionCount;
                        int pointsCount1 = Line[5].positionCount;
                        Vector3[] linePoints1 = new Vector3[pointsCount1];
                        for (int pp = 0; pp < pointsCount1; pp++)
                        {
                            linePoints1[pp] = Line[5].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[5].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints1[p];
                            Vector3 endPosition = linePoints1[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration1;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount1; j++)
                                    Line[5].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 5;
                        break;
                    case "Dot02":
                        Vector3[] EndingPos6 = new Vector3[2];
                        EndingPos6[1] = new Vector3(-CloseXAxis, CloseYAxis, 0);
                        Line[5].SetPositions(EndingPos6);
                        float segmentDuration2 = sec / Line[5].positionCount;
                        int pointsCount2 = Line[5].positionCount;
                        Vector3[] linePoints2 = new Vector3[pointsCount2];
                        for (int pp = 0; pp < pointsCount2; pp++)
                        {
                            linePoints2[pp] = Line[5].GetPosition(pp);
                        } 

                        for (int p = 0; p < Line[5].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints2[p];
                            Vector3 endPosition = linePoints2[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration2;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount2; j++)
                                    Line[5].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 5;
                        break;
                    case "Dot03":
                        Vector3[] EndingPos5 = new Vector3[2];
                        EndingPos5[1] = new Vector3(0, CloseYAxis, 0);
                        Line[5].SetPositions(EndingPos5);
                        float segmentDuration3 = sec / Line[5].positionCount;
                        int pointsCount3 = Line[5].positionCount;
                        Vector3[] linePoints3 = new Vector3[pointsCount3];
                        for (int pp = 0; pp < pointsCount3; pp++)
                        {
                            linePoints3[pp] = Line[5].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[5].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints3[p];
                            Vector3 endPosition = linePoints3[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration3;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount3; j++)
                                    Line[5].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 5;
                        break;
                    case "Dot05":
                        Vector3[] EndingPos4 = new Vector3[2];
                        EndingPos4[1] = new Vector3(-CloseXAxis, 0, 0);
                        Line[5].SetPositions(EndingPos4);
                        float segmentDuration4 = sec / Line[5].positionCount;
                        int pointsCount4 = Line[5].positionCount;
                        Vector3[] linePoints4 = new Vector3[pointsCount4];
                        for (int pp = 0; pp < pointsCount4; pp++)
                        {
                            linePoints4[pp] = Line[5].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[5].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints4[p];
                            Vector3 endPosition = linePoints4[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration4;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount4; j++)
                                    Line[5].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 5;
                        break;
                    case "Dot07":
                        Vector3[] EndingPos2 = new Vector3[2];
                        EndingPos2[1] = new Vector3(-FarXAxis, -CloseYAxis, 0);
                        Line[5].SetPositions(EndingPos2);
                        float segmentDuration5 = sec / Line[5].positionCount;
                        int pointsCount5 = Line[5].positionCount;
                        Vector3[] linePoints5 = new Vector3[pointsCount5];
                        for (int pp = 0; pp < pointsCount5; pp++)
                        {
                            linePoints5[pp] = Line[5].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[5].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints5[p];
                            Vector3 endPosition = linePoints5[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration5;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount5; j++)
                                    Line[5].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 5;
                        break;
                    case "Dot08":
                        Vector3[] EndingPos = new Vector3[2];
                        EndingPos[1] = new Vector3(-CloseXAxis, -CloseYAxis, 0);
                        Line[5].SetPositions(EndingPos);
                        float segmentDuration6 = sec / Line[5].positionCount;
                        int pointsCount6 = Line[5].positionCount;
                        Vector3[] linePoints6 = new Vector3[pointsCount6];
                        for (int pp = 0; pp < pointsCount6; pp++)
                        {
                            linePoints6[pp] = Line[5].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[5].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints6[p];
                            Vector3 endPosition = linePoints6[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration6;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount6; j++)
                                    Line[5].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 5;
                        break;
                    case "Dot09":
                        Vector3[] EndingPos9 = new Vector3[2];
                        EndingPos9[1] = new Vector3(0, -CloseYAxis, 0);
                        Line[5].SetPositions(EndingPos9);
                        float segmentDuration7 = sec / Line[5].positionCount;
                        int pointsCount7 = Line[5].positionCount;
                        Vector3[] linePoints7 = new Vector3[pointsCount7];
                        for (int pp = 0; pp < pointsCount7; pp++)
                        {
                            linePoints7[pp] = Line[5].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[5].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints7[p];
                            Vector3 endPosition = linePoints7[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration7;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount7; j++)
                                    Line[5].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 5;
                        break;
                    default:
                        //   Line[i].enabled = false;
                        break;
                }
                break;
            case "Dot07":
                switch (end)
                {
                    case "Dot02":
                        Vector3[] EndingPos7 = new Vector3[2];
                        EndingPos7[1] = new Vector3(CloseXAxis, FarYAxis, 0);
                        Line[6].SetPositions(EndingPos7);
                        float segmentDuration1 = sec / Line[6].positionCount;
                        int pointsCount1 = Line[6].positionCount;
                        Vector3[] linePoints1 = new Vector3[pointsCount1];
                        for (int pp = 0; pp < pointsCount1; pp++)
                        {
                            linePoints1[pp] = Line[6].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[6].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints1[p];
                            Vector3 endPosition = linePoints1[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration1;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount1; j++)
                                    Line[6].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 6;
                        break;
                    case "Dot04":
                        Vector3[] EndingPos6 = new Vector3[2];
                        EndingPos6[1] = new Vector3(0, CloseYAxis, 0);
                        Line[6].SetPositions(EndingPos6);
                        float segmentDuration2 = sec / Line[6].positionCount;
                        int pointsCount2 = Line[6].positionCount;
                        Vector3[] linePoints2 = new Vector3[pointsCount2];
                        for (int pp = 0; pp < pointsCount2; pp++)
                        {
                            linePoints2[pp] = Line[6].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[6].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints2[p];
                            Vector3 endPosition = linePoints2[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration2;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount2; j++)
                                    Line[6].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 6;
                        break;
                    case "Dot05":
                        Vector3[] EndingPos5 = new Vector3[2];
                        EndingPos5[1] = new Vector3(CloseXAxis, CloseYAxis, 0);
                        Line[6].SetPositions(EndingPos5);
                        float segmentDuration3 = sec / Line[6].positionCount;
                        int pointsCount3 = Line[6].positionCount;
                        Vector3[] linePoints3 = new Vector3[pointsCount3];
                        for (int pp = 0; pp < pointsCount3; pp++)
                        {
                            linePoints3[pp] = Line[6].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[6].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints3[p];
                            Vector3 endPosition = linePoints3[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration3;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount3; j++)
                                    Line[6].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 6;
                        break;
                    case "Dot06":
                        Vector3[] EndingPos4 = new Vector3[2];
                        EndingPos4[1] = new Vector3(FarXAxis, CloseYAxis, 0);
                        Line[6].SetPositions(EndingPos4);
                        float segmentDuration4 = sec / Line[6].positionCount;
                        int pointsCount4 = Line[6].positionCount;
                        Vector3[] linePoints4 = new Vector3[pointsCount4];
                        for (int pp = 0; pp < pointsCount4; pp++)
                        {
                            linePoints4[pp] = Line[6].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[6].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints4[p];
                            Vector3 endPosition = linePoints4[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration4;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount4; j++)
                                    Line[6].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 6;
                        break;
                    case "Dot08":
                        Vector3[] EndingPos3 = new Vector3[2];
                        EndingPos3[1] = new Vector3(CloseXAxis, 0, 0);
                        Line[6].SetPositions(EndingPos3);
                        float segmentDuration5 = sec / Line[6].positionCount;
                        int pointsCount5 = Line[6].positionCount;
                        Vector3[] linePoints5 = new Vector3[pointsCount5];
                        for (int pp = 0; pp < pointsCount5; pp++)
                        {
                            linePoints5[pp] = Line[6].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[6].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints5[p];
                            Vector3 endPosition = linePoints5[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration5;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount5; j++)
                                    Line[6].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 6;
                        break;
                    default:
                        //  Line[i].enabled = false;
                        break;
                }
                break;
            case "Dot08":
                switch (end)
                {
                    case "Dot01":
                        Vector3[] EndingPos7 = new Vector3[2];
                        EndingPos7[1] = new Vector3(-CloseXAxis, FarYAxis, 0);
                        Line[7].SetPositions(EndingPos7);
                        float segmentDuration1 = sec / Line[7].positionCount;
                        int pointsCount1 = Line[7].positionCount;
                        Vector3[] linePoints1 = new Vector3[pointsCount1];
                        for (int pp = 0; pp < pointsCount1; pp++)
                        {
                            linePoints1[pp] = Line[7].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[7].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints1[p];
                            Vector3 endPosition = linePoints1[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration1;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount1; j++)
                                    Line[7].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 7;
                        break;
                    case "Dot03":
                        Vector3[] EndingPos6 = new Vector3[2];
                        EndingPos6[1] = new Vector3(CloseXAxis, FarYAxis, 0);
                        Line[7].SetPositions(EndingPos6);
                        float segmentDuration2 = sec / Line[7].positionCount;
                        int pointsCount2 = Line[7].positionCount;
                        Vector3[] linePoints2 = new Vector3[pointsCount2];
                        for (int pp = 0; pp < pointsCount2; pp++)
                        {
                            linePoints2[pp] = Line[7].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[7].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints2[p];
                            Vector3 endPosition = linePoints2[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration2;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount2; j++)
                                    Line[7].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 7;
                        break;
                    case "Dot04":
                        Vector3[] EndingPos5 = new Vector3[2];
                        EndingPos5[1] = new Vector3(-CloseXAxis, CloseYAxis, 0);
                        Line[7].SetPositions(EndingPos5);
                        float segmentDuration3 = sec / Line[7].positionCount;
                        int pointsCount3 = Line[7].positionCount;
                        Vector3[] linePoints3 = new Vector3[pointsCount3];
                        for (int pp = 0; pp < pointsCount3; pp++)
                        {
                            linePoints3[pp] = Line[7].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[7].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints3[p];
                            Vector3 endPosition = linePoints3[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration3;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount3; j++)
                                    Line[7].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 7;
                        break;
                    case "Dot05":
                        Vector3[] EndingPos4 = new Vector3[2];
                        EndingPos4[1] = new Vector3(0, CloseYAxis, 0);
                        Line[7].SetPositions(EndingPos4);
                        float segmentDuration4 = sec / Line[7].positionCount;
                        int pointsCount4 = Line[7].positionCount;
                        Vector3[] linePoints4 = new Vector3[pointsCount4];
                        for (int pp = 0; pp < pointsCount4; pp++)
                        {
                            linePoints4[pp] = Line[7].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[7].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints4[p];
                            Vector3 endPosition = linePoints4[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration4;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount4; j++)
                                    Line[7].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 7;
                        break;
                    case "Dot06":
                        Vector3[] EndingPos2 = new Vector3[2];
                        EndingPos2[1] = new Vector3(CloseXAxis, CloseYAxis, 0);
                        Line[7].SetPositions(EndingPos2);
                        float segmentDuration5 = sec / Line[7].positionCount;
                        int pointsCount5 = Line[7].positionCount;
                        Vector3[] linePoints5 = new Vector3[pointsCount5];
                        for (int pp = 0; pp < pointsCount5; pp++)
                        {
                            linePoints5[pp] = Line[7].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[7].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints5[p];
                            Vector3 endPosition = linePoints5[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration5;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount5; j++)
                                    Line[7].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 7;
                        break;
                    case "Dot07":
                        Vector3[] EndingPos = new Vector3[2];
                        EndingPos[1] = new Vector3(-CloseXAxis, 0, 0);
                        Line[7].SetPositions(EndingPos);
                        float segmentDuration6 = sec / Line[7].positionCount;
                        int pointsCount6 = Line[7].positionCount;
                        Vector3[] linePoints6 = new Vector3[pointsCount6];
                        for (int pp = 0; pp < pointsCount6; pp++)
                        {
                            linePoints6[pp] = Line[7].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[7].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints6[p];
                            Vector3 endPosition = linePoints6[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration6;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount6; j++)
                                    Line[7].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 7;
                        break;
                    case "Dot09":
                        Vector3[] EndingPos9 = new Vector3[2];
                        EndingPos9[1] = new Vector3(CloseXAxis, 0, 0);
                        Line[7].SetPositions(EndingPos9);
                        float segmentDuration7 = sec / Line[7].positionCount;
                        int pointsCount7 = Line[7].positionCount;
                        Vector3[] linePoints7 = new Vector3[pointsCount7];
                        for (int pp = 0; pp < pointsCount7; pp++)
                        {
                            linePoints7[pp] = Line[7].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[7].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints7[p];
                            Vector3 endPosition = linePoints7[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration7;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount7; j++)
                                    Line[7].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 7;
                        break;
                    default:
                        //  Line[i].enabled = false;
                        break;
                }
                break;
            case "Dot09":
                switch (end)
                {
                    case "Dot02":
                        Vector3[] EndingPos7 = new Vector3[2];
                        EndingPos7[1] = new Vector3(-CloseXAxis, FarYAxis, 0);
                        Line[8].SetPositions(EndingPos7);
                        float segmentDuration1 = sec / Line[8].positionCount;
                        int pointsCount1 = Line[8].positionCount;
                        Vector3[] linePoints1 = new Vector3[pointsCount1];
                        for (int pp = 0; pp < pointsCount1; pp++)
                        {
                            linePoints1[pp] = Line[8].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[8].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints1[p];
                            Vector3 endPosition = linePoints1[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration1;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount1; j++)
                                    Line[8].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 8;
                        break;
                    case "Dot04":
                        Vector3[] EndingPos6 = new Vector3[2];
                        EndingPos6[1] = new Vector3(-FarXAxis, CloseYAxis, 0);
                        Line[8].SetPositions(EndingPos6);
                        float segmentDuration2 = sec / Line[8].positionCount;
                        int pointsCount2 = Line[8].positionCount;
                        Vector3[] linePoints2 = new Vector3[pointsCount2];
                        for (int pp = 0; pp < pointsCount2; pp++)
                        {
                            linePoints2[pp] = Line[8].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[8].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints2[p];
                            Vector3 endPosition = linePoints2[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration2;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount2; j++)
                                    Line[8].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 8;
                        break;
                    case "Dot05":
                        Vector3[] EndingPos5 = new Vector3[2];
                        EndingPos5[1] = new Vector3(-CloseXAxis, CloseYAxis, 0);
                        Line[8].SetPositions(EndingPos5);
                        float segmentDuration3 = sec / Line[8].positionCount;
                        int pointsCount3 = Line[8].positionCount;
                        Vector3[] linePoints3 = new Vector3[pointsCount3];
                        for (int pp = 0; pp < pointsCount3; pp++)
                        {
                            linePoints3[pp] = Line[8].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[8].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints3[p];
                            Vector3 endPosition = linePoints3[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration3;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount3; j++)
                                    Line[8].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 8;
                        break;
                    case "Dot06":
                        Vector3[] EndingPos4 = new Vector3[2];
                        EndingPos4[1] = new Vector3(0, CloseYAxis, 0);
                        Line[8].SetPositions(EndingPos4);
                        float segmentDuration4 = sec / Line[8].positionCount;
                        int pointsCount4 = Line[8].positionCount;
                        Vector3[] linePoints4 = new Vector3[pointsCount4];
                        for (int pp = 0; pp < pointsCount4; pp++)
                        {
                            linePoints4[pp] = Line[8].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[8].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints4[p];
                            Vector3 endPosition = linePoints4[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration4;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount4; j++)
                                    Line[8].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 8;
                        break;
                    case "Dot08":
                        Vector3[] EndingPos3 = new Vector3[2];
                        EndingPos3[1] = new Vector3(-CloseXAxis, 0, 0);
                        Line[8].SetPositions(EndingPos3);
                        float segmentDuration5 = sec / Line[8].positionCount;
                        int pointsCount5 = Line[8].positionCount;
                        Vector3[] linePoints5 = new Vector3[pointsCount5];
                        for (int pp = 0; pp < pointsCount5; pp++)
                        {
                            linePoints5[pp] = Line[8].GetPosition(pp);
                        }

                        for (int p = 0; p < Line[8].positionCount - 1; p++)
                        {
                            float startTime = Time.time;

                            Vector3 startPosition = linePoints5[p];
                            Vector3 endPosition = linePoints5[p + 1];

                            Vector3 pos = startPosition;
                            while (pos != endPosition)
                            {
                                float t = (Time.time - startTime) / segmentDuration5;
                                pos = Vector3.Lerp(startPosition, endPosition, t);

                                // animate all other points except point at index i
                                for (int j = i + 1; j < pointsCount5; j++)
                                    Line[8].SetPosition(j, pos);

                                yield return null;
                            }
                        }
                        i = 8;
                        break;
                    default:
                        //    Line[i].enabled = false;
                        break;
                }
                break;
            default:
                //  Line[i].enabled = false;
                break;
        }
        
        // print("PP");
        yield return new WaitForSeconds(1.5f);
        Vector3[] EndingPos44 = new Vector3[2];
        EndingPos44[1] = new Vector3(0, 0, 0);
        float segmentDuration44 = sec / Line[i].positionCount;
        int pointsCount44 = Line[i].positionCount;
        Vector3[] linePoints44 = new Vector3[pointsCount44];
        Line[i].SetPositions(EndingPos44);
        for (int pp = 0; pp < pointsCount44; pp++)
        {
            linePoints44[pp] = Line[i].GetPosition(pp);
        }

        for (int p = 0; p < Line[i].positionCount - 1; p++)
        {
            float startTime = Time.time;

            Vector3 startPosition = linePoints44[p];
            Vector3 endPosition = linePoints44[p + 1];

            Vector3 pos = startPosition;
            while (pos != endPosition)
            {
                float t = (Time.time - startTime) / segmentDuration44;
                pos = Vector3.Lerp(startPosition, endPosition, t);

                // animate all other points except point at index i
                for (int j = i + 1; j < pointsCount44; j++)
                    Line[i].SetPosition(j, pos);

                yield return null;
            }
        }

        // print("starting: " + StartingDotAI);
        //  print("ending: " + end + "P");
        EndingDotAI = "";

       // Line[i].enabled = false;
        HasDrawnLine = false;

        StopCoroutine(WaitAndDrawLine(end));
    }
    void Update()
    {
        if(IsAIGameState == true)
        {
            if (!HasDrawnLine)
            {
                if (pp < AI.Instruction.Length)
                {
                    StartingDotAI = AI.Instruction[pp].Substring(0, AI.Instruction[pp].IndexOf("_"));
                    //print(AI.Instruction[pp].Length);
                    for (int i = 6; i < AI.Instruction[pp].Length; i++)
                    {
                        EndingDotAI += AI.Instruction[pp][i];
                    }
                    //  EndingDotAI = AI.Instruction[pp];
                    //  EndingDotAI.T();
                    //EndingDotAI = AI.Instruction[pp].Substring(5, AI.Instruction[pp].Length - 2);
                    // print(EndingDotAI);
                    EndingDots[pp] = EndingDotAI;
                    StartCoroutine(WaitAndDrawLine(EndingDotAI));
                    pp++;

                }
                else
                {
                    HasDrawnLine = true;
                    IsAIGameState = false;
                    for(int a = 0; a < Line.Length; a++)
                    {
                        Vector3[] EndingPos1 = new Vector3[2];
                        Line[a].SetPositions(EndingPos1);
                    }
                }
            }

        }
        else if(IsAIGameState == false)
        {
            if (!isOnelineActive)
            {
                if (Input.GetMouseButton(0) || Input.touchCount > 0)
                {

                    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
                    RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

                    if (hit.collider == null)
                    {
                        return;
                    }
                       switch (hit.collider.name)
                       {
                           case "Dot01":
                       //     print("PP");

                            Vector3[] EndingPos1 = new Vector3[2];
                            Line[0].SetPositions(EndingPos1);
                            Line[0].enabled = true;
                               isLineActive[0] = true;
                              isOnelineActive = true;
                         //   currentDot = 0; 
                         //   print("DOT1");

                            break;
                           case "Dot02":
                            Vector3[] EndingPos12 = new Vector3[2];
                            Line[1].SetPositions(EndingPos12);
                            Line[1].enabled = true;
                               isLineActive[1] = true;
                               isOnelineActive = true;
                         //   currentDot = 1;

                            //   print("DOT2");

                            break;
                           case "Dot03":
                            Vector3[] EndingPos123 = new Vector3[2];
                            Line[2].SetPositions(EndingPos123);
                            Line[2].enabled = true;
                               isLineActive[2] = true;
                               isOnelineActive = true;
                          //  currentDot = 2;

                            //  print("DOT3");

                            break;
                           case "Dot04":
                            Vector3[] EndingPos124 = new Vector3[2];
                            Line[3].SetPositions(EndingPos124);
                            Line[3].enabled = true;
                               isLineActive[3] = true;
                               isOnelineActive = true;
                            //  print("DOT4");
                          //  currentDot = 3;


                            break;
                           case "Dot05":

                            Vector3[] EndingPos15 = new Vector3[2];
                            Line[4].SetPositions(EndingPos15);
                            Line[4].enabled = true;
                               isLineActive[4] = true;
                               isOnelineActive = true;
                           // currentDot = 4;

                            //  print("DOT5");

                            break;
                           case "Dot06":
                            Vector3[] EndingPos14 = new Vector3[2];
                            Line[5].SetPositions(EndingPos14);
                            Line[5].enabled = true;
                               isLineActive[5] = true;
                               isOnelineActive = true;
                          //  currentDot = 5;

                            //      print("DOT6");

                            break;
                           case "Dot07":
                            Vector3[] EndingPos122 = new Vector3[2];
                            Line[6].SetPositions(EndingPos122);
                            Line[6].enabled = true;
                                isLineActive[6] = true; 
                            isOnelineActive = true;
                            //    print("DOT7");
                          //  currentDot = 6;

                            break;
                           case "Dot08":
                            Vector3[] EndingPos121 = new Vector3[2];
                            Line[7].SetPositions(EndingPos121);
                            Line[7].enabled = true;
                                isLineActive[7] = true;
                                isOnelineActive = true;
                            //   print("DOT8");
                          // currentDot = 7;

                            break;
                           case "Dot09":
                            Vector3[] EndingPos152 = new Vector3[2];
                            Line[8].SetPositions(EndingPos152);
                            Line[8].enabled = true;
                                isLineActive[8] = true;
                                isOnelineActive = true;
                            //   print("DOT9");
                          //  currentDot = 8;

                            break;
                        default:
                            break;
                       }
                }
            }
            else
            {
                for (int i = 0; i < isLineActive.Length; i++)
                {
                    if (isLineActive[i] == true)
                    {
                        if (!HasPlaced)
                        {
                            Vector3[] PP = new Vector3[2];
                            PP[0] = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x - Dots[i].transform.position.x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y - Dots[i].transform.position.y, 0);
                            Line[i].SetPositions(PP);
                            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
                            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                            if (hit.collider != null)
                            {
                                switch(i)
                                {
                                    case 0:
                                        if (hit.collider.name == "Dot02"){
                                            if (EndingDots[PlayerCount] != "Dot02")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot04"){
                                            if (EndingDots[PlayerCount] != "Dot04")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot05"){
                                            if (EndingDots[PlayerCount] != "Dot05")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot06"){
                                            if (EndingDots[PlayerCount] != "Dot06")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot08"){
                                            if (EndingDots[PlayerCount] != "Dot08")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        break;
                                    case 1:
                                        if (hit.collider.name == "Dot01") {
                                            if (EndingDots[PlayerCount] != "Dot01")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot03") {
                                            if (EndingDots[PlayerCount] != "Dot03")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;  
                                        }
                                        else if (hit.collider.name == "Dot04") {
                                            if (EndingDots[PlayerCount] != "Dot04")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;  
                                        }
                                        else if (hit.collider.name == "Dot05") {
                                            if (EndingDots[PlayerCount] != "Dot05")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;  
                                        }
                                        else if (hit.collider.name == "Dot06") {
                                            if (EndingDots[PlayerCount] != "Dot06")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;  
                                        }
                                        else if (hit.collider.name == "Dot07") {
                                            if (EndingDots[PlayerCount] != "Dot07")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;  
                                        }
                                        else if (hit.collider.name == "Dot09") {
                                            if (EndingDots[PlayerCount] != "Dot09")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;  
                                        }
                                        break;
                                    case 2:
                                        if (hit.collider.name == "Dot02") {
                                            if (EndingDots[PlayerCount] != "Dot02")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot04") {
                                            if (EndingDots[PlayerCount] != "Dot04")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot05") {
                                            if (EndingDots[PlayerCount] != "Dot05")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot06") {
                                            if (EndingDots[PlayerCount] != "Dot06")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot08") {
                                            if (EndingDots[PlayerCount] != "Dot08")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        break;
                                    case 3:
                                        if (hit.collider.name == "Dot01") {
                                            if (EndingDots[PlayerCount] != "Dot01")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot02") {
                                            if (EndingDots[PlayerCount] != "Dot02")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot03") {
                                            if (EndingDots[PlayerCount] != "Dot03")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot05") {
                                            if (EndingDots[PlayerCount] != "Dot05")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot07") {
                                            if (EndingDots[PlayerCount] != "Dot07")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot08") {
                                            if (EndingDots[PlayerCount] != "Dot08")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot09") {
                                            if (EndingDots[PlayerCount] != "Dot09")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        break;
                                    case 4:
                                        if (hit.collider.name == "Dot01") {
                                            if (EndingDots[PlayerCount] != "Dot01")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot02") {
                                            if (EndingDots[PlayerCount] != "Dot02")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot03") {
                                            if (EndingDots[PlayerCount] != "Dot03")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot04") {
                                            if (EndingDots[PlayerCount] != "Dot04")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot06") {
                                            if (EndingDots[PlayerCount] != "Dot06")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot07") {
                                            if (EndingDots[PlayerCount] != "Dot07")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot08") {
                                            if (EndingDots[PlayerCount] != "Dot02")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot09") {
                                            if (EndingDots[PlayerCount] != "Dot09")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        break;
                                    case 5:
                                        if (hit.collider.name == "Dot01") {
                                            if (EndingDots[PlayerCount] != "Dot01")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot02") {
                                            if (EndingDots[PlayerCount] != "Dot02")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot03") {
                                            if (EndingDots[PlayerCount] != "Dot03")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot05") {
                                            if (EndingDots[PlayerCount] != "Dot05")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot07") {
                                            if (EndingDots[PlayerCount] != "Dot07")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot08") {
                                            if (EndingDots[PlayerCount] != "Dot08")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot09") {
                                            if (EndingDots[PlayerCount] != "Dot09")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        break;
                                    case 6:
                                        if (hit.collider.name == "Dot02") {
                                            if (EndingDots[PlayerCount] != "Dot02")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot04") {
                                            if (EndingDots[PlayerCount] != "Dot04")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot05") {
                                            if (EndingDots[PlayerCount] != "Dot05")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot06") {
                                            if (EndingDots[PlayerCount] != "Dot06")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot08") {
                                            if (EndingDots[PlayerCount] != "Dot08")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        break;
                                    case 7:
                                        if (hit.collider.name == "Dot01") {
                                            if (EndingDots[PlayerCount] != "Dot01")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot03") {
                                            if (EndingDots[PlayerCount] != "Dot03")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot04") {
                                            if (EndingDots[PlayerCount] != "Dot04")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot05") {
                                            if (EndingDots[PlayerCount] != "Dot05")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot06") {
                                            if (EndingDots[PlayerCount] != "Dot06")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot07") {
                                            if (EndingDots[PlayerCount] != "Dot07")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot09") {
                                            if (EndingDots[PlayerCount] != "Dot09")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        break;
                                    case 8:
                                        if (hit.collider.name == "Dot02") {
                                            if (EndingDots[PlayerCount] != "Dot02")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot04") {
                                            if (EndingDots[PlayerCount] != "Dot04")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot05") {
                                            if (EndingDots[PlayerCount] != "Dot05")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        else if (hit.collider.name == "Dot06") {
                                            if (EndingDots[PlayerCount] != "Dot06")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true;
                                        }
                                        else if (hit.collider.name == "Dot08") {
                                            if (EndingDots[PlayerCount] != "Dot08")
                                            {
                                                EndCondition.SetActive(true);
                                            }
                                            else
                                            {
                                                PlayerCount++;
                                            }
                                            HasPlaced = true; 
                                        }
                                        break;
                                }
                               
                            }
                            if (Input.GetMouseButtonDown(0))
                            {
                                HasPlaced = true;
                            }
                        }
                        else
                        {
                            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
                            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

                            if(LineCounter == 0)
                            {
                                Line_To_Delete = i;
                            }
                            LineCounter++;
                            if (LineCounter >= 1)
                            {
                                Line[Line_To_Delete].enabled = false;
                                isLineActive[Line_To_Delete] = false;
                                isOnelineActive = false;
                                HasPlaced = false;

                                LineCounter = 0;
                            }

                            switch (i)
                            {
                                case 0:
                                    HasPlaced = false;
                                    isLineActive[i] = false;
                                    isOnelineActive = false;
                                    if (hit.collider == null)
                                    {
                                       // Line[i].enabled = false;
                                        return;
                                    }

                                    switch (hit.collider.name)
                                    {                
                                        case "Dot02":
                                            Vector3[] EndingPos = new Vector3[2];
                                            EndingPos[1] = new Vector3(CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos);
                                            break;
                                        case "Dot04":
                                            Vector3[] EndingPos1 = new Vector3[2];
                                            EndingPos1[1] = new Vector3(0, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos1);
                                            break;
                                        case "Dot05":
                                            Vector3[] EndingPos2 = new Vector3[2];
                                            EndingPos2[1] = new Vector3(CloseXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos2);
                                            break;
                                        case "Dot06":
                                            Vector3[] EndingPos3 = new Vector3[2];
                                            EndingPos3[1] = new Vector3(FarXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos3);
                                            break;
                                        case "Dot08":
                                            Vector3[] EndingPos4 = new Vector3[2];
                                            EndingPos4[1] = new Vector3(CloseXAxis, -FarYAxis, 0);
                                            Line[i].SetPositions(EndingPos4);
                                            break;
                                        default:
                                          //  Line[i].enabled = false;
                                            break;
                                    }
                                    break;
                                case 1:
                                    isLineActive[i] = false;
                                    isOnelineActive = false;
                                    HasPlaced = false;
                                    if (hit.collider == null)
                                    {
                                      //  Line[i].enabled = false;
                                        return;
                                    }
                                    switch (hit.collider.name)
                                    {
                                        case "Dot01":
                                            Vector3[] EndingPos = new Vector3[2];
                                            EndingPos[1] = new Vector3(-CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos);
                                            break;
                                        case "Dot03":
                                            Vector3[] EndingPos2 = new Vector3[2];
                                            EndingPos2[1] = new Vector3(CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos2);
                                            break;
                                        case "Dot04":
                                            Vector3[] EndingPos3 = new Vector3[2];
                                            EndingPos3[1] = new Vector3(-CloseXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos3);
                                            break;
                                        case "Dot05":
                                            Vector3[] EndingPos4 = new Vector3[2];
                                            EndingPos4[1] = new Vector3(0, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos4);
                                            break;
                                        case "Dot06":
                                            Vector3[] EndingPos5 = new Vector3[2];
                                            EndingPos5[1] = new Vector3(CloseXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos5);
                                            break;
                                        case "Dot07":
                                            Vector3[] EndingPos6 = new Vector3[2];
                                            EndingPos6[1] = new Vector3(-CloseXAxis, -FarYAxis, 0);
                                            Line[i].SetPositions(EndingPos6);
                                            break;
                                        case "Dot09":
                                            Vector3[] EndingPos7 = new Vector3[2];
                                            EndingPos7[1] = new Vector3(CloseXAxis, -FarYAxis, 0);
                                            Line[i].SetPositions(EndingPos7);
                                            break;
                                        default:
                                          //  Line[i].enabled = false;
                                            break;
                                    }
                                    break;
                                case 2:
                                    HasPlaced = false;
                                    isLineActive[i] = false;
                                    isOnelineActive = false;
                                    if (hit.collider == null)
                                    {
                                      //  Line[i].enabled = false;
                                        return;
                                    }
                                    switch (hit.collider.name)
                                    {
                                        case "Dot02":
                                            Vector3[] EndingPos7 = new Vector3[2];
                                            EndingPos7[1] = new Vector3(-CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos7);
                                            break;
                                        case "Dot04":
                                            Vector3[] EndingPos6 = new Vector3[2];
                                            EndingPos6[1] = new Vector3(-FarXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos6);
                                            break;
                                        case "Dot05":
                                            Vector3[] EndingPos5 = new Vector3[2];
                                            EndingPos5[1] = new Vector3(-CloseXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos5);
                                            break;
                                        case "Dot06":
                                            Vector3[] EndingPos4 = new Vector3[2];
                                            EndingPos4[1] = new Vector3(0, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos4);
                                            break;
                                        case "Dot08":
                                            Vector3[] EndingPos3 = new Vector3[2];
                                            EndingPos3[1] = new Vector3(-CloseXAxis, -FarYAxis, 0);
                                            Line[i].SetPositions(EndingPos3);
                                            break;
                                        default:
                                          //  Line[i].enabled = false;
                                            break;
                                    }
                                    break;
                                case 3:
                                    HasPlaced = false;
                                    isLineActive[i] = false;
                                    isOnelineActive = false;
                                    if (hit.collider == null)
                                    {
                                      //  Line[i].enabled = false;
                                        return;
                                    }
                                    switch (hit.collider.name)
                                    {
                                        case "Dot01":
                                            Vector3[] EndingPos7 = new Vector3[2];
                                            EndingPos7[1] = new Vector3(0, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos7);
                                            break;
                                        case "Dot02":
                                            Vector3[] EndingPos = new Vector3[2];
                                            EndingPos[1] = new Vector3(CloseXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos);
                                            break;
                                        case "Dot03":
                                            Vector3[] EndingPos1 = new Vector3[2];
                                            EndingPos1[1] = new Vector3(FarXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos1);
                                            break;
                                        case "Dot05":
                                            Vector3[] EndingPos2 = new Vector3[2];
                                            EndingPos2[1] = new Vector3(CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos2);
                                            break;
                                        case "Dot07":
                                            Vector3[] EndingPos3 = new Vector3[2];
                                            EndingPos3[1] = new Vector3(0, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos3);
                                            break;
                                        case "Dot08":
                                            Vector3[] EndingPos4 = new Vector3[2];
                                            EndingPos4[1] = new Vector3(CloseXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos4);
                                            break;
                                        case "Dot09":
                                            Vector3[] EndingPos5 = new Vector3[2];
                                            EndingPos5[1] = new Vector3(FarXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos5);
                                            break;
                                        default:
                                           // Line[i].enabled = false;
                                            break;
                                    }
                                    break;
                                case 4:
                                    HasPlaced = false;
                                    isLineActive[i] = false;
                                    isOnelineActive = false;
                                    if (hit.collider == null)
                                    {
                                       // Line[i].enabled = false;
                                        return;
                                    }
                                    switch (hit.collider.name)
                                    {
                                        case "Dot01":
                                            Vector3[] EndingPos7 = new Vector3[2];
                                            EndingPos7[1] = new Vector3(-CloseXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos7);
                                            break;
                                        case "Dot02":
                                            Vector3[] EndingPos6 = new Vector3[2];
                                            EndingPos6[1] = new Vector3(0, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos6);
                                            break;
                                        case "Dot03":
                                            Vector3[] EndingPos5 = new Vector3[2];
                                            EndingPos5[1] = new Vector3(CloseXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos5);
                                            break;
                                        case "Dot04":
                                            Vector3[] EndingPos4 = new Vector3[2];
                                            EndingPos4[1] = new Vector3(-CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos4);
                                            break;
                                        case "Dot06":
                                            Vector3[] EndingPos3 = new Vector3[2];
                                            EndingPos3[1] = new Vector3(CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos3);
                                            break;
                                        case "Dot07":
                                            Vector3[] EndingPos2 = new Vector3[2];
                                            EndingPos2[1] = new Vector3(-CloseXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos2);
                                            break;
                                        case "Dot08":
                                            Vector3[] EndingPos = new Vector3[2];
                                            EndingPos[1] = new Vector3(0, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos);
                                            break;
                                        case "Dot09":
                                            Vector3[] EndingPos9 = new Vector3[2];
                                            EndingPos9[1] = new Vector3(CloseXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos9);
                                            break;
                                        default:
                                          //  Line[i].enabled = false;
                                            break;
                                    }
                                    break;
                                case 5:
                                    HasPlaced = false;
                                    isLineActive[i] = false;
                                    isOnelineActive = false;
                                    if (hit.collider == null)
                                    {
                                      //  Line[i].enabled = false;
                                        return;
                                    }
                                    switch (hit.collider.name)
                                    {
                                        case "Dot01":
                                            Vector3[] EndingPos7 = new Vector3[2];
                                            EndingPos7[1] = new Vector3(-FarXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos7);
                                            break;
                                        case "Dot02":
                                            Vector3[] EndingPos6 = new Vector3[2];
                                            EndingPos6[1] = new Vector3(-CloseXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos6);
                                            break;
                                        case "Dot03":
                                            Vector3[] EndingPos5 = new Vector3[2];
                                            EndingPos5[1] = new Vector3(0, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos5);
                                            break;
                                        case "Dot05":
                                            Vector3[] EndingPos4 = new Vector3[2];
                                            EndingPos4[1] = new Vector3(-CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos4);
                                            break;
                                        case "Dot07":
                                            Vector3[] EndingPos2 = new Vector3[2];
                                            EndingPos2[1] = new Vector3(-FarXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos2);
                                            break;
                                        case "Dot08":
                                            Vector3[] EndingPos = new Vector3[2];
                                            EndingPos[1] = new Vector3(-CloseXAxis, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos);
                                            break;
                                        case "Dot09":
                                            Vector3[] EndingPos9 = new Vector3[2];
                                            EndingPos9[1] = new Vector3(0, -CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos9);
                                            break;
                                        default:
                                         //   Line[i].enabled = false;
                                            break;
                                    }
                                    break;
                                case 6:
                                    HasPlaced = false;
                                    isLineActive[i] = false;
                                    isOnelineActive = false;
                                    if (hit.collider == null)
                                    {
                                      //  Line[i].enabled = false;
                                        return;
                                    }
                                    switch (hit.collider.name)
                                    {
                                        case "Dot02":
                                            Vector3[] EndingPos7 = new Vector3[2];
                                            EndingPos7[1] = new Vector3(CloseXAxis, FarYAxis, 0);
                                            Line[i].SetPositions(EndingPos7);
                                            break;
                                        case "Dot04":
                                            Vector3[] EndingPos6 = new Vector3[2];
                                            EndingPos6[1] = new Vector3(0, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos6);
                                            break;
                                        case "Dot05":
                                            Vector3[] EndingPos5 = new Vector3[2];
                                            EndingPos5[1] = new Vector3(CloseXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos5);
                                            break;
                                        case "Dot06":
                                            Vector3[] EndingPos4 = new Vector3[2];
                                            EndingPos4[1] = new Vector3(FarXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos4);
                                            break;
                                        case "Dot08":
                                            Vector3[] EndingPos3 = new Vector3[2];
                                            EndingPos3[1] = new Vector3(CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos3);
                                            break;
                                        default:
                                          //  Line[i].enabled = false;
                                            break;
                                    }
                                    break;
                                case 7:
                                    HasPlaced = false;
                                    isLineActive[i] = false;
                                    isOnelineActive = false;
                                    if (hit.collider == null)
                                    {
                                     //   Line[i].enabled = false;
                                        return;
                                    }
                                    switch (hit.collider.name)
                                    {
                                        case "Dot01":
                                            Vector3[] EndingPos7 = new Vector3[2];
                                            EndingPos7[1] = new Vector3(-CloseXAxis, FarYAxis, 0);
                                            Line[i].SetPositions(EndingPos7);
                                            break;
                                        case "Dot03":
                                            Vector3[] EndingPos6 = new Vector3[2];
                                            EndingPos6[1] = new Vector3(CloseXAxis, FarYAxis, 0);
                                            Line[i].SetPositions(EndingPos6);
                                            break;
                                        case "Dot04":
                                            Vector3[] EndingPos5 = new Vector3[2];
                                            EndingPos5[1] = new Vector3(-CloseXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos5);
                                            break;
                                        case "Dot05":
                                            Vector3[] EndingPos4 = new Vector3[2];
                                            EndingPos4[1] = new Vector3(0, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos4);
                                            break;
                                        case "Dot06":
                                            Vector3[] EndingPos2 = new Vector3[2];
                                            EndingPos2[1] = new Vector3(CloseXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos2);
                                            break;
                                        case "Dot07":
                                            Vector3[] EndingPos = new Vector3[2];
                                            EndingPos[1] = new Vector3(-CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos);
                                            break;
                                        case "Dot09":
                                            Vector3[] EndingPos9 = new Vector3[2];
                                            EndingPos9[1] = new Vector3(CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos9);
                                            break;
                                        default:
                                          //  Line[i].enabled = false;
                                            break;
                                    }
                                    break;
                                case 8:
                                    HasPlaced = false;
                                    isLineActive[i] = false;
                                    isOnelineActive = false;
                                    if (hit.collider == null)
                                    {
                                      //  Line[i].enabled = false;
                                        return;
                                    }
                                    switch (hit.collider.name)
                                    {
                                        case "Dot02":
                                            Vector3[] EndingPos7 = new Vector3[2];
                                            EndingPos7[1] = new Vector3(-CloseXAxis, FarYAxis, 0);
                                            Line[i].SetPositions(EndingPos7);
                                            break;
                                        case "Dot04":
                                            Vector3[] EndingPos6 = new Vector3[2];
                                            EndingPos6[1] = new Vector3(-FarXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos6);
                                            break;
                                        case "Dot05":
                                            Vector3[] EndingPos5 = new Vector3[2];
                                            EndingPos5[1] = new Vector3(-CloseXAxis, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos5);
                                            break;
                                        case "Dot06":
                                            Vector3[] EndingPos4 = new Vector3[2];
                                            EndingPos4[1] = new Vector3(0, CloseYAxis, 0);
                                            Line[i].SetPositions(EndingPos4);
                                            break;
                                        case "Dot08":
                                            Vector3[] EndingPos3 = new Vector3[2];
                                            EndingPos3[1] = new Vector3(-CloseXAxis, 0, 0);
                                            Line[i].SetPositions(EndingPos3);
                                            break;
                                        default:
                                        //    Line[i].enabled = false;
                                            break;
                                    }
                                    break;
                                default:
                                  //  Line[i].enabled = false;
                                    break;
                            }
                        }
                    }
                }
            }
            }
        }
}