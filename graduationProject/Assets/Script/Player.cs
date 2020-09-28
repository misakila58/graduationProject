using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    bool is_player;
    bool myTurn;
    GameManager gameManager;
    Queue q_player = new Queue();
    public int p_turn;
    public GameObject[] player = new GameObject[5];
    public GameObject Arrow;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }



    public void ChangeTurn()
    {
        p_turn++;
 
        
        switch (p_turn)
        {
    
            case 1:
                Vector3 pos = player[p_turn].transform.position;
                Arrow.transform.position = new Vector3(pos.x,pos.y +50,0);
                break;
            case 2:
                pos = player[p_turn].transform.position;
                Arrow.transform.position = new Vector3(pos.x, pos.y + 50, 0);
                break;
            case 3:
                pos = player[p_turn].transform.position;
                Arrow.transform.position = new Vector3(pos.x, pos.y + 50, 0);
                break;
            case 4:
                pos = player[p_turn].transform.position;
                Arrow.transform.position = new Vector3(pos.x, pos.y + 50, 0);
                break;
            case 5:
                p_turn = 1;
                goto case 1;
              
            default:
                break;
        }



    }
}
