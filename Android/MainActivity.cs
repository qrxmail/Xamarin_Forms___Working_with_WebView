﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;

namespace WorkingWithWebview.Android
{
    [Activity(Label = "WorkingWithWebview.Android.Android", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            Xamarin.Essentials.Platform.Init(this, bundle);

            LoadApplication(new App());
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        //DateTime? lastBackKeyDownTime;
        //public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        //{
        //    if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
        //    {
        //        if (!lastBackKeyDownTime.HasValue || DateTime.Now - lastBackKeyDownTime.Value > new TimeSpan(0, 0, 2))
        //        {
        //            Toast.MakeText(this.ApplicationContext, "再按一次退出程序", ToastLength.Short).Show();
        //            lastBackKeyDownTime = DateTime.Now;

        //        }
        //        else
        //        {
        //            Finish();
        //        }
        //        return true;
        //    }
        //    return base.OnKeyDown(keyCode, e);
        //}
    }
}
