using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class GoogleMobileAdsDemoScript : MonoBehaviour
{
    private BannerView bannerView;
    // Start is called before the first frame update
    // void Awake()
  
    void Start()
    {
        MobileAds.Initialize(initStatus => { });
        this.RequestBanner();
    }

    // Update is called once per frame
    void Update()
    {
        HideAd();
    }
     private void RequestBanner()
    {
        //id certo do banner    ca-app-pub-4801832459066754/3424582063
        string adUnitId = "ca-app-pub-4801832459066754/3424582063";
        // Create a 320x50 banner at the top of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);
    }

    public void HideAd()
    {
        if(SceneManager.GetActiveScene().name=="FimJogo"){
            bannerView.Hide ();
        }else{
            bannerView.Show ();
        }
   
    }
}
