using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public bool isPlayer; // true면 플레이어 false면 컴퓨터 
    public bool myTurn;
    public int p_turn;
    public int life;

    GameManager gameManager;
  
    public Cup cupGame;
    CameraShake cameraShake;

    public GameObject[] player = new GameObject[5];
    public GameObject arrow;

    // Start is called before the first frame update
    void Start()
    {
        life = 3;
        p_turn = 1;
        OpinionPlayer();
        cameraShake = GameObject.Find("MainCamera").GetComponent<CameraShake>();
        
    }
    // Update is called once per frame
    void Update()
    {
       
    }

    public void OpinionPlayer()
    {

        if (p_turn == 1)
        {
            isPlayer = true;
        }
        else
        {
            Debug.Log("OpinionPlayer() Else문 실행");
            isPlayer = false;
            cupGame.HitCup();
            Debug.Log("OpinionPlayer() HitCup실행");
        }
         

    }


    public void ReStartPlayer()
    {

    }

    public void DrinkBeer()
    {
        life--;
        switch (life)
        {
            case 1:
                cameraShake.shakeAmount = 2;
                cameraShake.shakeDuration = 100.0f;
                break;
            case 2:
                cameraShake.shakeDuration = 100.0f;
                cameraShake.shakeAmount = 0.6f;
                break;
            case 3:
                cameraShake.shakeAmount = 0;
                break;
            default:
                break;


        }
    }



    public void ChangeTurn(int touchCount)
    {
        switch (touchCount)
        {
            case 1: // 다음사람
                p_turn++;
             
                switch (p_turn)
                {

                    case 1:
                        Vector3 pos = player[p_turn].transform.position;
                        arrow.transform.position = new Vector3(pos.x, pos.y + 10, pos.z);
                        break;
                    case 2:
                        pos = player[p_turn].transform.position;
                        arrow.transform.position = new Vector3(pos.x, pos.y + 10, pos.z);
                        break;
                    case 3:
                        pos = player[p_turn].transform.position;
                        arrow.transform.position = new Vector3(pos.x, pos.y + 10, pos.z);
                        break;
                    case 4:
                        pos = player[p_turn].transform.position;
                        arrow.transform.position = new Vector3(pos.x, pos.y + 10, pos.z);
                        break;
                    case 5:
                        p_turn = 1;
                        goto case 1;

                    default:
                        break;
                }
                OpinionPlayer();
                break;
            case 2: // 이전사람
                p_turn--;
              
                switch (p_turn)
                {

                    case 1:
                        Vector3 pos = player[p_turn].transform.position;
                        arrow.transform.position = new Vector3(pos.x, pos.y + 10, pos.z);
                        break;
                    case 2:
                        pos = player[p_turn].transform.position;
                        arrow.transform.position = new Vector3(pos.x, pos.y + 10, pos.z);
                        break;
                    case 3:
                        pos = player[p_turn].transform.position;
                        arrow.transform.position = new Vector3(pos.x, pos.y + 10, pos.z);
                        break;
                    case 4:
                        pos = player[p_turn].transform.position;
                        arrow.transform.position = new Vector3(pos.x, pos.y + 10, pos.z);
                        break;
                    case 0:
                        p_turn = 4;
                        goto case 4;

                    default:
                     
                        break;
                }
                OpinionPlayer();
                break;
         
            case 3: // 점프
                p_turn++;
                p_turn++;
                if(p_turn != 4)
                p_turn = p_turn % 4;
                switch (p_turn)
                {
                case 1:
                        Vector3 pos = player[p_turn].transform.position;
                        arrow.transform.position = new Vector3(pos.x, pos.y + 10, pos.z);
                        break;
                    case 2:
                        pos = player[p_turn].transform.position;
                        arrow.transform.position = new Vector3(pos.x, pos.y + 10, pos.z);
                        break;
                    case 3:
                        pos = player[p_turn].transform.position;
                        arrow.transform.position = new Vector3(pos.x, pos.y + 10, pos.z);
                        break;
                    case 4:
                        pos = player[p_turn].transform.position;
                        arrow.transform.position = new Vector3(pos.x, pos.y + 10, pos.z);
                        break;
                    case 5:
                        p_turn = 1;
                        goto case 1;

                    default:
                        break;
                }
                OpinionPlayer();
                break;

            default:
                break;


        }

       



    }
}
