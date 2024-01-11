using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityEventSubscriber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public UnityEventPublisher publisher;
    public string debugMessage;

    public void OnEnable()
    {
        // サブスクライブ
        publisher?.Published.AddListener(DebugResponse);
    }

    public void OnDisable()
    {
        // サブスクリプション解除
        publisher?.Published.RemoveListener(DebugResponse);
    }

    public void DebugResponse()
    {
        Debug.Log("Unity Event: " + debugMessage);
    }

}
