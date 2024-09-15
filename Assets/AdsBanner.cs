using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdsBanner : MonoBehaviour
{
  private BannerView bannerView;

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

      this.RequestBanner();
    }

    private void RequestBanner()
      {
          #if UNITY_ANDROID
              string adUnitId = "ca-app-pub-1950496242457414/9895729218";
          #elif UNITY_IPHONE
              string adUnitId = "";
          #else
              string adUnitId = "unexpected_platform";
          #endif

          // Create a 320x50 banner at the top of the screen.
          bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
          AdRequest request = new AdRequest.Builder().Build();
          bannerView.LoadAd(request);
      }
}
