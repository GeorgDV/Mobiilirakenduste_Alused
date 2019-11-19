using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Xamarin.Essentials;

namespace Xamarin_Essentials_Test
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView _batteryLevelTextView;
        TextView _deviceModeTextView;
        TextView _manufacturerTextView;
        TextView _deviceNameTextView;
        TextView _versionTextView;
        TextView _platformTextView;
        TextView _idiomTextView;
        TextView _deviceTypeTextView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            var _batteryLevelTextView = FindViewById<TextView>(Resource.Id.batteryLevelTextView);

            var _deviceModeTextView = FindViewById<TextView>(Resource.Id.deviceMode_TextView);
            var _manufacturerTextView = FindViewById<TextView>(Resource.Id.manufacturer_TextView);
            var _deviceNameTextView = FindViewById<TextView>(Resource.Id.deviceName_TextView);
            var _versionTextView = FindViewById<TextView>(Resource.Id.version_TextView);
            var _platformTextView = FindViewById<TextView>(Resource.Id.platform_TextView);
            var _idiomTextView = FindViewById<TextView>(Resource.Id.idiom_TextView);
            var _deviceTypeTextView = FindViewById<TextView>(Resource.Id.deviceType_TextView);


            var batteryLevel = Battery.ChargeLevel;
            _batteryLevelTextView.Text = batteryLevel.ToString();

            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;

            var deviceMode1 = DeviceInfo.Model;
            var manufacturer = DeviceInfo.Manufacturer;
            var deviceName = DeviceInfo.Name;
            var version = DeviceInfo.Version;
            var platform = DeviceInfo.Platform;
            var idiom = DeviceInfo.Idiom;
            var deviceType = DeviceInfo.DeviceType;

            _deviceModeTextView.Text = "Device Mode:" + deviceMode1;
            _manufacturerTextView.Text = "Manufacturer:" + manufacturer;
            _deviceNameTextView.Text = "Device Name:" + deviceName;
            _versionTextView.Text = "Version:" + version.ToString();
            _platformTextView.Text = "Platform:" + platform.ToString();
            _idiomTextView.Text = "Idiom:" + idiom.ToString();
            _deviceTypeTextView.Text = "Device Type:" + deviceType.ToString();

            System.Diagnostics.Debug.WriteLine("Deviceinfo: {0}, {1}, {2}, {3}, {4}, {5}, {6}",
                deviceMode1, manufacturer, deviceName, version, platform, idiom, deviceType);
        }

        private void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            _batteryLevelTextView.Text = Battery.ChargeLevel.ToString();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}