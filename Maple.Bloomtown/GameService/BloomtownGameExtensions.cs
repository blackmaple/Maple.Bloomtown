﻿using Maple.MonoGameAssistant.GameContext;
using Maple.MonoGameAssistant.WebApi;
using Maple.MonoGameAssistant.WinApi;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.Bloomtown
{
    internal sealed class BloomtownGameExtensions()
    {
        internal static async Task RunWebApiServiceAsync(int millisecondsDelay = 18 * 1000)
        {
            var webapp = WebApiServiceExtensions.AsRunWebApiService(p =>
            {
                p.GameName = "Bloomtown A Different Story";
                p.QQ = "0";
                p.Http = true;
                p.AutoOpenUrl = true;
                p.Port = 49009;
            }, services =>
            {
                services.UseGameContextService<BloomtownGameService>();
            });

            //延迟启动
            await Task.Delay(millisecondsDelay).ConfigureAwait(false);
            await webapp.RunAsync().ConfigureAwait(false);

        }



        [ModuleInitializer]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2255:不应在库中使用 “ModuleInitializer” 属性", Justification = "<挂起>")]
        public static void Initializer()
        {
            _ = RunWebApiServiceAsync();
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = nameof(DllMain))]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static bool DllMain(nint hModule, [MarshalAs(UnmanagedType.U4)] EnumReasonForCall ul_reason_for_call, nint lpReserved)
        {
            switch (ul_reason_for_call)
            {
                case EnumReasonForCall.DLL_PROCESS_ATTACH:
                    {
                        break;
                    }
                case EnumReasonForCall.DLL_THREAD_ATTACH:
                case EnumReasonForCall.DLL_THREAD_DETACH:
                case EnumReasonForCall.DLL_PROCESS_DETACH:
                    {
                        break;
                    }

            }
            return true;
        }

    }
}
