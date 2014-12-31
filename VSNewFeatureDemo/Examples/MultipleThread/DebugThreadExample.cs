﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VSNewFeatureDemo.Examples.MultipleThread
{
    class DebugThreadExample : IExample
    {
        /// <summary>
        /// The example displays the output like the following: 
        ///    The Show() thread calls this after starting the new InstanceCaller thread. 
        ///    The Show() thread calls this after starting the new StaticCaller thread. 
        ///    ServerClass.StaticMethod is running on another thread. 
        ///    ServerClass.InstanceMethod is running on another thread. 
        ///    The instance method called by the worker thread has ended. 
        ///    The static method called by the worker thread has ended.
        /// </summary>
        public void Show()
        {
            ServerClass serverObject = new ServerClass();

            // Create the thread object, passing in the 
            // serverObject.InstanceMethod method using a 
            // ThreadStart delegate.
            Thread InstanceCaller = new Thread(
                new ThreadStart(serverObject.InstanceMethod));

            // Start the thread.
            InstanceCaller.Start();

            Console.WriteLine("The Show() thread calls this after "
                + "starting the new InstanceCaller thread.");

            // Create the thread object, passing in the 
            // serverObject.StaticMethod method using a 
            // ThreadStart delegate.
            Thread StaticCaller = new Thread(
                new ThreadStart(ServerClass.StaticMethod));

            // Start the thread.
            StaticCaller.Start();

            Console.WriteLine("The Show() thread calls this after "
                + "starting the new StaticCaller thread.");
        }
    }

    public class ServerClass
    {
        // The method that will be called when the thread is started. 
        public void InstanceMethod()
        {
            Console.WriteLine(
                "ServerClass.InstanceMethod is running on another thread.");

            // Pause for a moment to provide a delay to make 
            // threads more apparent.
            Thread.Sleep(3000);
            Console.WriteLine(
                "The instance method called by the worker thread has ended.");
        }

        public static void StaticMethod()
        {
            Console.WriteLine(
                "ServerClass.StaticMethod is running on another thread.");

            // Pause for a moment to provide a delay to make 
            // threads more apparent.
            Thread.Sleep(5000);
            Console.WriteLine(
                "The static method called by the worker thread has ended.");
        }
    }
}
