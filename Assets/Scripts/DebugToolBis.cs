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

    // �v���C���[�̖��O��\��
    public void PrintPlayerName()
    {
        Debug.Log(PlayerManager.Instance.playerName);
    }

    // �v���C���[�̖��O��\��
    public void PrintPlayerAge()
    {
        Debug.Log(PlayerManager.Instance.playerAge);
    }

}
