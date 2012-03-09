using System;
using System.Collections.Generic;
using MonoTouch.UIKit;
using Microsoft.Xna.Framework.Media;
using System.Diagnostics;

namespace Microsoft.Xna.Framework
{
	public class ExEnEmTouchApplication : UIApplicationDelegate
	{

		// TODO: make Game register itself automatically!
		protected Game Game = null;


		public override void OnResignActivation(UIApplication application)
		{
			Console.WriteLine("ExEnEmTouchApplication.OnResignActivation()");

			if(Game != null)
				Game.IsActive = false;
		}

		public override void OnActivated(UIApplication application)
		{
			Console.WriteLine("ExEnEmTouchApplication.OnActivated()");

			if(Game != null)
				Game.IsActive = true;

			MediaPlayer.MusicRestartHack();
		}


		public override void WillTerminate(UIApplication application)
		{
			Console.WriteLine("ExEnEmTouchApplication.WillTerminate()");

			if(Game != null)
				Game.DoTermination();
		}

		public override void DidEnterBackground(UIApplication application)
		{
			Console.WriteLine("ExEnEmTouchApplication.DidEnterBackground()");

			if(Game != null)
				Game.DoEnterBackground();
		}

		public override void WillEnterForeground(UIApplication application)
		{
			Console.WriteLine("ExEnEmTouchApplication.WillEnterForeground()");

			if(Game != null)
				Game.DoEnterForeground();
		}
	}
}
