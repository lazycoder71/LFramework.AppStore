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
