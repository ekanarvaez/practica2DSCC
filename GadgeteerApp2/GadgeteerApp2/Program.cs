﻿using System;
using System.Collections;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Presentation;
using Microsoft.SPOT.Presentation.Controls;
using Microsoft.SPOT.Presentation.Media;
using Microsoft.SPOT.Presentation.Shapes;
using Microsoft.SPOT.Touch;

using Gadgeteer.Networking;
using GT = Gadgeteer;
using GTM = Gadgeteer.Modules;
using Gadgeteer.Modules.GHIElectronics;

namespace GadgeteerApp2
{
    public partial class Program
    {

        Bitmap cam;
        // This method is run when the mainboard is powered up or reset.   
        void ProgramStarted()
        {
            camera.CameraConnected += camera_CameraConnected;
            
            camera.BitmapStreamed +=camera_BitmapStreamed;
            camera.StartStreaming();
        //    camera.BitmapStreamed
            
           // camera.BitmapStreamed += new Camera.BitmapStreamedEventHandler(camera_BitmapStreamed);
           



            
           
            /*******************************************************************************************
            Modules added in the Program.gadgeteer designer view are used by typing 
            their name followed by a period, e.g.  button.  or  camera.
            
            Many modules generate useful events. Type +=<tab><tab> to add a handler to an event, e.g.:
                button.ButtonPressed +=<tab><tab>
            
            If you want to do something periodically, use a GT.Timer and handle its Tick event, e.g.:
                GT.Timer timer = new GT.Timer(1000); // every second (1000ms)
                timer.Tick +=<tab><tab>
                timer.Start();
            *******************************************************************************************/


            // Use Debug.Print to show messages in Visual Studio's "Output" window during debugging.
            Debug.Print("Program Started");
          

        }

        void camera_CameraConnected(Camera sender, EventArgs e)
        {
           
            camera.StartStreaming();
            Debug.Print("555555");
        }
        void camera_BitmapStreamed(Camera sender, Bitmap bitmap)
        {
            displayT35.SimpleGraphics.DisplayImage(bitmap, 0, 0);
            Debug.Print("HEllo");
        }
    
    }
}
