﻿using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace App_WepID

{
    [TestFixture]
    public class Tests
    {
        AndroidApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            // TODO: If the iOS app being tested is included in the solution then 
            // add a reference to the android project from the project containing this file
            app = ConfigureApp
                    .Android
                    // TODO: Update this path to point to your Android app and uncomment the
                    // code if the app is not included in the solution.
                    //.ApkFile ("..\..\..\Android\bin\Debug\UITestsAndroid.apk")
                    .ApkFile ("C:\\01_PROYECTOS\\002_Interprotección\\Sprint_02\\003_App\\com.inter.wepid (16).apk")
                    .StartApp();
        }

        [Test]
        public void AppLaunches()
        {
            app.Repl();
            app.Screenshot("First screen.");
            app.Screenshot("");
            //app.Tap()
            app.Tap("NoResourceEntry-11");
            app.Tap("NoResourceEntry-18");
            app.EnterText("5541380221");

            app.Tap("NoResourceEntry-21");
            app.EnterText("drfgdfgdf");

            app.Tap("NoResourceEntry-22");
            app.Screenshot("First screen.");
        }
    }
}

