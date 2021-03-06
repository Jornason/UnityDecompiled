using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	internal sealed class DebugLogHandler : ILogHandler
	{
		[GeneratedByOldBindingsGenerator, ThreadAndSerializationSafe]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_Log(LogType level, string msg, [Writable] Object obj);

		[GeneratedByOldBindingsGenerator, ThreadAndSerializationSafe]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_LogException(Exception exception, [Writable] Object obj);

		public void LogFormat(LogType logType, Object context, string format, params object[] args)
		{
			DebugLogHandler.Internal_Log(logType, string.Format(format, args), context);
		}

		public void LogException(Exception exception, Object context)
		{
			DebugLogHandler.Internal_LogException(exception, context);
		}
	}
}
