using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;
public class InterstitialGameOver : MonoBehaviour
{
    private InterstitialAd interstitial;
    // Start is called before the first frame update
    void Awake () {
        DontDestroyOnLoad (transform.gameObject);
    }
    public void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });
        this.RequestInterstitial();
    }
    // Update is called once per frame
    void Update()
    {
        GameOver();
    }

    private void RequestInterstitial()
    {
    
        string adUnitId = "ca-app-pub-4801832459066754/7151557165";
        this.interstitial = new InterstitialAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        this.interstitial.LoadAd(request);
    }
    private void GameOver()
    {
        if (this.interstitial.IsLoaded() &&  SceneManager.GetActiveScene().name=="FimJogo") {
            this.interstitial.Show();
        }
       
    }
}
