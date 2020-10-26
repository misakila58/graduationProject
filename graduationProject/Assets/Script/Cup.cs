using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour
{

    bool checkTime; //True일 시 자신의 턴 시작 False일 시 시간 시작


    public Player player;

    [SerializeField]
    GameManager gameManager;
    
    public float time;
    public int pTouchCount; // 누른 횟수를 카운트 플레이어
    public int cTouchCount; // 누른 횟수를 카운트 컴퓨터

    // Start is called before the first frame update
    void Start()
    {
        checkTime = true;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void HitCup()
    {
        if (player.isPlayer == true)
        {
            if (checkTime == true)
            {
                checkTime = false;
                StartCoroutine(WaitForIt());
            }

            if (checkTime == false)
            {
                pTouchCount++;
                if(pTouchCount>=4)
                {
                    player.DrinkBeer();
                }
            }
                
        }
       


        else if(player.isPlayer == false)
        {
                checkTime = false;
                StartCoroutine(WaitForIt());
            if (checkTime == false)
            {
                cTouchCount += Random.Range(1, 4);
                cTouchCount %= 4;
            }
              
        }
      
       
    }

    public void NotMyTurn()
    {
        if (player.isPlayer == false)
        {
            player.DrinkBeer();
        }
      
    }

    IEnumerator WaitForIt()
    {
        int temp = 0;
        if (player.isPlayer == false)
        {
            yield return new WaitForSeconds(1.5f);
        }
        else
        yield return new WaitForSeconds(0.7f);

        if (player.isPlayer == true)
        {
            temp = pTouchCount;
            pTouchCount = 0;
        }
        else
        {
            temp = cTouchCount;
            cTouchCount = 0;
        }
         

        player.ChangeTurn(temp);
        checkTime = true;
    }

    //터치를 시작한 뒤 시간을 기록함 (터치 시 터치 카운트를 증가) 그 후 1초 뒤에 터치한 횟수 만큼의 플레이어 체인지 함수를 실행해줌 
}
