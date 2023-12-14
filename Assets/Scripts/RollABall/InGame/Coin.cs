using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float bonusTime = 2f;
    private float disappearTime = 5f;

    private int scoreValue = 10;
    private int bunusScoreValue = 20;
    void Start()
    {
        StartCoroutine(BonusTimeCoroutine());
    }
    IEnumerator BonusTimeCoroutine()
    {
        // �����܂ł̓{�[�i�X�^�C����2�b�҂�
        yield return new WaitForSeconds(bonusTime);
        // �����鎞�Ԃ�5�b�Ȃ̂ŁA�{�[�i�X�^�C����2�b�����3�b�҂�
        yield return new WaitForSeconds(disappearTime - bonusTime);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Sphere")
        {
            Destroy(gameObject);
        }
    }
}