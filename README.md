<p align="center">
  <a>
    <img alt="Made With Unity" src="https://img.shields.io/badge/made%20with-Unity-57b9d3.svg?logo=Unity">
  </a>
  <a>
    <img alt="License" src="https://img.shields.io/github/license/lazycoder71/LazyCoder.AppStore?logo=github">
  </a>
  <a>
    <img alt="Last Commit" src="https://img.shields.io/github/last-commit/lazycoder71/LazyCoder.AppStore?logo=Mapbox&color=orange">
  </a>
  <a>
    <img alt="Repo Size" src="https://img.shields.io/github/repo-size/lazycoder71/LazyCoder.AppStore?logo=VirtualBox">
  </a>
  <a>
    <img alt="Last Release" src="https://img.shields.io/github/v/release/lazycoder71/LazyCoder.AppStore?include_prereleases&logo=Dropbox&color=yellow">
  </a>
</p>

# Installation

1. Open the Package Manager from Window > Package Manager.
2. Click the "+" button > Add package from git URL.
3. Enter the following URL:

```
https://github.com/lazycoder71/LazyCoder.AppStore.git
```

# Usages

```csharp
using LazyCoder.AppStore;

public class RateExample : MonoBehaviour
{
        private void Start()
        {
            // Init at start
            AppStore.Init();
        }

        // Call this to request rating view, if fail it will go directly to store page
        public void Rate()
        {
#if UNITY_IPHONE || UNITY_IOS
            AppStore.Review("YOUR_APP_STORE_ID_HERE");
#else
            AppStore.Review();
#endif
        }
		
		public void OpenStore()
		{
			AppStore.OpenStore();
		}
}
```

If you got missing class error with classes bellow on device (Android), add this to your proguard file.

```text
-keep class com.google.android.play.core.** { *; }
```
