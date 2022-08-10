﻿#if __IOS__ || MACCATALYST
using PlatformView = MapKit.MKOverlayRenderer;
#elif MONOANDROID
using Android.Gms.Maps;
using PlatformView = Android.Gms.Maps.Model.MarkerOptions;
#elif WINDOWS
using PlatformView = System.Object;
#elif TIZEN
using PlatformView = System.Object;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0 && !IOS && !ANDROID && !TIZEN)
using PlatformView = System.Object;
#endif

namespace Microsoft.Maui.Maps.Handlers
{
	public interface IMapElementHandler : IElementHandler
	{
		new IMapElement VirtualView { get; }
		new PlatformView PlatformView { get; }
	}
}
