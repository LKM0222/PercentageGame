using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScript : MonoBehaviour
{
    [SerializeField] Image loadingBar;

    private void Start() {
        loadingBar.fillAmount = 0f;
        StartCoroutine(LoadAsyncScene());
    }

    private static void LoadScene(string _name){
        SceneManager.LoadScene(_name);
    }

    IEnumerator LoadAsyncScene(){
        yield return null;
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync("GameScene");
        asyncOperation.allowSceneActivation = false;
        float timeC = 0f;
        while(!asyncOperation.isDone){
            yield return null;
            timeC += Time.deltaTime;
            if(asyncOperation.progress >= 0.9f)
            {
                loadingBar.fillAmount = Mathf.Lerp(loadingBar.fillAmount,1,timeC);
                if(loadingBar.fillAmount == 1.0f){
                    asyncOperation.allowSceneActivation = true;
                }
            }
            else{
                loadingBar.fillAmount = Mathf.Lerp(loadingBar.fillAmount,asyncOperation.progress,timeC);
                if(loadingBar.fillAmount >= asyncOperation.progress){
                    timeC = 0f;
                }
            }
        }
    }
}
