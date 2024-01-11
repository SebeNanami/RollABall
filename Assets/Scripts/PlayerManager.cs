using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerManager : MonoBehaviour
{// Define the function template accepted by this event　（このイベントに受け取られる関数テンプレートを定義する）
    public static PlayerManager Instance { get; internal set; }

    // プレイヤーの名前
    public string playerName;

    // プレイヤーの年齢
    public int playerAge;

    // インスタンスをセットアップ
    public void Awake()
    {
        if (!Instance)
        {
            Instance = this;

            // シーンをまたがってもシングルトンを維持する
            DontDestroyOnLoad(this);
        }
        else if (Instance != this)
        {
            Destroy(this);
        }
    }
    // リスナーに更新があったことを通知するイベント
    public UnityEvent nameUpdated;

    // プレイヤー名の変更を可能にする
    public string PlayerName
    {
        set
        {
            playerName = value;
            nameUpdated?.Invoke();
        }
    }


    public DebugToolBis debugToolBis;
  
    //…その他複製した分全て… //

    // プレイヤー名の変更を可能にする
    public void OnEnable()
    {
        nameUpdated.AddListener(debugToolBis.PrintPlayerName);
     
        //…その他全て… //
    }

    public void OnDisable()
    {
        nameUpdated.RemoveListener(debugToolBis.PrintPlayerName);
       
        //…その他全て… //
    }


}
