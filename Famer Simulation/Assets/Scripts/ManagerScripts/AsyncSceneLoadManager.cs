using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AsyncSceneLoadManager : MonoPunSingletonManager<AsyncSceneLoadManager>
{
    [SerializeField] GameObject loadUi;

    [SerializeField] Slider progressBar;

    [SerializeField] TipText tipText;

    [SerializeField] TextMeshProUGUI tipTextUi;

    public void AsyncSceneLoad(string sceneName, int tipNum = -1)
    {
        tipTextUi.text = tipText.LoadTip(tipNum);

        StartCoroutine(AsyncSceneLoadProgress(sceneName));
    }

    private IEnumerator AsyncSceneLoadProgress(string sceneName)
    {
        if (!photonView.IsMine)
            yield break;

        BeforeSceneLoad();

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        operation.allowSceneActivation = false;

        float fakeLoading = 0.0f;

        while (true)
        {
            progressBar.value = operation.progress;

            fakeLoading += Time.unscaledDeltaTime;

            if (operation.progress >= 0.9f)
                break;

            yield return null;
        }

        while (true)
        {
            fakeLoading += Time.unscaledDeltaTime;

            progressBar.value = fakeLoading / 2.0f;

            if (fakeLoading >= 3.0f)
            {
                operation.allowSceneActivation = true;
                break;
            }

            yield return null;
        }

        yield return null;

        AfterSceneLoad();

    }

    private void BeforeSceneLoad()
    {
        loadUi.SetActive(true);
    
        Time.timeScale = 0.0f;
    }

    private void AfterSceneLoad()
    {
        Time.timeScale = 1.0f;

        progressBar.value = 0.0f;

        loadUi.SetActive(false);
    }

}
