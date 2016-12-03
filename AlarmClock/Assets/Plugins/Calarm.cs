using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class Calarm {

	[DllImport ("__Internal")]
	private static extern bool askForUserPermit();

	[DllImport ("__Internal")]
	private static extern void registerForAlarm (int hour, int minute);

	public static void askForUserPermitCS()
	{
		if (Application.platform != RuntimePlatform.OSXEditor) {
			askForUserPermit ();
		}
	}

	public static void registerForAlarmCS(int hours, int minutes)
	{
		if (Application.platform != RuntimePlatform.OSXEditor) {
			registerForAlarm (hours, minutes);
		}
	}

}
