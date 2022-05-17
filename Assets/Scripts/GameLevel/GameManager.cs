using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject startImage;
    void Start()
    {
        if (PlayerPrefs.HasKey("whichgame"))
        {
            //Debug.Log(PlayerPrefs.GetString("whichgame"));
        }
        StartCoroutine(startWritingRoutine());

    }
    IEnumerator startWritingRoutine()
    {
        startImage.GetComponent<RectTransform>().DOScale(1.3f, 0.5f);
        yield return new WaitForSeconds(0.6f);
        startImage.GetComponent<RectTransform>().DOScale(0f, 0.5f).SetEase(Ease.InBack);
        startImage.GetComponent<CanvasGroup>().DOFade(0f, 1f);
        yield return new WaitForSeconds(0.6f);
         
        StartGame();
    }
    void StartGame()
    {
        Debug.Log("Oyun Baþladý.");
    }
}
