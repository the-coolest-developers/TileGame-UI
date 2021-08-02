﻿using System.Drawing;
using UnrealEngine.Framework;

namespace TileGameUI
{
	public class Main
	{
		// Indicates the main entry point for automatic loading by the plugin
		public static void OnWorldBegin() =>
			Debug.AddOnScreenMessage(-1, 10.0f, Color.DeepPink, "IT FINALLY WOOOOOOOOOOORRRRRRRRRKKKKSSSSSS!");

		public static void OnWorldPostBegin() => Debug.AddOnScreenMessage(-1, 10.0f, Color.DeepPink, "How's it going?");

		public static void OnWorldEnd() =>
			Debug.AddOnScreenMessage(-1, 10.0f, Color.DeepPink, "See you soon, Unreal Engine!");

		public static void OnWorldPrePhysicsTick(float deltaTime) =>
			Debug.AddOnScreenMessage(1, 10.0f, Color.DeepPink, "On pre physics tick invoked!");

		public static void OnWorldDuringPhysicsTick(float deltaTime) =>
			Debug.AddOnScreenMessage(2, 10.0f, Color.DeepPink, "On during physics tick invoked!");

		public static void OnWorldPostPhysicsTick(float deltaTime) =>
			Debug.AddOnScreenMessage(3, 10.0f, Color.DeepPink, "On post physics tick invoked!");

		public static void OnWorldPostUpdateTick(float deltaTime) =>
			Debug.AddOnScreenMessage(4, 10.0f, Color.DeepPink, "On post update tick invoked!");
	}
}