using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugToolBis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // プレイヤーの名前を表示
    public void PrintPlayerName()
    {
        Debug.Log(PlayerManager.Instance.playerName);
    }

    // プレイヤーの名前を表示
    public void PrintPlayerAge()
    {
        Debug.Log(PlayerManager.Instance.playerAge);
    }

}
