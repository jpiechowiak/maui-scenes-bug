using Foundation;
using UIKit;

namespace MauiScenesBug;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override UISceneConfiguration GetConfiguration(UIApplication application,
        UISceneSession connectingSceneSession,
        UISceneConnectionOptions options)
    {
        if (connectingSceneSession.Role == UIWindowSceneSessionRole.CarTemplateApplication)
        {
            return new UISceneConfiguration("CarPlaySceneConfiguration", connectingSceneSession.Role);
        }

#pragma warning disable CA1416
        return base.GetConfiguration(application, connectingSceneSession, options);
#pragma warning restore CA1416
    }
}