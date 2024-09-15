using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class AdsInterstitial : MonoBehaviour
{
    InterstitialAd geçişreklamı;
    // Start is called before the first frame update
    void Start()
    {
#if UNITY_ANDROID
        string appId = "ca-app-pub-1950496242457414~8857979715";
#elif UNITY_IPHONE
            string appId = "todo";
#else
            string appId = "unexpected_platform";
#endif

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);

        GeçişReklamıİstek();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void GeçişReklamıİstek()
    {

        //if (geçişreklamı != null)
        //{
        //    geçişreklamı.Destroy();
        //}
            

        geçişreklamı = new InterstitialAd("ca-app-pub-1950496242457414/1323104620");
        AdRequest reklamIstegi = new AdRequest.Builder().Build();
        geçişreklamı.LoadAd(reklamIstegi);


    }


    public void GeçişReklamınıGöster()
    {
        if (geçişreklamı.IsLoaded()==true)
        {
            geçişreklamı.Show();
        }

    }
    void OnDestroy()
    {
        if (geçişreklamı != null)
            geçişreklamı.Destroy();
    }
}
